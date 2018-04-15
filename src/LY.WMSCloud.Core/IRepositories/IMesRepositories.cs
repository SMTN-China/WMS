using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LY.WMSCloud.Entities;

namespace LY.WMSCloud
{
    public interface IWMSRepositories<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>, new()
    {
        /// <summary>
        /// 不用查询实体的批量删除
        /// </summary>
        /// <param name="predicate">查询表达式</param>
        /// <returns></returns>
        int BatchDelete(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 不用查询实体的异步的批量删除
        /// </summary>
        /// <param name="predicate">查询表达式</param>
        /// <returns>异步任务</returns>
        Task<int> BatchDeleteAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 不用查询实体的批量更新
        /// </summary>
        /// <param name="predicate">查询表达式</param>
        /// <param name="wmsParameters">更新内容</param>
        /// <returns>受影响的行</returns>
        int BatchUpdate(Expression<Func<TEntity, bool>> predicate, params LYParameter<TEntity, object>[] wmsParameters);
        /// <summary>
        /// 不用查询实体的异步批量更新
        /// </summary>
        /// <param name="predicate">查询表达式</param>
        /// <param name="wmsParameters">更新内容</param>
        /// <returns>受影响的行</returns>
        Task<int> BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, params LYParameter<TEntity, object>[] wmsParameters);
        /// <summary>
        /// 动态查询
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>返回查询</returns>
        IQueryable<TEntity> DynamicQuery(PagedResultRequestInput input);
    }

    public interface IWMSRepositories<TEntity> : IWMSRepositories<TEntity, int> where TEntity : class, IEntity<int>, new()
    {

    }
}
