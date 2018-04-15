using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Abp.Domain.Entities;
using LY.WMSCloud.Authorization.Users;
using LY.WMSCloud.Entities;

namespace LY.WMSCloud.Authorization.Roles
{
    public class Role : AbpRole<User>, IPassivable
    {
        public const int MaxDescriptionLength = 5000;

        public Role()
        {
            IsActive = true;
        }

        public Role(int? tenantId, string displayName)
            : base(tenantId, displayName)
        {
            IsActive = true;
        }

        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName)
        {
            IsActive = true;
        }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public int? OrgId { get; set; }

        public Org Org { get; set; }

        [StringLength(2000)]
        public string Remark { get; set; }

        public int Grade { get; set; }

        public bool IsActive { get; set; }

    }
}
