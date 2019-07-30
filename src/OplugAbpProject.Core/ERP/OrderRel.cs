using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("OrderRel")]
    public partial class OrderRel : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderLine { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string LineType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDate { get; set; }

        public decimal OurReqQty { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }
        /// <summary>
        /// 用于此发货项的ShipVia ID，这可以为空，或者必须在ShipVia主文件中有效。使用OrderHead.ShipViaCode作为默认值。
        /// </summary>
        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        public bool OpenRelease { get; set; }

        public bool FirmRelease { get; set; }

        public bool Make { get; set; }

        public decimal OurJobQty { get; set; }

        public decimal OurJobShippedQty { get; set; }

        public bool VoidRelease { get; set; }

        public decimal OurStockQty { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        public decimal OurStockShippedQty { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(3)]
        public string TaxExempt { get; set; }

        public int ShpConNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Reference { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public decimal SellingReqQty { get; set; }

        public decimal SellingJobQty { get; set; }

        public decimal SellingJobShippedQty { get; set; }

        public decimal SellingStockQty { get; set; }

        public decimal SellingStockShippedQty { get; set; }
        /// <summary>
        /// Indicates if the release is selected to be submitted to the picking queue. When submitted for picking a record is written to the MtlQueue table and then SelectForPicking is reset to NO. 
        /// </summary>
        public bool SelectForPicking { get; set; }
        /// <summary>
        /// 用于发布的装运“临时”仓库。系统默认发货区域的默认值（Site.DefShippingWhse）。这在销售分配计划中是可维护的。
        /// </summary>
        [Required]
        [StringLength(8)]
        public string StagingWarehouseCode { get; set; }
        /// <summary>
        /// 发布的装运“暂存”箱。系统默认发货区域的默认值（Site.DefShippingBin）。这在销售分配计划中是可维护的。
        /// </summary>
        [Required]
        [StringLength(10)]
        public string StagingBinNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PickError { get; set; }
        /// <summary>
        /// 上次EDI更新的数量。
        /// </summary>
        public decimal CumeQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CumeDate { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public int ICPOLine { get; set; }

        public int ICPORelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(30)]
        public string ScheduleNumber { get; set; }

        [Required]
        [StringLength(14)]
        public string MarkForNum { get; set; }

        [Required]
        [StringLength(50)]
        public string DropShipName { get; set; }

        [Required]
        [StringLength(30)]
        public string RAN { get; set; }
        /// <summary>
        /// 需求参考。用于提供信息并帮助将需求计划与现有OrderRel记录匹配。由EDI提供。
        /// </summary>
        [Required]
        [StringLength(30)]
        public string DemandReference { get; set; }
        /// <summary>
        /// 指示创建/更新此订单发布的需求计划是否已被拒绝。
        /// </summary>
        public bool DemandSchedRejected { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatePickTicketPrinted { get; set; }

        public bool ResDelivery { get; set; }
        /// <summary>
        /// Is a Saturday delivery acceptable
        /// </summary>
        public bool SatDelivery { get; set; }
        /// <summary>
        /// Is a Saturday pickup available
        /// </summary>
        public bool SatPickup { get; set; }
        /// <summary>
        /// 需要口头确认
        /// </summary>
        public bool VerbalConf { get; set; }
        /// <summary>
        /// 危险品或危险品交付
        /// </summary>
        public bool Hazmat { get; set; }
        /// <summary>
        /// 仅文件交付
        /// </summary>
        public bool DocOnly { get; set; }
        /// <summary>
        /// 交货参考说明
        /// </summary>
        [Required]
        [StringLength(500)]
        public string RefNotes { get; set; }
        /// <summary>
        /// 将手续费应用于装运
        /// </summary>
        public bool ApplyChrg { get; set; }

        public decimal ChrgAmount { get; set; }
        /// <summary>
        /// 优先货到付款
        /// </summary>
        public bool COD { get; set; }
        /// <summary>
        /// 货到付款时需要运费
        /// </summary>
        public bool CODFreight { get; set; }
        /// <summary>
        /// 货到付款时需要银行本票或汇票。
        /// </summary>
        public bool CODCheck { get; set; }
        /// <summary>
        /// 银行本票或汇票上的应付金额
        /// </summary>
        public decimal CODAmount { get; set; }

        [Required]
        [StringLength(8)]
        public string GroundType { get; set; }
        /// <summary>
        /// 指示是否发送电子邮件传递通知
        /// </summary>
        public bool NotifyFlag { get; set; }
        /// <summary>
        /// 通知电子邮件
        /// </summary>
        [Required]
        [StringLength(500)]
        public string NotifyEMail { get; set; }
        /// <summary>
        /// 指示在交货时声明保险价值的标志
        /// </summary>
        public bool DeclaredIns { get; set; }
        /// <summary>
        /// 申报保险金额
        /// </summary>
        public decimal DeclaredAmt { get; set; }

        public bool ServSatDelivery { get; set; }

        public bool ServSatPickup { get; set; }

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

        public bool ServPOD { get; set; }

        public bool ServAOD { get; set; }

        public bool ServHomeDel { get; set; }

        [Required]
        [StringLength(8)]
        public string DeliveryType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServDeliveryDate { get; set; }

        [Required]
        [StringLength(20)]
        public string ServPhone { get; set; }

        [Required]
        [StringLength(100)]
        public string ServInstruct { get; set; }

        public bool ServRelease { get; set; }

        [Required]
        [StringLength(50)]
        public string ServAuthNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef { get; set; }

        public bool OverrideCarrier { get; set; }

        public bool OverrideService { get; set; }

        [Required]
        [StringLength(30)]
        public string DockingStation { get; set; }

        [Required]
        [StringLength(30)]
        public string Location { get; set; }

        [Required]
        [StringLength(30)]
        public string TransportID { get; set; }

        public int ShipbyTime { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool TaxConnectCalc { get; set; }

        public bool GetDfltTaxIds { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }
        /// <summary>
        /// 指示应使用为此版本定义的一次性收货信息
        /// </summary>
        public bool UseOTS { get; set; }

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

        [Required]
        [StringLength(50)]
        public string SubShipTo { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipRouting { get; set; }

        public bool BuyToOrder { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public bool DropShip { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        public bool OpenOrder { get; set; }

        [Required]
        [StringLength(2)]
        public string OTSSaveAs { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSSaveCustID { get; set; }

        public bool OTSCustSaved { get; set; }

        public int ShipToCustNum { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        [Required]
        [StringLength(20)]
        public string RelStatus { get; set; }
        /// <summary>
        /// 显示项目不符合的原因。
        /// </summary>
        [Required]
        public string ComplianceMsg { get; set; }

        public decimal PrevSellQty { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevPartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevXPartNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PrevNeedByDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PrevReqDate { get; set; }

        [Required]
        [StringLength(14)]
        public string PrevShipToNum { get; set; }
        /// <summary>
        /// 标记客户编号。这与ShipToNum标记一起为给定的ShipTo提供外键字段。
        /// </summary>
        public int MFCustNum { get; set; }
        /// <summary>
        /// 指示应使用为此记录定义的信息的一次性标记。
        /// </summary>
        public bool UseOTMF { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTMFZIP { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTMFFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTMFPhoneNum { get; set; }

        public int OTMFCountryNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ECCPlant { get; set; }

        [Required]
        [StringLength(20)]
        public string WIOrderLine { get; set; }

        [Required]
        [StringLength(20)]
        public string WIOrder { get; set; }

        [Required]
        [StringLength(256)]
        public string WebSKU { get; set; }

        public bool ShipOvers { get; set; }

        public decimal WIItemPrice { get; set; }

        public decimal WIItemShipCost { get; set; }

        [Required]
        [StringLength(10)]
        public string EntityUseCode { get; set; }

        [Required]
        [StringLength(12)]
        public string PhaseID { get; set; }

        [Required]
        [StringLength(14)]
        public string OTSShipToNum { get; set; }

        public bool WasRecInvoiced { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public bool ReadyToFulfill { get; set; }
        public int TenantId { get; set; }
    }
}
