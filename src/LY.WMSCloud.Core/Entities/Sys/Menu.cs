using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LY.WMSCloud.Entities
{
    [Table("SysMenu")]
    public class Menu : EntitieCommonBase<int>
    {
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Translate { get; set; }

        public bool Group { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        [StringLength(255)]
        public string ExternalLink { get; set; }

        [StringLength(10)]
        public string Target { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        public int Index { get; set; }

        public int? ParentId { get; set; }

        public Menu Parent { get; set; }

        public string Acl { get; set; }

        public ICollection<Menu> Children { get; set; }

    }
}
