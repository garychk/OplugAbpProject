using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("Part")]
    public partial class Part : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string SearchWord { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(2)]
        public string TypeCode { get; set; }

        public bool NonStock { get; set; }
        /// <summary>
        /// This value is used to convert quantity when there is a difference in the vendors unit of measure and how it is stocked in inventory. Example is purchased in pounds, stocked in sheets. Formula: Issue Qty * Conversion Factor = Purchased Qty.
        /// </summary>
        public decimal PurchasingFactor { get; set; }

        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Indicates the pricing per quantity for this part. It can be "E" = per each, "C" = per hundred,  "M" = per thousand. Maintainable only via Part Maintenance. The initial default is "E". Used as default PricePerCode in order entry and invoice entry. 
        /// </summary>
        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }
        /// <summary>
        /// Base Internal Unit Selling Price for the Item.  Maintainable only via Part Master Maintenance program.  If zero, then the external unit price (Part.UnitPrice) is used.
        /// </summary>
        public decimal InternalUnitPrice { get; set; }
        /// <summary>
        /// Indicates the internal pricing per quantity for this part. It can be "E" = per each, "C" = per hundred,  "M" = per thousand.  Maintainable only via Part Maintenance.  The initial default is "E".
        /// </summary>
        [Required]
        [StringLength(2)]
        public string InternalPricePerCode { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }
        /// <summary>
        /// Used to enter comments for manufacturing when this part is referenced on a job. These are copied to JobHead.Comment, JobAsmbl.Comment,JobMtl.MfgComment depending on the point of reference. Commens are printed on the routing report.  
        /// </summary>
        [Required]
        public string MfgComment { get; set; }
        /// <summary>
        /// Part Comments that will be used as a default for purchasing. These will be copied into the JobMtl.PurComment which then will be used to pass along to the PO when that JobMtl is referenced. It will also be copied into the PODetail.Comment field when the PO is buying the part for stock and not referencing a Job. View as an EDITOR widget. To be view-as EDITOR widget.
        /// </summary>
        [Required]
        public string PurComment { get; set; }

        [Required]
        [StringLength(2)]
        public string CostMethod { get; set; }
        
        /// <summary>
        /// Indicates the Tax Category for this Part. Used as a default to Order line items or Invoice line items. Can be left blank which indicates item is taxable. If entered must be valid in the TaxCat master file.  
        /// </summary>
        [Required]
        [StringLength(10)]
        public string TaxCatID { get; set; }

        public bool InActive { get; set; }

        public int LowLevelCode { get; set; }

        public bool Method { get; set; }

        public bool TrackLots { get; set; }
        /// <summary>
        /// Onhand quantity is always tracked in the Parts primary inventory uom (Part.IUM). Checking this box indicates that you want to allow tracking of onhand quantity by additional uoms.  The actual UOMs to be tracked for the part are indicated by PartUOM.TrackOnHand.In order to set the PartUOM.TrackOhHand = True the Part.TrackDimension must = true. 
        /// </summary>
        public bool TrackDimension { get; set; }

        [Required]
        [StringLength(6)]
        public string DefaultDim { get; set; }

        public bool TrackSerialNum { get; set; }
        /// <summary>
        /// Intrastat goods classification code following the Intrastat Classification Nomenclature (ICN). The Commodity Code field can be blank to indicate the value from the part class or must be valid in the ICommCode (formerly called IStatGrp) master file.
        /// </summary>
        [Required]
        [StringLength(12)]
        public string CommodityCode { get; set; }

        [Required]
        [StringLength(8)]
        public string WarrantyCode { get; set; }

        public bool PhantomBOM { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        public decimal SellingFactor { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal NetWeight { get; set; }

        public bool UsePartRev { get; set; }

        public int PartsPerContainer { get; set; }

        public decimal PartLength { get; set; }

        public decimal PartWidth { get; set; }

        public decimal PartHeight { get; set; }

        public int LotShelfLife { get; set; }

        public bool WebPart { get; set; }

        public bool RunOut { get; set; }

        [Required]
        [StringLength(50)]
        public string SubPart { get; set; }

        public decimal Diameter { get; set; }

        public decimal Gravity { get; set; }

        public bool OnHold { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OnHoldDate { get; set; }

        [Required]
        [StringLength(8)]
        public string OnHoldReasonCode { get; set; }
        /// <summary>
        /// Default analysis code to be used when this part appears as an assembly  on a quote or a job.
        /// </summary>
        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public bool GlobalPart { get; set; }

        [Required]
        [StringLength(8)]
        public string MtlAnalysisCode { get; set; }

        public bool GlobalLock { get; set; }
        /// <summary>
        /// This value is used to calculate the Supplementary Units for the Intrastat.
        /// </summary>
        public decimal ISSuppUnitsFactor { get; set; }

        [Required]
        [StringLength(8)]
        public string PDMObjID { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageFileName { get; set; }

        [Required]
        [StringLength(6)]
        public string ISOrigCountry { get; set; }
        /// <summary>
        /// Current setting for the prefix that will be attached to all new Serial Numbers as they are generated.
        /// </summary>
        [Required]
        [StringLength(30)]
        public string SNPrefix { get; set; }
        /// <summary>
        /// Current setting for Format of the Base serial number that will be used as new serial numbers are generated. Expressed in progress syntax. Ex: X(30), 99999999
        /// </summary>
        [Required]
        [StringLength(80)]
        public string SNFormat { get; set; }

        [Required]
        [StringLength(10)]
        public string SNBaseDataType { get; set; }

        public bool Constrained { get; set; }
        
        [Required]
        [StringLength(15)]
        public string EDICode { get; set; }

        public bool WebInStock { get; set; }

        public bool ConsolidatedPurchasing { get; set; }

        [Required]
        [StringLength(1)]
        public string PurchasingFactorDirection { get; set; }

        [Required]
        [StringLength(1)]
        public string SellingFactorDirection { get; set; }

        public bool RecDocReq { get; set; }

        public int MDPV { get; set; }
        /// <summary>
        /// Shipping Documents Required.  Indicates if shipping documents are required when shipping this part.Pertains to Inventory shipments of lot tracked parts or shipments directly from the job only.If checked, then at the time of shipping the system will require that the PartLot.Ship DocsAvail, or JobPart.ShipDocsAvail flag is true before allowing the shipment.Requires DocManagement license.
        /// </summary>
        public bool ShipDocReq { get; set; }

        [Required]
        [StringLength(30)]
        public string ReturnableContainer { get; set; }

        public decimal NetVolume { get; set; }

        public bool QtyBearing { get; set; }

        [Required]
        [StringLength(6)]
        public string NAFTAOrigCountry { get; set; }

        [Required]
        [StringLength(8)]
        public string NAFTAProd { get; set; }

        [Required]
        [StringLength(8)]
        public string NAFTAPref { get; set; }

        [Required]
        [StringLength(8)]
        public string ExpLicType { get; set; }

        [Required]
        [StringLength(25)]
        public string ExpLicNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string ECCNNumber { get; set; }

        [Required]
        [StringLength(8)]
        public string AESExp { get; set; }

        [Required]
        [StringLength(10)]
        public string HTS { get; set; }

        public bool UseHTSDesc { get; set; }

        [Required]
        [StringLength(12)]
        public string SchedBcode { get; set; }

        public bool HazItem { get; set; }

        [Required]
        [StringLength(40)]
        public string HazTechName { get; set; }

        [Required]
        [StringLength(8)]
        public string HazClass { get; set; }

        [Required]
        [StringLength(8)]
        public string HazSub { get; set; }

        [Required]
        [StringLength(8)]
        public string HazGvrnmtID { get; set; }

        [Required]
        public string HazPackInstr { get; set; }

        [Required]
        [StringLength(8)]
        public string RevChargeMethod { get; set; }

        public decimal RCUnderThreshold { get; set; }

        public decimal RCOverThreshold { get; set; }

        [Required]
        [StringLength(8)]
        public string OwnershipStatus { get; set; }

        [Required]
        [StringLength(12)]
        public string UOMClassID { get; set; }

        [Required]
        [StringLength(20)]
        public string SNMask { get; set; }

        [Required]
        [StringLength(80)]
        public string SNMaskExample { get; set; }

        [Required]
        [StringLength(10)]
        public string SNMaskSuffix { get; set; }

        [Required]
        [StringLength(10)]
        public string SNMaskPrefix { get; set; }

        [Required]
        [StringLength(40)]
        public string SNLastUsedSeq { get; set; }

        public bool UseMaskSeq { get; set; }

        [Required]
        [StringLength(6)]
        public string NetWeightUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string NetVolumeUOM { get; set; }

        public bool LotBatch { get; set; }

        public bool LotMfgBatch { get; set; }

        public bool LotMfgLot { get; set; }

        public bool LotHeat { get; set; }

        public bool LotFirmware { get; set; }

        public bool LotBeforeDt { get; set; }

        public bool LotMfgDt { get; set; }

        public bool LotCureDt { get; set; }

        public bool LotExpDt { get; set; }

        [Required]
        [StringLength(20)]
        public string LotPrefix { get; set; }

        public bool LotUseGlobalSeq { get; set; }

        [Required]
        [StringLength(12)]
        public string LotSeqID { get; set; }

        public int LotNxtNum { get; set; }

        public int LotDigits { get; set; }

        public bool LotLeadingZeros { get; set; }

        [Required]
        [StringLength(10)]
        public string LotAppendDate { get; set; }

        public bool BuyToOrder { get; set; }

        public bool DropShip { get; set; }

        public bool IsConfigured { get; set; }

        public bool ExtConfig { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCategory { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string FSAssetClassCode { get; set; }

        public decimal FSSalesUnitPrice { get; set; }

        [Required]
        [StringLength(2)]
        public string FSPricePerCode { get; set; }

        public bool RcvInspectionReq { get; set; }

        [Required]
        [StringLength(256)]
        public string EstimateID { get; set; }

        [Required]
        [StringLength(20)]
        public string EstimateOrPlan { get; set; }

        public bool DiffPrc2PrchUOM { get; set; }

        public bool DupOnJobCrt { get; set; }

        public decimal PricingFactor { get; set; }

        [Required]
        [StringLength(6)]
        public string PricingUOM { get; set; }

        public bool MobilePart { get; set; }

        public bool AGUseGoodMark { get; set; }

        public bool AGProductMark { get; set; }

        [Required]
        [StringLength(3)]
        public string ISRegion { get; set; }

        public bool LinkToContract { get; set; }

        [Required]
        [StringLength(6)]
        public string PartLengthWidthHeightUM { get; set; }

        [Required]
        [StringLength(6)]
        public string DiameterUM { get; set; }

        public decimal DiameterInside { get; set; }

        public decimal DiameterOutside { get; set; }

        [Required]
        [StringLength(6)]
        public string ThicknessUM { get; set; }

        public decimal Thickness { get; set; }

        public decimal ThicknessMax { get; set; }

        [Required]
        [StringLength(30)]
        public string Durometer { get; set; }

        [Required]
        [StringLength(30)]
        public string Specification { get; set; }

        [Required]
        [StringLength(30)]
        public string EngineeringAlert { get; set; }

        [Required]
        [StringLength(30)]
        public string Condition { get; set; }

        public bool IsCompliant { get; set; }

        public bool IsRestricted { get; set; }

        public bool IsSafetyItem { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialBrand { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSubBrand { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSubCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialStyle { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSize1 { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSize2 { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialColor { get; set; }

        public bool IsGiftCard { get; set; }

        [Required]
        [StringLength(8)]
        public string PhotoFile { get; set; }

        public bool PartPhotoExists { get; set; }

        [Required]
        public string CommentText { get; set; }
        /// <summary>
        /// Indicates if the packaging information is part specific or specified at the UOM class level.
        /// </summary>
        public bool PartSpecificPackingUOM { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageID { get; set; }

        [Required]
        [StringLength(30)]
        public string CNSpecification { get; set; }

        public bool SyncToExternalCRM { get; set; }
        /// <summary>
        /// This field holds the id of this part in the External CRM
        /// </summary>
        [Required]
        [StringLength(200)]
        public string ExternalCRMPartID { get; set; }
        /// <summary>
        /// This field defines the last time that the  part  has been Synchronized between Epicor ERP and the External CRM. This field is maintained by the External CRM Synchronization  process.
        /// </summary>
        public DateTime? ExternalCRMLastSync { get; set; }
        /// <summary>
        /// This fields determines if the part needs to be synchronized to the External CRM. If there are changes in the part master file , Epicor ERP automatically turns on this field.
        /// </summary>
        public bool ExternalCRMSyncRequired { get; set; }
        public int TenantId { get; set; }
    }
}
