using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PORel")]
    public partial class PORel : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenRelease { get; set; }

        public bool VoidRelease { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal XRelQty { get; set; }
        /// <summary>
        /// 此值用于在供应商度量单位存在差异时转换数量，以及在库存中存储或在制造中使用的方式。示例以磅为单位购买，以张为单位存储。当此字段不为零时，采购订单条目会在U/M中的订单数量（XRelQty）发生更改或相反时计算供应商订单数量（RelQty）。
        /// </summary>
        public decimal PurchasingFactor { get; set; }

        public decimal RelQty { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        public decimal ReceivedQty { get; set; }

        public bool ExpOverride { get; set; }

        public int ReqNum { get; set; }

        public int ReqLine { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PromiseDt { get; set; }

        [Required]
        [StringLength(25)]
        public string ProjectID { get; set; }

        public bool Confirmed { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqChgDate { get; set; }

        public decimal ReqChgQty { get; set; }

        [Required]
        [StringLength(8)]
        public string LockRel { get; set; }

        [Required]
        [StringLength(65)]
        public string RefDisplayAccount { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }
        /// <summary>
        /// 总账参考代码说明
        /// </summary>
        [Required]
        [StringLength(30)]
        public string RefCodeDesc { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        public decimal ShippedQty { get; set; }

        [Required]
        [StringLength(7)]
        public string TranType { get; set; }
        /// <summary>
        /// 全球公司标识符。用于合并采购。
        /// </summary>
        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }
        /// <summary>
        /// 全局站点标识符。与创建用于将合并采购公司与本地公司中的站点关联的外部站点记录相关。用于合并采购。
        /// </summary>
        [Required]
        [StringLength(8)]
        public string GlbPlant { get; set; }
        /// <summary>
        /// 全局仓库标识符。与创建用于将合并采购公司关联到本地公司中仓库的外部仓库记录相关。用于合并采购。
        /// </summary>
        [Required]
        [StringLength(8)]
        public string GlbWarehouse { get; set; }
        /// <summary>
        /// 当本地公司收到此PoRel时，如果设置了此标志，则创建JobMtl。用于合并采购。
        /// </summary>
        public bool GlbCreateJobMtl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShippedDate { get; set; }

        public int ContainerID { get; set; }

        /// <summary>
        /// 指示计算中如何使用系数。如果m（乘以），则系数乘以，如果d（除以），则系数除以。
        /// </summary>
        [Required]
        [StringLength(1)]
        public string PurchasingFactorDirection { get; set; }
        /// <summary>
        /// 此字段保留到期日期的前一个值。
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PreviousDueDate { get; set; }

        public decimal BaseQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseUOM { get; set; }
        /// <summary>
        /// 与此采购订单相关的订单号。仅用于按订单购买的订单。
        /// </summary>
        public int BTOOrderNum { get; set; }
        /// <summary>
        /// 与此采购订单相关的订单行。仅用于按订单购买的订单。
        /// </summary>
        public int BTOOrderLine { get; set; }
        /// <summary>
        /// 与此采购订单相关的订单收货行。仅用于按订单购买的订单。
        /// </summary>
        public int BTOOrderRelNum { get; set; }

        public bool DropShip { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public int SoldToNum { get; set; }
        /// <summary>
        /// 此项仅针对SMI类型的POS进行更新。它将指示在SMI bin中接收了多少项。
        /// </summary>
        public decimal SMIRcvdQty { get; set; }

        public int ShpConNum { get; set; }

        public int ShipToCustNum { get; set; }

        public int MangCustNum { get; set; }

        public bool UseOTS { get; set; }

        /// <summary>
        /// 一次性收货方名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string OTSName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSZIP { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSResaleID { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }
        /// <summary>
        /// 显示项目不符合的原因。
        /// </summary>
        [Required]
        public string ComplianceMsg { get; set; }

        public bool PORelOpen { get; set; }

        public bool Mapping { get; set; }

        [Required]
        [StringLength(12)]
        public string PhaseID { get; set; }
        /// <summary>
        /// Project Phase ID
        /// </summary>
        [Required]
        [StringLength(12)]
        public string WBSPhaseID { get; set; }

        public bool IsMultiRel { get; set; }

        public decimal SMIRemQty { get; set; }

        public bool LockQty { get; set; }

        public bool LockDate { get; set; }

        public bool DueDateChanged { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        public decimal ArrivedQty { get; set; }

        public decimal InvoicedQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        public bool LockNeedByDate { get; set; }

        public decimal InspectionQty { get; set; }

        public decimal FailedQty { get; set; }

        public decimal PassedQty { get; set; }

        public bool ProjProcessed { get; set; }
        /// <summary>
        /// “其他”的采购订单行类型没有指定的仓库/仓位，此字段提供的是指定此交货的目的地/目的地的方法。
        /// </summary>
        [Required]
        [StringLength(150)]
        public string DeliverTo { get; set; }

        public bool Taxable { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxExempt { get; set; }
        /// <summary>
        /// 此标志确定是否为行杂项费用创建了任何手动税，如果设置为true，则税务引擎将不会计算任何杂项费用税信息。
        /// </summary>
        public bool NoTaxRecalc { get; set; }
        public int TenantId { get; set; }
    }
}
