using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RMARcpt")]
    public partial class RMARcpt : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMANum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMALine { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMAReceipt { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RcvDate { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        public bool OpenReceipt { get; set; }

        public decimal MtlUnitCost { get; set; }

        public decimal LbrUnitCost { get; set; }

        public decimal BurUnitCost { get; set; }

        public decimal SubUnitCost { get; set; }

        public decimal MtlBurUnitCost { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public decimal MtlMtlUnitCost { get; set; }

        public decimal MtlLabUnitCost { get; set; }

        public decimal MtlSubUnitCost { get; set; }

        public decimal MtlBurdenUnitCost { get; set; }

        public decimal MtlMtlBurUnitCost { get; set; }

        public decimal ReceivedQty { get; set; }

        public decimal DisposedQty { get; set; }

        [Required]
        [StringLength(6)]
        public string CostUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string ReceivedQtyUOM { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool RequestMove { get; set; }
        public int TenantId { get; set; }
    }
}
