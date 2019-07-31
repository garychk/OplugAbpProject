using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("Warehse")]
    public partial class Warehse : Entity<int>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string Zip { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string GLDivision { get; set; }

        public int CountryNum { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int CCSelectMethod { get; set; }
        /// <summary>
        /// 指示是否在周期计数选择中排除非活动物料。这可以在每月选择时覆盖。
        /// </summary>
        public bool ExcludeInactive { get; set; }
        /// <summary>
        /// 指示是否排除在循环计数选择中处于保留状态的物料。这可以在每月选择时覆盖。
        /// </summary>
        public bool ExcludeOnHold { get; set; }
        /// <summary>
        /// 指示在循环计数选择中是否排除QOH为零的零件。这可以在每月选择时覆盖。
        /// </summary>
        public bool ExcludeZeroQOH { get; set; }

        public bool ExcludeNegQOH { get; set; }

        public decimal LastSheetNum { get; set; }

        public decimal LastTagNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ManagerName { get; set; }

        [Required]
        [StringLength(8)]
        public string DefRcvWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string DefRcvBin { get; set; }

        [Required]
        [StringLength(8)]
        public string DefShipWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string DefShipBin { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNum { get; set; }

        [Required]
        [StringLength(8)]
        public string SalesRepCode { get; set; }

        public bool EnforcePkgControlRules { get; set; }
        /// <summary>
        /// 指示是否允许在仓库内生成父PCID。
        /// </summary>
        public bool AllowBuildParent { get; set; }

        public bool IsHoldWarehouse { get; set; }

        [Required]
        [StringLength(12)]
        public string WarehouseType { get; set; }

        public bool WarehouseTypeDefault { get; set; }
        public int TenantId { get; set; }
    }
}
