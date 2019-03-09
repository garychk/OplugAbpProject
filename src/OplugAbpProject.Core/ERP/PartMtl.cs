using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PartMtl")]
    public partial class PartMtl : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public int MtlSeq { get; set; }

        [Required]
        [StringLength(50)]
        public string MtlPartNum { get; set; }

        public decimal QtyPer { get; set; }

        public bool FixedQty { get; set; }

        public int RelatedOperation { get; set; }

        [Required]
        [StringLength(50)]
        public string SalvagePartNum { get; set; }

        [Required]
        public string SalvageDescription { get; set; }

        public decimal SalvageQtyPer { get; set; }

        [Required]
        [StringLength(6)]
        public string SalvageUM { get; set; }

        public decimal SalvageUnitCredit { get; set; }

        [Required]
        public string MfgComment { get; set; }

        public bool OverRideMfgComments { get; set; }

        [Required]
        public string PurComment { get; set; }

        public bool OverRidePurComments { get; set; }

        public decimal EstScrap { get; set; }

        [Required]
        [StringLength(1)]
        public string EstScrapType { get; set; }

        public bool PullAsAsm { get; set; }

        [Required]
        [StringLength(10)]
        public string FindNum { get; set; }

        public bool ViewAsAsm { get; set; }

        [Required]
        [StringLength(11)]
        public string APSSchedulerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? APSSLDate { get; set; }

        public decimal APSSLTime { get; set; }

        [Required]
        [StringLength(1)]
        public string APSInsertDirection { get; set; }

        [Required]
        [StringLength(1)]
        public string APSInsertCriteria { get; set; }

        public decimal APSAttrib1 { get; set; }

        public decimal APSAttrib2 { get; set; }

        public decimal APSAttrib3 { get; set; }

        public decimal APSAttrib4 { get; set; }

        [Required]
        [StringLength(1)]
        public string APSAddResType { get; set; }

        public decimal SalvageMtlBurRate { get; set; }

        public decimal SalvageEstMtlBurUnitCredit { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal EstMtlBurUnitCost { get; set; }

        public bool RFQNeeded { get; set; }

        public int RFQVendQuotes { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        [Required]
        [StringLength(8)]
        public string ReqdInPlant { get; set; }

        [Required]
        [StringLength(12)]
        public string AltMethod { get; set; }

        public bool BaseMethodOverridden { get; set; }

        [Required]
        [StringLength(8)]
        public string RelatedStage { get; set; }

        [Required]
        [StringLength(12)]
        public string ParentAltMethod { get; set; }

        public int ParentMtlSeq { get; set; }

        [Required]
        [StringLength(6)]
        public string UOMCode { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        [Required]
        [StringLength(8)]
        public string RuleTag { get; set; }

        public int ReqRefDes { get; set; }

        public bool PlanAsAsm { get; set; }        
        public bool ReassignSNAsm { get; set; }
        public int TenantId { get; set; }
    }
}
