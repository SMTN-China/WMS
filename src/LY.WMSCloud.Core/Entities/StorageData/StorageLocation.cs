using Abp.Domain.Entities;
using LY.WMSCloud.Entities.ProduceData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LY.WMSCloud.Entities.StorageData
{
    public class StorageLocation : EntitieTenantBase
    {
        /// <summary>
        /// 料架号
        /// </summary>
        [StringLength(30)]
        public string Code { get; set; }
        /// <summary>
        /// 料架名称
        /// </summary>
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(500)]
        public string Remark { get; set; }
        /// <summary>
        /// 料卷号
        /// </summary>
        [StringLength(100)]
        public string ReelId { get; set; }

        /// <summary>
        /// 主板Id
        /// </summary>
        public int MainBoardId { get; set; }
        /// <summary>
        /// 库位Id
        /// </summary>
        public int PositionId { get; set; }
        /// <summary>
        /// 货架类型
        /// </summary>
        [StringLength(36)]
        public string StorageLocationTypeId { get; set; }
        public StorageLocationType StorageLocationType { get; set; }

        /// <summary>
        /// 区域Id
        /// </summary>
        [StringLength(36)]
        public string StorageAreaId { get; set; }
        public StorageArea StorageArea { get; set; }
        /// <summary>
        /// 仓库Id
        /// </summary>
        [StringLength(36)]
        public string StorageId { get; set; }

        public Storage Storage { get; set; }

        /// <summary>
        /// 灯状态
        /// </summary>
        public BrightState BrightState { get; set; }

        /// <summary>
        /// 灯颜色
        /// </summary>
        public BrightColor BrightColor { get; set; }
    }

    public enum BrightColor
    {
        /// <summary>
        /// 白
        /// </summary>
        White = 0,
        /// <summary>
        /// 绿
        /// </summary>
        Green,
        /// <summary>
        /// 蓝
        /// </summary>
        Blue,
        /// <summary>
        /// 红
        /// </summary>
        Red,
        /// <summary>
        /// 橙
        /// </summary>
        Orange,
        /// <summary>
        /// 黄
        /// </summary>
        Yellow,
        /// <summary>
        /// 紫
        /// </summary>
        Purple
    }

    public enum BrightState
    {
        /// <summary>
        /// 关闭
        /// </summary>
        Off = 0,
        /// <summary>
        /// 亮灯
        /// </summary>
        On,
        /// <summary>
        /// 闪烁
        /// </summary>
        Flicker
    }
}
