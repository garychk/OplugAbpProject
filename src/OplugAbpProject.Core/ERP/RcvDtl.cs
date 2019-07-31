using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RcvDtl")]
    public partial class RcvDtl : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorNum { get; set; }

        [StringLength(4)]
        public string PurPoint { get; set; }

        [StringLength(20)]
        public string PackSlip { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackLine { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        public decimal OurQty { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal OurUnitCost { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Required]
        [StringLength(30)]
        public string TranReference { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public decimal VendorQty { get; set; }

        public decimal VendorUnitCost { get; set; }

        [Required]
        [StringLength(2)]
        public string ReceiptType { get; set; }

        [Required]
        [StringLength(7)]
        public string ReceivedTo { get; set; }

        public bool ReceivedComplete { get; set; }

        public bool IssuedComplete { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }
        /// <summary>
        /// 指示每个数量的成本核算。这是在收据输入时从PoDetail.CostPercode复制的。应付发票分录在为收据创建发票行项目时使用。数值为“e”=每一个，“c”=每百个，“m”=每千个。
        /// </summary>
        [Required]
        [StringLength(2)]
        public string CostPerCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        public int NumLabels { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM { get; set; }

        public decimal DimConvFactor { get; set; }
        /// <summary>
        /// 指示此收据是否将分类为需要检查。如果相关供应商、零件类、Podetail、JobMtl、JobOper的RcVinspectionReq字段为“是”，则设置为“是”。
        /// </summary>
        public bool InspectionReq { get; set; }
        /// <summary>
        /// 指示收据是否等待检查。如果InspectionReq=yes，则设置为yes。收货检查后设置为否。
        /// </summary>
        public bool InspectionPending { get; set; }

        [Required]
        [StringLength(8)]
        public string InspectorID { get; set; }

        [Required]
        [StringLength(75)]
        public string InspectedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InspectedDate { get; set; }

        public int InspectedTime { get; set; }

        public decimal PassedQty { get; set; }

        public decimal FailedQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ReasonCode { get; set; }
        /// <summary>
        /// 收货有差异时，收货记录上的采购价格差异总金额。仅在收货处于检查状态时设置（不移动到DMR、作业或库存）。
        /// </summary>
        public decimal TotCostVariance { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }
        /// <summary>
        /// 说明交易是否是一种不一致的交易类型。
        /// </summary>
        public bool NonConformnce { get; set; }
        /// <summary>
        /// The material burden rate for this part. 
        /// </summary>
        public decimal MtlBurRate { get; set; }
        /// <summary>
        /// Mtl Bur Unit cost base on our unit of measure. The mtl burden rate defaults from the Part file.
        /// </summary>
        public decimal OurMtlBurUnitCost { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(8)]
        public string PurchCode { get; set; }

        public bool LCFlag { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public int GlbVendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string GlbPurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string GlbPackSlip { get; set; }

        public int GlbPackLine { get; set; }

        public decimal DocUnitCost { get; set; }

        public int ContainerID { get; set; }

        public decimal Volume { get; set; }

        public decimal RptUnitCost { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }
        /// <summary>
        /// Country Number of the Origin Country (defaults from Part Country of Origin).
        /// </summary>
        public int OrigCountryNum { get; set; }
        /// <summary>
        /// 上浮百分比，用于在给定间接成本的基础上计算额外的到岸成本金额
        /// </summary>
        public decimal UpliftPercent { get; set; }
        /// <summary>
        /// 此收单行的到岸成本的税额部分。
        /// </summary>
        public decimal LCDutyAmt { get; set; }
        /// <summary>
        /// 此收单行的到岸成本的间接成本部分。
        /// </summary>
        public decimal LCIndCost { get; set; }
        /// <summary>
        /// 这是默认的采购订单行值（包括折扣，不包括增值税/销项税），但可以由用户覆盖。它是一个系统选项，允许用户手动更新此基本事务值。
        /// </summary>
        public decimal POTransValue { get; set; }
        /// <summary>
        /// 这是采购订单基本交易价值加上标记为包含为交易价值成本的所有间接成本。
        /// </summary>
        public decimal ExtTransValue { get; set; }

        public bool Received { get; set; }
        /// <summary>
        /// 协调系统（HS）货物分类代码。
        /// </summary>
        [Required]
        [StringLength(12)]
        public string CommodityCode { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }

        public bool AutoReceipt { get; set; }

        [Required]
        [StringLength(6)]
        public string VolumeUOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivedDate { get; set; }
        /// <summary>
        /// 这是基于行关税作为因素的特定关税金额的按比例分配部分。已支付的 LandedCost 总额是 LCIndCost,LCDutyAmt, LCUpliftIndCost 和 LCSpecLineDutyAmt 之和。
        /// </summary>
        public decimal LCSpecLineDutyAmt { get; set; }
        /// <summary>
        /// 应用于此收单行的总到岸成本额。这是将确定收据交易的MtlBuUnitCost的实际成本。
        /// </summary>
        public decimal AppliedRcptLCAmt { get; set; }
        /// <summary>
        /// 收货行的总提升间接成本额。已支付的 LandedCost 总额是 LCIndCost,LCDutyAmt, LCUpliftIndCost 和 LCSpecLineDutyAmt 之和。
        /// </summary>
        public decimal LCUpliftIndCost { get; set; }
        /// <summary>
        /// 此收货明细的已支付的到岸成本总额。此金额包括每个收货行的关税和间接成本。已支付的LCAmt总额是LCindcost、LCdutyamt、LCupliftindtcost和LCspecLinedDutyamt的总和
        /// </summary>
        public decimal LCAmt { get; set; }
        /// <summary>
        /// 此字段保留已应用的到岸成本差异金额。
        /// </summary>
        public decimal AppliedLCVariance { get; set; }
        /// <summary>
        /// 到岸成本是根据我们的计量单位计算的MTL-BUR单位成本。在支付到岸成本并将其应用到收货行时，此字段的值将复制到OurMtlBurUnitCost 。
        /// </summary>
        public decimal LCMtlBurUnitCost { get; set; }
        /// <summary>
        /// PO currency value of this field
        /// </summary>
        public decimal DocVendorUnitCost { get; set; }

        public decimal RptVendorUnitCost { get; set; }

        public bool NotCompliant { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public int MangCustNum { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }
        /// <summary>
        /// 此Rcvdtl与此内部公司发货的ShipHead.PackNum之间的关系。
        /// </summary>
        public int ICPackNum { get; set; }

        [Required]
        [StringLength(20)]
        public string ShipRcv { get; set; }

        [Required]
        [StringLength(30)]
        public string ImportNum { get; set; }

        public int ImportedFrom { get; set; }

        [Required]
        [StringLength(40)]
        public string ImportedFromDesc { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Required]
        [StringLength(10)]
        public string QtyOption { get; set; }
        /// <summary>
        /// When True, the Supplier Quantity field is entered directly instead of being calculated from Our Quantity with a UOM conversion
        /// </summary>
        public bool ConvOverride { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }
        /// <summary>
        /// 用于标识特定交易的SMI收货期间消耗的交易内容。
        /// </summary>
        public int SMITransNum { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }

        public bool Delivered { get; set; }

        [Required]
        [StringLength(500)]
        public string DeliveredComments { get; set; }

        public decimal InOurCost { get; set; }

        public decimal DocInUnitCost { get; set; }

        public decimal RptInUnitCost { get; set; }

        public decimal InVendorUnitCost { get; set; }

        public decimal DocInVendorUnitCost { get; set; }

        public decimal RptInVendorUnitCost { get; set; }

        public decimal SupplierUnInvcReceiptQty { get; set; }

        public decimal OurUnInvcReceiptQty { get; set; }
        public int TenantId { get; set; }
    }
}
