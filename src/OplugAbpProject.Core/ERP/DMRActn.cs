using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("DMRActn")]
    public partial class DMRActn : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DMRNum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActionNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActionDate { get; set; }

        [Required]
        [StringLength(2)]
        public string ActionType { get; set; }

        public decimal Quantity { get; set; }

        [Required]
        [StringLength(2)]
        public string DestinationType { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int DMRSeqNum { get; set; }

        public decimal UnitCredit { get; set; }

        public decimal DocUnitCredit { get; set; }

        [Required]
        [StringLength(6)]
        public string CreditUM { get; set; }

        [Required]
        [StringLength(20)]
        public string DebitMemoNum { get; set; }

        public int DebitMemoLine { get; set; }

        [Required]
        [StringLength(30)]
        public string VendRMANum { get; set; }

        [Required]
        [StringLength(75)]
        public string ActionUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SysDate { get; set; }

        public int SysTime { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        [StringLength(8)]
        public string ReasonCode { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public bool LockRate { get; set; }

        [Required]
        [StringLength(8)]
        public string FldWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string FldBinNum { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public decimal Rpt1UnitCredit { get; set; }

        public decimal Rpt2UnitCredit { get; set; }

        public decimal Rpt3UnitCredit { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        [Required]
        [StringLength(8)]
        public string Resolution { get; set; }

        public bool ReturnToSupplier { get; set; }

        [Required]
        [StringLength(20)]
        public string PackSlip { get; set; }

        public int PackLine { get; set; }

        public bool DisableRejection { get; set; }

        [Required]
        [StringLength(20)]
        public string DisableRejectionChar { get; set; }

        [Required]
        [StringLength(20)]
        public string RefInvoiceNum { get; set; }

        public bool IssuedComplete { get; set; }
        public int TenantId { get; set; }
    }
}
