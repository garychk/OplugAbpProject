using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RcvHead")]
    public partial class RcvHead : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public int VendorNum { get; set; }
        /// <summary>
        /// 供应商采购点ID。
        /// </summary>
        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        public bool SaveForInvoicing { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        public string ReceiptComment { get; set; }

        [Required]
        [StringLength(75)]
        public string ReceivePerson { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EntryDate { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int PONum { get; set; }
        /// <summary>
        /// 到岸成本参考字段
        /// </summary>
        [Required]
        public string LCReference { get; set; }
        /// <summary>
        /// 到岸成本的注释字段
        /// </summary>
        [Required]
        public string LCComment { get; set; }

        public decimal LandedCost { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }
        /// <summary>
        /// 此字段保留到岸成本的差异金额。
        /// </summary>
        public decimal LCVariance { get; set; }
        /// <summary>
        /// 指示是否链接到公司间装运。
        /// </summary>
        public bool ICLinked { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public int GlbVendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string GlbPurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string GlbPackSlip { get; set; }

        public int ContainerID { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(8)]
        public string LCDisburseMethod { get; set; }

        public bool AutoReceipt { get; set; }

        [Required]
        [StringLength(7)]
        public string AutoTranType { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }

        public int AutoTranID { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public decimal UpliftPercent { get; set; }

        public decimal SpecDutyAmt { get; set; }

        public decimal AppliedLCAmt { get; set; }

        public decimal LCDutyAmt { get; set; }

        public decimal LCIndCost { get; set; }

        public bool ApplyToLC { get; set; }

        public bool Received { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivedDate { get; set; }

        public decimal AppliedRcptLCAmt { get; set; }

        public decimal LCUpliftIndCost { get; set; }
        /// <summary>
        /// 此字段保留已应用的到岸成本差异金额。
        /// </summary>
        public decimal AppliedLCVariance { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string ImportNum { get; set; }

        public int ImportedFrom { get; set; }

        [Required]
        [StringLength(40)]
        public string ImportedFromDesc { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }
        public int TenantId { get; set; }
    }
}
