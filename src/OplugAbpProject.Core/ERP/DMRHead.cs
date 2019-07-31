using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("DMRHead")]
    public partial class DMRHead : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DMRNum { get; set; }

        public bool OpenDMR { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public int ConNum { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal TotDiscrepantQty { get; set; }

        public decimal TotRejectedQty { get; set; }

        public decimal TotAcceptedQty { get; set; }

        public decimal AvgMtlUnitCost { get; set; }

        public decimal AvgLbrUnitCost { get; set; }

        public decimal AvgBurUnitCost { get; set; }

        public decimal AvgSubUnitCost { get; set; }

        public decimal AvgMtlBurUnitCost { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public bool CheckOff1 { get; set; }

        public bool CheckOff2 { get; set; }

        public bool CheckOff3 { get; set; }

        public bool CheckOff4 { get; set; }

        public bool CheckOff5 { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int MtlSeq { get; set; }

        public int OprSeq { get; set; }

        [Required]
        [StringLength(12)]
        public string ResourceID { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public decimal MaterialMtlCost { get; set; }

        public decimal MaterialLabCost { get; set; }

        public decimal MaterialSubCost { get; set; }

        public decimal MaterialBurCost { get; set; }

        public bool ReqDMR { get; set; }

        [Required]
        [StringLength(30)]
        public string VendRMANum { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int PONum { get; set; }
        public int TenantId { get; set; }
    }
}
