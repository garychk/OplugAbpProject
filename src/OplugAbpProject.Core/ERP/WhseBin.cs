using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("WhseBin")]
    public partial class WhseBin : Entity<int>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        /// <summary>
        /// 指示仓库仓位的数量是否应计算数量。
        /// </summary>
        public bool NonNettable { get; set; }

        [Required]
        [StringLength(8)]
        public string SizeID { get; set; }

        [Required]
        [StringLength(8)]
        public string ZoneID { get; set; }

        public int BinSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        public int CustNum { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(8)]
        public string Aisle { get; set; }

        [Required]
        [StringLength(8)]
        public string Face { get; set; }

        public int Elevation { get; set; }
        /// <summary>
        /// 最大容量
        /// </summary>
        public decimal MaxFill { get; set; }
        /// <summary>
        /// 可存放百分比
        /// </summary>
        public decimal PctFillable { get; set; }

        public bool InActive { get; set; }
        /// <summary>
        /// 指示库位是否不在固定位置。
        /// </summary>
        public bool Portable { get; set; }

        public bool Replenishable { get; set; }
        public int TenantId { get; set; }
    }
}
