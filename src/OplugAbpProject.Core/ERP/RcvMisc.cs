using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RcvMisc")]
    public partial class RcvMisc : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorNum { get; set; }

        [StringLength(4)]
        public string PurPoint { get; set; }

        [StringLength(20)]
        public string PackSlip { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiscSeq { get; set; }

        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }
        /// <summary>
        /// 用于指示间接成本是否要从到岸成本计算中排除的标志。选中InctransValue时禁用。
        /// </summary>
        public bool ExcludeFromLC { get; set; }
        /// <summary>
        /// 用于指示间接成本是否包括在用于计算关税的交易记录值（统计值）中的标志。选中ExcludeFromLC时禁用。
        /// </summary>
        public bool IncTransValue { get; set; }
        /// <summary>
        /// 标识如何在收据明细中支付到岸成本。有效选项包括体积（仅适用于绑定到容器的订单发布）、重量、值、数量和手动。
        /// </summary>
        [Required]
        [StringLength(8)]
        public string LCDisburseMethod { get; set; }

        public decimal ActualAmt { get; set; }

        public decimal DocActualAmt { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public bool LockRate { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal RptActualAmt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApplyDate { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        public int MscNum { get; set; }

        public decimal Percentage { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        public int APInvVendorNum { get; set; }

        public int PackLine { get; set; }
        public int TenantId { get; set; }
    }
}
