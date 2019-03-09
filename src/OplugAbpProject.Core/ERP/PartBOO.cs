using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PartBOO")]
    public class PartBOO : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(50)]
        public string EndPartNum { get; set; }

        [StringLength(12)]
        public string EndRevision { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BomSequence { get; set; }

        public int BomLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string MtlPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string MtlRevision { get; set; }

        [Required]
        public string PartDescription { get; set; }

        public decimal QtyPer { get; set; }

        public decimal QtyRequired { get; set; }

        [Required]
        [StringLength(3)]
        public string BOMType { get; set; }

        public bool Approved { get; set; }

        public int OprSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        public decimal EstSetHours { get; set; }

        public decimal EstProdHours { get; set; }

        [Required]
        [StringLength(50)]
        public string IndMtlPartNum { get; set; }

        [Required]
        [StringLength(5)]
        public string ResourceGrpID { get; set; }

        public int TenantId { get; set; }
    }
}
