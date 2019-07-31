using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("SugPoDtl")]
    public partial class SugPoDtl : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        public int SugNum { get; set; }

        [Required]
        [StringLength(2)]
        public string SugType { get; set; }

        [Required]
        [StringLength(8)]
        public string BuyerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal XRelQty { get; set; }
        /// <summary>
        /// 此值用于在供应商度量单位存在差异时转换数量，以及在库存中存储或在制造中使用的方式。示例以磅为单位购买，以张为单位存储。当此字段不为零时，采购订单条目会在更改我方U/M中的订单数量（XRelQty）或反之亦然时计算供应商订单数量（RelQty）。
        /// </summary>
        public decimal PurchasingFactor { get; set; }

        public decimal RelQty { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int JobSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(15)]
        public string FOB { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }
        /// <summary>
        /// Defaults from the Vendor.
        /// </summary>
        [Required]
        [StringLength(4)]
        public string TermsCode { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DocUnitPrice { get; set; }

        public bool Taxable { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(2)]
        public string CostPerCode { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(8)]
        public string VendorID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Buy { get; set; }

        public int PONUM { get; set; }

        public int POLine { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderByDate { get; set; }

        public int LeadTime { get; set; }

        public int ReqNum { get; set; }

        public int ReqLine { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool CreateRFQ { get; set; }

        public bool SourceRFQ { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public int GlbSugNum { get; set; }

        public bool GlbSuggestion { get; set; }
        /// <summary>
        /// 指示计算中如何使用系数。如果m（乘以），则系数乘以，如果d（除以），则系数除以。
        /// </summary>
        [Required]
        [StringLength(1)]
        public string PurchasingFactorDirection { get; set; }

        public decimal RptUnitPrice { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public bool DropShip { get; set; }

        public int MfgNum { get; set; }

        [Required]
        [StringLength(50)]
        public string MfgPartNum { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public int SoldToNum { get; set; }

        public int ShpConNum { get; set; }

        public int ShipToCustNum { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public bool PORelOpen { get; set; }

        [Required]
        [StringLength(2)]
        public string SugReason { get; set; }
        /// <summary>
        /// BC代码。有效值为“A”到“Z”。
        /// </summary>
        [Required]
        [StringLength(1)]
        public string ABCCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Direction { get; set; }

        [Required]
        [StringLength(50)]
        public string Per { get; set; }

        public bool ManualFactor { get; set; }

        public decimal Factor { get; set; }

        public decimal PricingQty { get; set; }

        public decimal PricingUnitPrice { get; set; }

        [Required]
        [StringLength(6)]
        public string UOM { get; set; }

        [Required]
        [StringLength(30)]
        public string UrgentPlanning { get; set; }

        public bool MaintainPricingUnits { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public bool Review { get; set; }
        /// <summary>
        /// 指示是否已覆盖供应商价目表，这将反过来阻止在考虑数量/价格折让时更新单价。
        /// </summary>
        public bool OverridePriceList { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }
        /// <summary>
        /// 此字段与公司、DemandHeadSeq、DemandDtlSeq和DemandScheduleSeq一起构成此SugPodtl链接到的DemandSchedule记录的唯一键。
        /// </summary>
        public int DemandContractNum { get; set; }
        /// <summary>
        /// 此字段与公司、DemandHeadSeq、DemandDtlSeq和DemandScheduleSeq一起构成此SugPodtl链接到的DemandSchedule记录的唯一键。
        /// </summary>
        public int DemandHeadSeq { get; set; }
        /// <summary>
        /// 此字段与公司、DemandHeadSeq、DemandDtlSeq和DemandScheduleSeq一起构成此SugPodtl链接到的DemandSchedule记录的唯一键。
        /// </summary>
        public int DemandDtlSeq { get; set; }
        /// <summary>
        /// 此字段与公司、DemandHeadSeq、DemandDtlSeq和DemandScheduleSeq一起构成此SugPodtl链接到的DemandSchedule记录的唯一键。
        /// </summary>
        public int DemandScheduleSeq { get; set; }
        public int TenantId { get; set; }
    }
}
