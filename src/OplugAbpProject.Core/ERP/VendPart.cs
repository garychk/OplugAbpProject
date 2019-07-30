using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("VendPart")]
    public partial class VendPart : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        public int VendorNum { get; set; }
        /// <summary>
        /// 用于记录此供应商为此零件提供的正常订单提前期。该值以天表示。它是可选的。用于计算建议的订单日期，作为作业物料详细信息记录中的默认值。
        /// </summary>
        public int LeadTime { get; set; }

        public decimal BaseUnitPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PriceFormat { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public decimal MinimumPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Reference { get; set; }
        /// <summary>
        /// 购买此服务时产生的总附加费用。Ex（批次、设置、处理等）。这仅与分包合同价格一起使用。它默认为QuoteOpr.MiscCharge、JobOper.MiscCharge和Pomisc.MiscAmt。将默认为这不是单位成本的一部分。在使用最低成本的逻辑中不考虑这一点。
        /// </summary>
        public decimal MiscAmt { get; set; }

        /// <summary>
        /// 与“杂项费用”字段相关的杂项费用代码。如果misccharge<>0，则必须在purmisc文件中输入并有效。这将是在采购订单条目中创建默认值时用于创建POMISC记录的杂项代码。
        /// </summary>
        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal DiscountPercent { get; set; }

        [Required]
        public string PartDescription { get; set; }
        /// <summary>
        /// 相关询价单编号。注：通过主维护输入的价格折扣为零。
        /// </summary>
        public int RFQNum { get; set; }
        /// <summary>
        /// 相关询价行编号。注意：主维护程序创建的价格折扣为零。
        /// </summary>
        public int RFQLine { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 供应商现存量
        /// </summary>
        public decimal OnhandQty { get; set; }

        /// <summary>
        /// 更改供应商数量的日期
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? OnHandDate { get; set; }
        /// <summary>
        /// 更改供应商数量的时间
        /// </summary>
        public int OnHandTime { get; set; }

        public int ConNum { get; set; }
        /// <summary>
        /// 这用于SupplierConnect。它表示供应商已完成对询价单的更改，并准备好将数据发布回Vantage。
        /// </summary>
        public bool SupplierResponseReady { get; set; }

        public bool DefaultPUM { get; set; }

        /// <summary>
        /// 指示用于执行UOM转换的数学运算符。选项为“*”（乘）或“\”（除）。例如，英尺到英寸，其中英寸是基本计量单位。你可以有1ft/12=1in
        /// </summary>
        [Required]
        [StringLength(8)]
        public string ConvOperator { get; set; }

        public decimal ConvFactor { get; set; }

        public bool ConvOverRide { get; set; }
        public int TenantId { get; set; }
    }
}
