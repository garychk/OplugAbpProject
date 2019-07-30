using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("OrderDtl")]
    public partial class OrderDtl : Entity<Guid>, IMustHaveTenant
    {
        public bool VoidLine { get; set; }

        public bool OpenLine { get; set; }

        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderLine { get; set; }

        [Required]
        [StringLength(8)]
        public string LineType { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(10)]
        public string Reference { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(20)]
        public string POLine { get; set; }

        public bool Commissionable { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DocUnitPrice { get; set; }

        public decimal OrderQty { get; set; }

        public decimal Discount { get; set; }

        public decimal DocDiscount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }

        [Required]
        [StringLength(50)]
        public string XPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string XRevisionNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        [Required]
        public string OrderComment { get; set; }

        [Required]
        public string ShipComment { get; set; }

        [Required]
        public string InvoiceComment { get; set; }

        [Required]
        public string PickListComment { get; set; }

        [Required]
        [StringLength(10)]
        public string TaxCatID { get; set; }

        public decimal AdvanceBillBal { get; set; }

        public decimal DocAdvanceBillBal { get; set; }

        public int QuoteNum { get; set; }

        public int QuoteLine { get; set; }

        public bool TMBilling { get; set; }

        [Required]
        [StringLength(3)]
        public string OrigWhyNoTax { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        public int CustNum { get; set; }

        public bool Rework { get; set; }

        public int RMANum { get; set; }

        public int RMALine { get; set; }

        [Required]
        [StringLength(25)]
        public string ProjectID { get; set; }

        public int ContractNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ContractCode { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        public bool Warranty { get; set; }

        [Required]
        [StringLength(8)]
        public string WarrantyCode { get; set; }

        public int MaterialDuration { get; set; }

        public int LaborDuration { get; set; }

        public int MiscDuration { get; set; }

        [Required]
        [StringLength(8)]
        public string MaterialMod { get; set; }

        [Required]
        [StringLength(8)]
        public string LaborMod { get; set; }

        [Required]
        public string WarrantyComment { get; set; }

        public bool Onsite { get; set; }

        public bool MatCovered { get; set; }

        public bool LabCovered { get; set; }

        public bool MiscCovered { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        public decimal SellingFactor { get; set; }

        public decimal SellingQuantity { get; set; }

        [Required]
        [StringLength(4)]
        public string SalesCatID { get; set; }

        public bool ShipLineComplete { get; set; }

        public decimal CumeQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CumeDate { get; set; }

        [Required]
        [StringLength(8)]
        public string MktgCampaignID { get; set; }

        public int MktgEvntSeq { get; set; }

        public bool LockQty { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public int ICPOLine { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastConfigDate { get; set; }

        public int LastConfigTime { get; set; }

        [Required]
        [StringLength(75)]
        public string LastConfigUserID { get; set; }

        public decimal ConfigUnitPrice { get; set; }

        public decimal ConfigBaseUnitPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string PriceListCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BreakListCode { get; set; }

        public decimal PricingQty { get; set; }

        public bool LockPrice { get; set; }

        public decimal ListPrice { get; set; }

        public decimal DocListPrice { get; set; }

        public decimal OrdBasedPrice { get; set; }

        public decimal DocOrdBasedPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string PriceGroupCode { get; set; }

        public bool OverridePriceList { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        public decimal PricingValue { get; set; }

        public decimal DisplaySeq { get; set; }

        public int KitParentLine { get; set; }

        public bool KitAllowUpdate { get; set; }

        public bool KitShipComplete { get; set; }

        public bool KitBackFlush { get; set; }

        public bool KitPrintCompsPS { get; set; }

        public bool KitPrintCompsInv { get; set; }

        [Required]
        [StringLength(2)]
        public string KitPricing { get; set; }

        public decimal KitQtyPer { get; set; }

        [Required]
        [StringLength(1)]
        public string SellingFactorDirection { get; set; }

        public decimal RepRate { get; set; }

        public int RepSplit { get; set; }

        public int DemandContractLine { get; set; }

        public bool CreateNewJob { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoNotShipBeforeDate { get; set; }

        public bool GetDtls { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoNotShipAfterDate { get; set; }

        public bool SchedJob { get; set; }

        public bool RelJob { get; set; }

        public bool EnableCreateNewJob { get; set; }

        public bool EnableGetDtls { get; set; }

        public bool EnableSchedJob { get; set; }

        public bool EnableRelJob { get; set; }

        [Required]
        [StringLength(8)]
        public string CounterSaleWarehouse { get; set; }

        [Required]
        [StringLength(10)]
        public string CounterSaleBinNum { get; set; }

        [Required]
        [StringLength(30)]
        public string CounterSaleLotNum { get; set; }

        [Required]
        [StringLength(6)]
        public string CounterSaleDimCode { get; set; }

        public bool DemandDtlRejected { get; set; }

        [Required]
        [StringLength(1)]
        public string KitFlag { get; set; }

        public bool KitsLoaded { get; set; }

        public int DemandContractNum { get; set; }

        public int DemandHeadSeq { get; set; }

        public int DemandDtlSeq { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool ReverseCharge { get; set; }

        public int TotalReleases { get; set; }

        public decimal RptUnitPrice { get; set; }

        public decimal RptDiscount { get; set; }

        public decimal RptAdvanceBillBal { get; set; }

        public decimal RptListPrice { get; set; }

        public decimal RptOrdBasedPrice { get; set; }

        public decimal ExtPriceDtl { get; set; }

        public decimal DocExtPriceDtl { get; set; }

        public decimal RptExtPriceDtl { get; set; }

        [Required]
        [StringLength(20)]
        public string LineStatus { get; set; }

        public decimal InUnitPrice { get; set; }

        public decimal DocInUnitPrice { get; set; }

        public decimal InDiscount { get; set; }

        public decimal DocInDiscount { get; set; }

        public decimal InListPrice { get; set; }

        public decimal DocInListPrice { get; set; }

        public decimal InOrdBasedPrice { get; set; }

        public decimal DocInOrdBasedPrice { get; set; }

        public decimal RptInUnitPrice { get; set; }

        public decimal RptInDiscount { get; set; }

        public decimal RptInListPrice { get; set; }

        public decimal RptInOrdBasedPrice { get; set; }

        public decimal InExtPriceDtl { get; set; }

        public decimal DocInExtPriceDtl { get; set; }

        public decimal RptInExtPriceDtl { get; set; }

        public decimal OldOurOpenQty { get; set; }

        public decimal OldSellingOpenQty { get; set; }

        public decimal OldOpenValue { get; set; }

        [Required]
        [StringLength(8)]
        public string OldProdCode { get; set; }

        public decimal PrevSellQty { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevPartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevXPartNum { get; set; }

        public int KitCompOrigSeq { get; set; }

        [Required]
        [StringLength(50)]
        public string KitCompOrigPart { get; set; }

        public bool SmartStringProcessed { get; set; }

        [Required]
        public string SmartString { get; set; }

        public int RenewalNbr { get; set; }

        [Required]
        [StringLength(10)]
        public string DiscBreakListCode { get; set; }

        public decimal DiscListPrice { get; set; }

        public bool LockDisc { get; set; }

        public bool OverrideDiscPriceList { get; set; }

        public int GroupSeq { get; set; }

        [Required]
        [StringLength(50)]
        public string ECCOrderNum { get; set; }

        public int ECCOrderLine { get; set; }

        public bool DupOnJobCrt { get; set; }

        public decimal UndersPct { get; set; }

        public decimal Overs { get; set; }

        public decimal Unders { get; set; }

        public decimal OversUnitPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanUserID { get; set; }

        [Required]
        [StringLength(256)]
        public string PlanGUID { get; set; }

        [Required]
        [StringLength(50)]
        public string MOMsourceType { get; set; }

        [Required]
        [StringLength(50)]
        public string MOMsourceEst { get; set; }

        [Required]
        [StringLength(50)]
        public string DefaultOversPricing { get; set; }

        [Required]
        [StringLength(8)]
        public string ECCPlant { get; set; }

        [Required]
        [StringLength(10)]
        public string ECCQuoteNum { get; set; }

        public int ECCQuoteLine { get; set; }

        [Required]
        [StringLength(3)]
        public string MfgJobType { get; set; }

        [Required]
        public string ProFormaInvComment { get; set; }

        public bool CreateJob { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public decimal DocInAdvanceBillBal { get; set; }

        public decimal InAdvanceBillBal { get; set; }

        public decimal RptInAdvanceBillBal { get; set; }

        public bool PCLinkRemoved { get; set; }
        public int TenantId { get; set; }
    }
}
