using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RMADisp")]
    public partial class RMADisp : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMANum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMALine { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMAReceipt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMADisp1 { get; set; }

        [Required]
        [StringLength(7)]
        public string DispType { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int MtlSeq { get; set; }

        [Required]
        public string DispComment { get; set; }

        [Required]
        [StringLength(8)]
        public string InspectorID { get; set; }

        [Required]
        [StringLength(75)]
        public string InspectedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InspectedDate { get; set; }

        public int InspectedTime { get; set; }

        public int NonConfTranID { get; set; }

        [Required]
        [StringLength(8)]
        public string ReasonCode { get; set; }

        public decimal DispQty { get; set; }

        [Required]
        [StringLength(6)]
        public string DispQtyUOM { get; set; }

        [Required]
        [StringLength(20)]
        public string SourceDBRecid { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool RequestMove { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public bool OverrideCosts { get; set; }

        public bool UseCurrentCost { get; set; }

        [Required]
        [StringLength(10)]
        public string ToBinNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ToWareHouseCode { get; set; }

        public bool SetReassignSNAsm { get; set; }
        public int TenantId { get; set; }
    }
}
