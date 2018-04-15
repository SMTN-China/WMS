using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.Lolita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LY.WMSCloud.Entities;

namespace LY.WMSCloud.EntityFrameworkCore.Repositories
{
    public class WMSRepositories<TEntity, TPrimaryKey> : WMSCloudRepositoryBase<TEntity, TPrimaryKey>, IWMSRepositories<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>, new()
    {
        public WMSRepositories(IDbContextProvider<WMSCloudDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public int BatchDelete(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate).Delete();
        }

        public Task<int> BatchDeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate).DeleteAsync();
        }

        public int BatchUpdate(Expression<Func<TEntity, bool>> predicate, params LYParameter<TEntity, object>[] wmsParameters)
        {
            if (wmsParameters.Length > 0)
            {
                LolitaSetting<TEntity> lolitaSetting = null;
                foreach (var batchUpdateConditiong in wmsParameters)
                {
                    if (lolitaSetting == null)
                    {
                        lolitaSetting = GetAll().Where(predicate).SetField(batchUpdateConditiong.Property).WithValue(batchUpdateConditiong.Value);
                    }
                    else
                    {
                        lolitaSetting = lolitaSetting.SetField(batchUpdateConditiong.Property).WithValue(batchUpdateConditiong.Value);
                    }
                }

                return lolitaSetting.Update();
            }

            return 0;
        }

        public Task<int> BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, params LYParameter<TEntity, object>[] wmsParameters)
        {
            if (wmsParameters.Length > 0)
            {
                LolitaSetting<TEntity> lolitaSetting = null;
                foreach (var batchUpdateConditiong in wmsParameters)
                {
                    if (lolitaSetting == null)
                    {
                        lolitaSetting = GetAll().Where(predicate).SetField(batchUpdateConditiong.Property).WithValue(batchUpdateConditiong.Value);
                    }
                    else
                    {
                        lolitaSetting = lolitaSetting.SetField(batchUpdateConditiong.Property).WithValue(batchUpdateConditiong.Value);
                    }
                }

                return lolitaSetting.UpdateAsync();
            }
            return Task.Factory.StartNew(() => 0);
        }

        public IQueryable<TEntity> DynamicQuery(PagedResultRequestInput input)
        {
            var sourceData = GetAll();
            return sourceData.DynamicQuery(input);
        }
    }

    public class WMSRepositories<TEntity> : WMSRepositories<TEntity, int>, IWMSRepositories<TEntity>
       where TEntity : class, IEntity<int>, new()
    {
        public WMSRepositories(IDbContextProvider<WMSCloudDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
