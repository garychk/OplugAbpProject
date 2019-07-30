using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("OpMaster")]
    public partial class OpMaster : Entity<int>, IMustHaveTenant
    {
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Column(Order = 1)]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Required]
        [StringLength(30)]
        public string OpDesc { get; set; }

        [Required]
        [StringLength(4)]
        public string OpTextID { get; set; }

        [Required]
        [StringLength(8)]
        public string BuyerID { get; set; }

        public bool APSPrepOpF { get; set; }

        [Required]
        [StringLength(3)]
        public string OPType { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal BillLaborRate { get; set; }

        public decimal EstLabHours { get; set; }

        public int SchedPrecedence { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public int PrimarySetupOpDtl { get; set; }

        public int PrimaryProdOpDtl { get; set; }

        public int VendorNum { get; set; }

        public bool Subcontract { get; set; }

        public bool PrdYldRecalcExpected { get; set; }

        public int PrdYldRecalcUnderPct { get; set; }

        public bool PrdYldShopWrnAlert { get; set; }

        public bool PrdYldShopWrn { get; set; }

        public int PrdYldShopWrnUnderPct { get; set; }

        public int PrdYldShopWrnOverPct { get; set; }

        public bool RestrictSubstance { get; set; }

        [Required]
        [StringLength(12)]
        public string RoughCutCode { get; set; }

        [Required]
        [StringLength(8)]
        public string SendAheadType { get; set; }

        public decimal SendAheadOffset { get; set; }

        [Required]
        public string PrjRoleList { get; set; }

        [Required]
        [StringLength(20)]
        public string RoleCodeDefault { get; set; }

        public bool UseAllRoles { get; set; }

        [Required]
        public string JDFMaterial { get; set; }

        [Required]
        [StringLength(100)]
        public string JDFDevice { get; set; }

        [Required]
        [StringLength(50)]
        public string JDFOperation { get; set; }
        public bool ExternalMES { get; set; }
        public int TenantId { get; set; }
    }
}
