using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RMADtl")]
    public partial class RMADtl : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenRMA { get; set; }

        public bool OpenDtl { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMANum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMALine { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        [Required]
        [StringLength(8)]
        public string ReturnReasonCode { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public decimal ReturnQty { get; set; }

        [Required]
        [StringLength(6)]
        public string ReturnQtyUOM { get; set; }

        public int RefInvoiceNum { get; set; }

        public int RefInvoiceLine { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public int ConNum { get; set; }

        public int CustNum { get; set; }

        public int OrderRelNum { get; set; }

        public int ShipToCustNum { get; set; }

        public int InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int MtlSeq { get; set; }

        [Required]
        public string ECCComment { get; set; }

        [Required]
        [StringLength(10)]
        public string ECCRMANum { get; set; }

        public int ECCRMALine { get; set; }
        public int TenantId { get; set; }
    }
}
