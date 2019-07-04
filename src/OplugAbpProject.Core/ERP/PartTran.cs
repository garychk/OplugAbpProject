using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PartTran")]
    public partial class PartTran : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SysDate { get; set; }

        public int SysTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }
        /// <summary>
        /// Warehouse that transaction is applied to
        /// </summary>
        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }
        /// <summary>
        /// Identifies the Bin location that this transaction affected.
        /// </summary>
        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(2)]
        public string TranClass { get; set; }

        [Required]
        [StringLength(7)]
        public string TranType { get; set; }
        /// <summary>
        /// Indicates if this is an inventory transaction, which is any part transaction that affects inventory quantity or cost.  Specifically,  the following transaction types: (1) begin or end with "STK", (2) "ADJ-CST" and "ADJ-QTY", (3) "INS-DMR" and "DMR-REJ" for non-part-master parts. 
        /// </summary>
        public bool InventoryTrans { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TranDate { get; set; }

        public decimal TranQty { get; set; }

        [Required]
        [StringLength(6)]
        public string UM { get; set; }

        public decimal MtlUnitCost { get; set; }
        /// <summary>
        /// Labor Unit Cost
        /// </summary>
        public decimal LbrUnitCost { get; set; }
        /// <summary>
        /// Burden Unit Cost
        /// </summary>
        public decimal BurUnitCost { get; set; }
        /// <summary>
        /// Subcontract Unit Cost
        /// </summary>
        public decimal SubUnitCost { get; set; }
        /// <summary>
        /// Subcontract Unit Cost
        /// </summary>
        public decimal MtlBurUnitCost { get; set; }
        /// <summary>
        /// Extended Cost is calculated as  (TranQty* (MtlUnitCost + LbrUnitCost + BurUnitCost) ). This is updated via the PartTran write trigger. NOTE: An exception is where PartTran.TranType = "Adj-Pur" in which case the TranQty and UnitCost fields are zero and the ExtCost is calculated outside of the write trigger.  
        /// </summary>
        public decimal ExtCost { get; set; }

        [Required]
        [StringLength(2)]
        public string CostMethod { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        [Required]
        [StringLength(2)]
        public string PackType { get; set; }

        public int PackNum { get; set; }

        public int PackLine { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }
        /// <summary>
        /// Transfer "From/To" warehouse code. This is used for the warehouse transfer transactions. For the Issue side of the transaction it identifies the "transfer to" warehouse. For the receipt side of the transaction it identifies the "transfer from" warehouse. 
        /// </summary>
        [Required]
        [StringLength(8)]
        public string WareHouse2 { get; set; }
        /// <summary>
        /// This value only exists for the warehouse transaction. TranSrc = "4".  For the Issue side of the transaction it identifies the Bin location that the quantity is transferred in to. On the Receipt side of the transaction it identifies the Bin location that the quantity was transferred from.  
        /// </summary>
        [Required]
        [StringLength(10)]
        public string BinNum2 { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Required]
        public string TranReference { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public int VendorNum { get; set; }
        /// <summary>
        /// Vendor purchase point ID. (see VendorNum)
        /// </summary>
        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public decimal POReceiptQty { get; set; }

        public decimal POUnitCost { get; set; }

        [Required]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        [Required]
        [StringLength(2)]
        public string InvAdjSrc { get; set; }
        /// <summary>
        /// Used for Inventory Adjustment Source "Other" OR MTL-DMR, STK-DMR, SUB-DMR, or INS-DMR transaction types.  Refers to the Reason table.
        /// </summary>
        [Required]
        [StringLength(8)]
        public string InvAdjReason { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }
        /// <summary>
        /// Unique dimension code for the part.
        /// </summary>
        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM { get; set; }

        public decimal DimConvFactor { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum2 { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode2 { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM2 { get; set; }

        public decimal DimConvFactor2 { get; set; }

        public bool GLTrans { get; set; }

        public bool PostedToGL { get; set; }

        public int FiscalYear { get; set; }

        public int FiscalPeriod { get; set; }

        public int JournalNum { get; set; }

        public bool Costed { get; set; }

        public int DMRNum { get; set; }

        public int ActionNum { get; set; }

        public int RMANum { get; set; }

        public bool COSPostingReqd { get; set; }

        [Required]
        [StringLength(4)]
        public string JournalCode { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant2 { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        public int MatNum { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum2 { get; set; }

        public int AssemblySeq2 { get; set; }

        public int JobSeq2 { get; set; }

        public int CustNum { get; set; }

        public int RMALine { get; set; }

        public int RMAReceipt { get; set; }

        public int RMADisp { get; set; }

        public decimal OtherDivValue { get; set; }

        public int PlantTranNum { get; set; }

        public int NonConfID { get; set; }
        /// <summary>
        /// Breakdown of MtlUnit cost into individual components. MtlUnitCost = MtlMtlUnitCost + MtlLabUnitCost + MtlBurdenUnitCost + MtlSubUnitCost.
        /// </summary>
        public decimal MtlMtlUnitCost { get; set; }
        /// <summary>
        /// Breakdown of MtlUnit cost into individual components. MtlUnitCost = MtlMtlUnitCost + MtlLabUnitCost + MtlBurdenUnitCost + MtlSubUnitCost.
        /// </summary>
        public decimal MtlLabUnitCost { get; set; }
        /// <summary>
        /// Breakdown of MtlUnit cost into individual components. MtlUnitCost = MtlMtlUnitCost + MtlLabUnitCost + MtlBurdenUnitCost + MtlSubUnitCost.
        /// </summary>
        public decimal MtlSubUnitCost { get; set; }
        /// <summary>
        /// Breakdown of MtlUnit cost into individual components. MtlUnitCost = MtlMtlUnitCost + MtlLabUnitCost + MtlBurdenUnitCost + MtlSubUnitCost + MtlMtlBurUnitCost
        /// </summary>
        public decimal MtlBurdenUnitCost { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public decimal BeginQty { get; set; }

        public decimal AfterQty { get; set; }

        public decimal BegBurUnitCost { get; set; }

        public decimal BegLbrUnitCost { get; set; }

        public decimal BegMtlBurUnitCost { get; set; }

        public decimal BegMtlUnitCost { get; set; }

        public decimal BegSubUnitCost { get; set; }

        public decimal AfterBurUnitCost { get; set; }

        public decimal AfterLbrUnitCost { get; set; }

        public decimal AfterMtlBurUnitCost { get; set; }

        public decimal AfterMtlUnitCost { get; set; }

        public decimal AfterSubUnitCost { get; set; }

        public decimal PlantCostValue { get; set; }

        [Required]
        [StringLength(8)]
        public string EmpID { get; set; }

        public int ReconcileNum { get; set; }

        [Required]
        [StringLength(8)]
        public string CostID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIFODate { get; set; }

        public int FIFOSeq { get; set; }

        public decimal ActTranQty { get; set; }

        [Required]
        [StringLength(6)]
        public string ActTransUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string InvtyUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string InvtyUOM2 { get; set; }

        [Required]
        [StringLength(4)]
        public string FIFOAction { get; set; }

        [Required]
        [StringLength(8)]
        public string FiscalYearSuffix { get; set; }

        [Required]
        [StringLength(12)]
        public string FiscalCalendarID { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        public int CCYear { get; set; }

        public int CCMonth { get; set; }

        public int CycleSeq { get; set; }

        [Required]
        [StringLength(36)]
        public string ABTUID { get; set; }
        /// <summary>
        /// Defines the Costing method that was used to create the transaction.   A =  Average L= Last S = Standard. This is duplicated from the PartSite.CostMethod or Part.CostMethod
        /// </summary>
        [Required]
        [StringLength(2)]
        public string BaseCostMethod { get; set; }
        /// <summary>
        /// Revert Status field, with following values: 0.	Not reverted(default initial value) 1.	Reverted
        /// </summary>
        public int RevertStatus { get; set; }

        [Required]
        [StringLength(36)]
        public string RevertID { get; set; }

        [Required]
        [StringLength(20)]
        public string DropShipPackSlip { get; set; }

        [Required]
        [StringLength(3)]
        public string VarTarget { get; set; }
        /// <summary>
        /// The FIFO subsequence number of the related PartFIFOCost record.
        /// </summary>
        public int FIFOSubSeq { get; set; }
        /// <summary>
        /// Alternate FIFO Material Unit Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltMtlUnitCost { get; set; }
        /// <summary>
        /// Alternate FIFO Labor Unit Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltLbrUnitCost { get; set; }
        /// <summary>
        /// Alternate FIFO Burden Unit Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltBurUnitCost { get; set; }
        /// <summary>
        /// Alternate FIFO Subcontract Unit Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltSubUnitCost { get; set; }
        /// <summary>
        /// Alternate FIFO Material Burden Unit Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltMtlBurUnitCost { get; set; }
        /// <summary>
        /// Alternate FIFO Extended Cost used when maintaining FIFO cost record (PartFIFOCost) for non-FIFO costed part.
        /// </summary>
        public decimal AltExtCost { get; set; }
        /// <summary>
        /// Breakdown of AltMtlUnit cost into individual components. AltMtlUnitCost = AltMtlMtlUnitCost + AltMtlLabUnitCost + AltMtlBurdenUnitCost + AltMtlSubUnitCost.
        /// </summary>
        public decimal AltMtlMtlUnitCost { get; set; }

        public decimal AltMtlLabUnitCost { get; set; }

        public decimal AltMtlSubUnitCost { get; set; }

        public decimal AltMtlBurdenUnitCost { get; set; }
        /// <summary>
        /// Transaction document type id.
        /// </summary>
        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }
        /// <summary>
        /// Invoice Number from Progress Billing Invoice preparation
        /// </summary>
        public int PBInvNum { get; set; }
        /// <summary>
        /// This is only relevant for TranType MFG-MFG. Valid types are '' , 'L', and 'B'.  For Transfers, set to ''. For Loans and Repayment of Loans set PartTran.LoanType to either 'L' or 'B' based on PartTran.JobNum.If PartTran.JobNum is the job who is making the loan (or who made the loan, in the case of a repayment), then set to 'L' (loaner).  If PartTran.JobNum is the job who originally received the loan or who is receiving a loan set to 'B' (borrower).
        /// </summary>
        [Required]
        [StringLength(1)]
        public string LoanFlag { get; set; }
        /// <summary>
        /// Unique identifier of the Asset.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string AssetNum { get; set; }
        /// <summary>
        /// Unique number to identify the Addition activity of an asset.
        /// </summary>
        public int AdditionNum { get; set; }
        /// <summary>
        /// Unique number to identify the Disposal activity of an asset.
        /// </summary>
        public int DisposalNum { get; set; }
        /// <summary>
        /// Logical field to indicate if this record has been read by project analysis process.
        /// </summary>
        public bool ProjProcessed { get; set; }
        /// <summary>
        /// Used by Project Analysis process.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AsOfDate { get; set; }

        public int AsOfSeq { get; set; }
        /// <summary>
        /// Like RcvMisc.MscNum. Filled only for ADJ-PUR transactions created from late costs.
        /// </summary>
        public int MscNum { get; set; }

        public decimal ODCUnitCost { get; set; }
        public int TranRefType { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        public int PCIDCollapseCounter { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID2 { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LCFlag { get; set; }

        public decimal ExtMtlCost { get; set; }

        public decimal ExtLbrCost { get; set; }

        public decimal ExtBurCost { get; set; }

        public decimal ExtSubCost { get; set; }

        public decimal ExtMtlBurCost { get; set; }

        public decimal ExtMtlMtlCost { get; set; }

        public decimal ExtMtlLabCost { get; set; }

        public decimal ExtMtlSubCost { get; set; }

        public decimal ExtMtlBurdenCost { get; set; }
        public int TenantId { get; set; }
    }
}
