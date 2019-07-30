using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("POHeader")]
    public partial class POHeader : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenOrder { get; set; }

        public bool VoidOrder { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PONum { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [Required]
        [StringLength(15)]
        public string FOB { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Required]
        [StringLength(4)]
        public string TermsCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipCity { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipState { get; set; }

        [Required]
        [StringLength(10)]
        public string ShipZIP { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipCountry { get; set; }

        [Required]
        [StringLength(8)]
        public string BuyerID { get; set; }

        public bool FreightPP { get; set; }

        public int PrcConNum { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        public string CommentText { get; set; }

        public bool OrderHeld { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipToConName { get; set; }

        public bool ReadyToPrint { get; set; }

        [Required]
        [StringLength(2)]
        public string PrintAs { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public bool LockRate { get; set; }

        public int ShipCountryNum { get; set; }

        public bool LogChanges { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }

        [Required]
        [StringLength(75)]
        public string ApprovedBy { get; set; }

        public bool Approve { get; set; }

        [Required]
        [StringLength(2)]
        public string ApprovalStatus { get; set; }

        public decimal ApprovedAmount { get; set; }

        public bool PostToWeb { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PostDate { get; set; }

        [Required]
        [StringLength(30)]
        public string VendorRefNum { get; set; }

        public bool ConfirmReq { get; set; }

        public bool Confirmed { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }

        public int OrderNum { get; set; }
        /// <summary>
        /// 记录的法定编号。此编号是根据表LegalNumber中的设置参数创建的。
        /// </summary>
        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(50)]
        public string XRefPONum { get; set; }
        /// <summary>
        /// 合并采购订单标志。用于合并采购。
        /// </summary>
        public bool ConsolidatedPO { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public bool ContractOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractEndDate { get; set; }

        public bool PrintHeaderAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }
        /// <summary>
        /// 信用证ID
        /// </summary>
        [Required]
        [StringLength(20)]
        public string APLOCID { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }
        /// <summary>
        /// 用于BAM自动打印与此表关联的Crystal Report或Bartender标签的字段。
        /// </summary>
        public bool AutoPrintReady { get; set; }

        public bool ICPOLocked { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PromiseDate { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }
        /// <summary>
        /// 用于确定每次更新采购订单行时是否自动计算采购订单税的标志。
        /// </summary>
        public bool POTaxReadyToProcess { get; set; }
        /// <summary>
        /// 此采购订单的纳税义务
        /// </summary>
        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxPoint { get; set; }
        /// <summary>
        /// 用于计算税率的日期
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? TaxRateDate { get; set; }

        public decimal TotalTax { get; set; }

        public decimal DocTotalTax { get; set; }
        /// <summary>
        /// 以基础货币表示的总订单预扣税
        /// </summary>
        public decimal TotalWhTax { get; set; }

        public decimal DocTotalWhTax { get; set; }
        /// <summary>
        /// Total Order Self Assessed Taxes in base currency.
        /// </summary>
        public decimal TotalSATax { get; set; }
        /// <summary>
        /// 以凭证货币表示的总订单自评税。
        /// </summary>
        public decimal DocTotalSATax { get; set; }

        public bool InPrice { get; set; }
        /// <summary>
        /// 此标志确定是否为表头杂项费用创建了任何手动税，如果设置为true，则税务引擎将不会计算任何杂项费用税信息。
        /// </summary>
        public bool HdrTaxNoUpdt { get; set; }

        [Required]
        [StringLength(12)]
        public string TaxRateGrpCode { get; set; }
        /// <summary>
        /// 以基础货币表示的可抵扣税额总额。
        /// </summary>
        public decimal TotalDedTax { get; set; }

        public decimal DocTotalDedTax { get; set; }
        public decimal TotalCharges { get; set; }

        public decimal TotalMiscCharges { get; set; }

        public decimal TotalOrder { get; set; }

        public decimal DocTotalCharges { get; set; }
        /// <summary>
        /// 与此采购订单关联的所有杂项费用的总金额（凭证货币）。POMisc.DocMiscAmt的总和。
        /// </summary>
        public decimal DocTotalMisc { get; set; }
        /// <summary>
        /// 以凭证货币表示的采购订单总金额。POMisc.DocMiscAmt + PODetail.DocExtCost + POHeader.DocTotalTax.
        /// </summary>
        public decimal DocTotalOrder { get; set; }
        public int TenantId { get; set; }
    }
}
