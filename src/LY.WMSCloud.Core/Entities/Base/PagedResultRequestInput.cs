using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace LY.WMSCloud.Entities
{
    /// <summary>
    /// 对Linq进行扩展,使其一定程度内可进行动态查询
    /// </summary>
    public static class ExtentionLinq
    {
        /// <summary>
        /// 对Linq进行扩展,使其一定程度内可进行动态查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceData">源数据</param>
        /// <param name="pagedResultRequestWMSDto">查询参数</param>
        /// <returns>返回查询</returns>
        public static IQueryable<T> DynamicQuery<T>(this IQueryable<T> sourceData, PagedResultRequestInput pagedResultRequestWMSDto)
        {
            Expression totalExpr = null;
            Type queryConditionType = typeof(T);

            ParameterExpression param = Expression.Parameter(queryConditionType, "n");
            var properties = queryConditionType.GetProperties();

            if (pagedResultRequestWMSDto.RequestWMSDtos != null)
            {
                totalExpr = GetWhereExpression(pagedResultRequestWMSDto.RequestWMSDtos, param, properties);
            }
            if (totalExpr == null)
            {
                totalExpr = Expression.Constant(true);
            }

            //Where部分条件
            Expression pred = Expression.Lambda(totalExpr, param);

            Expression whereExpression = Expression.Call(typeof(Queryable), "Where", new Type[] { queryConditionType }, Expression.Constant(sourceData), pred);

            //OrderBy部分排序
            if (pagedResultRequestWMSDto.SortName != null)
            {
                var orderBy = properties.Where(p => p.Name.ToLower() == pagedResultRequestWMSDto.SortName.ToLower()).FirstOrDefault();

                if (orderBy == null)
                {
                    sourceData = sourceData.Provider.CreateQuery<T>(whereExpression);
                }
                else
                {
                    MethodCallExpression orderByCallExpression = Expression.Call
                    (
                       typeof(Queryable),
                       pagedResultRequestWMSDto.Desc ? "OrderByDescending" : "OrderBy",
                       new Type[] { queryConditionType, orderBy.PropertyType },
                       whereExpression,
                       Expression.Lambda(Expression.Property(param, orderBy.Name), param)
                    );

                    sourceData = sourceData.Provider.CreateQuery<T>(orderByCallExpression);
                }
            }
            else
            {
                sourceData = sourceData.Provider.CreateQuery<T>(whereExpression);
            }
            // 获取 SQL 语句已注释
            // var sql = sourceData.ToSql();
           
            return sourceData;
        }

        private static Expression GetWhereExpression(List<RequestWMSDto> requestMESDtos, ParameterExpression param, PropertyInfo[] properties)
        {
            Expression totalExpr = null;
            foreach (var requestMESDto in requestMESDtos)
            {
                Expression filter = null;
                if (requestMESDto.RequestWMSDtos == null || requestMESDto.RequestWMSDtos.Count == 0)
                {
                    if (requestMESDto.PropertyName == null)
                    {
                        continue;
                    }

                    var propertie = properties.Where(p => p.Name.ToLower() == requestMESDto.PropertyName.ToLower()).FirstOrDefault();
                    if (propertie == null)
                    {
                        continue;
                    }

                    try
                    {
                        Type type = propertie.PropertyType;
                        Expression left = null;
                        Expression right = null;

                        if (IsNullableType(type))
                        {
                            left = Expression.Property(Expression.Property(param, propertie), "Value");
                            type = type.GetProperty("Value").PropertyType;
                        }
                        else
                        {
                            left = Expression.Property(param, propertie);
                        }

                        //propertie.PropertyType
                        //等式右边的值    并将右边的数据类型强转为左边的   
                        if (type.BaseType.Name == "Enum")
                        {
                            right = Expression.Constant(System.Enum.Parse(type, requestMESDto.QueryValue.ToString(), true));
                        }
                        else
                        {

                            if (type.Name == "DateTime")
                            {
                                // requestMESDto.QueryValue = ((DateTime)requestMESDto.QueryValue).ToLocalTime();
                                right = Expression.Constant(Convert.ChangeType(((DateTime)requestMESDto.QueryValue).ToLocalTime(), type));
                            }
                            else
                            {
                                right = Expression.Constant(Convert.ChangeType(requestMESDto.QueryValue, type));
                            }
                        }

                        //各种操作的具体处理                  
                        switch (requestMESDto.Operation)
                        {
                            case Operation.Contains:
                                if (requestMESDto.QueryValue.ToString() != "")
                                {
                                    filter = Expression.Call(left, type.GetMethod(requestMESDto.Operation.ToString()), right);
                                }
                                break;
                            case Operation.NotContains:
                            case Operation.RegEx:
                            case Operation.StartsWith:
                            case Operation.EndsWith:
                                filter = Expression.Call(typeof(ExtentionLinq).GetMethod(requestMESDto.Operation.ToString()), left, right);
                                break;
                            case Operation.NotEmpty:
                            case Operation.NotNull:
                                filter = Expression.Call(typeof(ExtentionLinq).GetMethod(requestMESDto.Operation.ToString()), left);
                                break;
                            case Operation.Equal:
                                filter = Expression.Equal(left, right);
                                break;
                            case Operation.NotEqual:
                                filter = Expression.NotEqual(left, right);
                                break;
                            case Operation.GreaterThan:
                                filter = Expression.GreaterThan(left, right);
                                break;
                            case Operation.GreaterThanOrEqual:
                                filter = Expression.GreaterThanOrEqual(left, right);
                                break;
                            case Operation.LessThan:
                                filter = Expression.LessThan(left, right);
                                break;
                            case Operation.LessThanOrEqual:
                                filter = Expression.LessThanOrEqual(left, right);
                                break;
                            case Operation.Empry:
                                filter = Expression.Equal(left, Expression.Constant(""));
                                break;
                            case Operation.Null:
                                filter = Expression.Equal(left, Expression.Constant(null));
                                break;
                        }
                        if (filter != null)
                        {
                            if (totalExpr == null)
                            {

                                totalExpr = filter;
                            }
                            else
                            {
                                switch (requestMESDto.LinkOperation)
                                {
                                    case LinkOperation.And:
                                        totalExpr = Expression.And(filter, totalExpr);
                                        break;
                                    case LinkOperation.Or:
                                        totalExpr = Expression.Or(filter, totalExpr);
                                        break;
                                }
                            }
                        }

                    }
                    catch
                    {

                    }
                }
                else
                {
                    var subExpression = GetWhereExpression(requestMESDto.RequestWMSDtos, param, properties);


                    if (subExpression != null)
                    {
                        if (totalExpr == null)
                        {

                            totalExpr = subExpression;

                        }
                        else
                        {
                            switch (requestMESDto.LinkOperation)
                            {

                                case LinkOperation.And:
                                    totalExpr = Expression.And(GetWhereExpression(requestMESDto.RequestWMSDtos, param, properties), totalExpr);
                                    break;
                                case LinkOperation.Or:
                                    totalExpr = Expression.Or(GetWhereExpression(requestMESDto.RequestWMSDtos, param, properties), totalExpr);
                                    break;
                            }
                        }
                    }


                }
            }

            return totalExpr;
        }
        private static bool IsNullableType(Type theType) => (theType.IsGenericType && theType.
              GetGenericTypeDefinition().Equals
              (typeof(Nullable<>)));

        /// <summary>
        /// 不包含表达式
        /// </summary>
        /// <param name="t">判定字符</param>
        /// <param name="str">参考字符</param>
        /// <returns>是否包含</returns>
        private static bool NotContains(object t, string str) => !(t.ToString().Contains(str));

        private static bool NotEmpty(object t) => !(t.ToString() == "");

        private static bool NotNull(object t) => !(t.ToString() == null);

        private static bool RegEx(object t, string regEx) => Regex.IsMatch(t.ToString(), regEx);

        private static bool StartsWith(object t, string str) => t.ToString().StartsWith(str);

        private static bool EndsWith(object t, string str) => t.ToString().EndsWith(str);
    }

    /// <summary>
    /// 分页查询对象
    /// </summary>
    public class PagedResultRequestInput : IPagedResultRequest
    {
        /// <summary>
        /// 开始行
        /// </summary>
        public int SkipCount { get; set; }
        /// <summary>
        /// 获取数量
        /// </summary>
        public int MaxResultCount { get; set; }
        /// <summary>
        /// 筛选条件
        /// </summary>
        public List<RequestWMSDto> RequestWMSDtos { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string SortName { get; set; }
        /// <summary>
        /// 是否倒序
        /// </summary>
        public bool Desc { get; set; }

    }
    /// <summary>
    /// 筛选条件
    /// </summary>
    public class RequestWMSDto
    {
        /// <summary>
        /// 属性名
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        public Operation Operation { get; set; }
        /// <summary>
        /// 查询参考值
        /// </summary>
        public object QueryValue { get; set; }
        /// <summary>
        /// 链接符
        /// </summary>
        public LinkOperation LinkOperation { get; set; }
        /// <summary>
        /// 子查询
        /// </summary>
        public List<RequestWMSDto> RequestWMSDtos { get; set; }
    }

    /// <summary>
    /// 链接符
    /// </summary>
    public enum LinkOperation
    {
        And = 0,
        Or
    }

    /// <summary>
    /// 操作符
    /// </summary>
    public enum Operation
    {
        /// <summary>
        /// 等于
        /// </summary>
        Equal = 0,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqual,
        /// <summary>
        /// 包含
        /// </summary>
        Contains,
        /// <summary>
        /// 以***开始
        /// </summary>
        StartsWith,
        /// <summary>
        /// 以***结尾
        /// </summary>
        EndsWith,
        /// <summary>
        /// 不包含
        /// </summary>
        NotContains,
        /// <summary>
        /// 大于
        /// </summary>
        GreaterThan,
        /// <summary>
        /// 大于等于
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// 小于
        /// </summary>
        LessThan,
        /// <summary>
        /// 小于等于
        /// </summary>
        LessThanOrEqual,
        /// <summary>
        /// 为空
        /// </summary>
        Empry,
        /// <summary>
        /// 不为空
        /// </summary>
        NotEmpty,
        /// <summary>
        /// 为NULL
        /// </summary>
        Null,
        /// <summary>
        /// 不为NULL
        /// </summary>
        NotNull,
        /// <summary>
        /// 正则匹配
        /// </summary>
        RegEx
    }
}
