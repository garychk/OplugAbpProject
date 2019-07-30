using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PODetail")]
    public partial class PODetail : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenLine { get; set; }

        public bool VoidLine { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PONUM { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POLine { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal UnitCost { get; set; }

        public decimal DocUnitCost { get; set; }

        public decimal OrderQty { get; set; }

        public decimal XOrderQty { get; set; }

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
        /// <summary>
        /// 指示接收此采购订单行项目时是否需要检查。如果相关的PartClass、Vendor、JobMtl或JobOper的“RcVinspectionReq”字段设置为“是”，也可以强制执行检查。
        /// </summary>
        public bool RcvInspectionReq { get; set; }

        public int VendorNum { get; set; }
        /// <summary>
        /// 跟踪用于在收到实际订单时减少发票的预付款的“余额”。此值通过“预付款”发票类型增加。当通过在APInvDTL中输入金额来创建收据发票时，它会减少。
        /// </summary>
        public decimal AdvancePayBal { get; set; }
        /// <summary>
        /// 跟踪用于在收到实际订单时减少发票的预付款的“余额”。此值通过“预付款”发票类型增加。当通过在APInvDTL中输入金额来创建收据发票时，它会减少。
        /// </summary>
        public decimal DocAdvancePayBal { get; set; }

        public bool Confirmed { get; set; }

        public bool DateChgReq { get; set; }

        public bool QtyChgReq { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNumChgReq { get; set; }
        /// <summary>
        /// 请求的挂起修订更改
        /// </summary>
        [Required]
        [StringLength(12)]
        public string RevisionNumChgReq { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ConfirmDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }
        /// <summary>
        /// Requested Price change.  SRM
        /// </summary>
        public decimal PrcChgReq { get; set; }

        [Required]
        [StringLength(8)]
        public string PurchCode { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public bool ContractActive { get; set; }

        public decimal ContractQty { get; set; }

        public decimal ContractUnitCost { get; set; }

        public decimal ContractDocUnitCost { get; set; }

        public decimal RptAdvancePayBal { get; set; }

        public decimal RptUnitCost { get; set; }

        [Required]
        [StringLength(6)]
        public string ContractQtyUOM { get; set; }

        public decimal RptContractUnitCost { get; set; }

        public decimal BaseQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseUOM { get; set; }
        /// <summary>
        /// 与此采购订单相关的订单号。仅用于按订单购买的订单。
        /// </summary>
        public int BTOOrderNum { get; set; }

        public int BTOOrderLine { get; set; }

        [Required]
        [StringLength(1)]
        public string VendorPartOpts { get; set; }

        [Required]
        [StringLength(1)]
        public string MfgPartOpts { get; set; }

        [Required]
        [StringLength(1)]
        public string SubPartOpts { get; set; }

        public int MfgNum { get; set; }

        [Required]
        [StringLength(50)]
        public string MfgPartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string SubPartNum { get; set; }

        [Required]
        [StringLength(1)]
        public string SubPartType { get; set; }

        public decimal ConfigUnitCost { get; set; }

        public decimal ConfigBaseUnitCost { get; set; }

        public bool ConvOverRide { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Direction { get; set; }

        [Required]
        [StringLength(50)]
        public string Per { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? ShipToSupplierDate { get; set; }

        public decimal Factor { get; set; }

        public decimal PricingQty { get; set; }

        public decimal PricingUnitPrice { get; set; }

        [Required]
        [StringLength(6)]
        public string UOM { get; set; }

        public int GroupSeq { get; set; }

        public decimal DocPricingUnitPrice { get; set; }

        public bool OverridePriceList { get; set; }

        [Required]
        [StringLength(10)]
        public string QtyOption { get; set; }

        [Required]
        public string OrigComment { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public decimal SelCurrPricingUnitPrice { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }

        public bool PCLinkRemoved { get; set; }

        [Required]
        [StringLength(10)]
        public string TaxCatID { get; set; }

        public bool NoTaxRecalc { get; set; }

        public decimal InUnitCost { get; set; }

        public decimal DocInUnitCost { get; set; }

        public decimal InAdvancePayBal { get; set; }

        public decimal DocInAdvancePayBal { get; set; }

        public decimal InContractUnitCost { get; set; }

        public decimal DocInContractUnitCost { get; set; }

        public decimal DocExtCost { get; set; }

        public decimal ExtCost { get; set; }

        public decimal DocMiscCost { get; set; }

        public decimal MiscCost { get; set; }
        public int TenantId { get; set; }
    }
}
