using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("Resource")]
    public partial class Resource : Entity<long>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [StringLength(12)]
        public string ResourceID { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public bool Inactive { get; set; }

        public bool Finite { get; set; }

        public bool AllowManualOverride { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextMaintDate { get; set; }

        [Required]
        [StringLength(8)]
        public string OutputWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string OutputBinNum { get; set; }

        [Required]
        [StringLength(8)]
        public string BackflushWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string BackflushBinNum { get; set; }

        [Required]
        [StringLength(8)]
        public string InputWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string InputBinNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceType { get; set; }

        public decimal ConcurrentCapacity { get; set; }

        public bool TrackProdQty { get; set; }

        [Required]
        [StringLength(50)]
        public string LinkedPart { get; set; }

        [Required]
        [StringLength(20)]
        public string AssetNum { get; set; }

        public decimal ProdBurRate { get; set; }

        public decimal ProdLabRate { get; set; }

        public decimal SetupBurRate { get; set; }

        public decimal SetupLabRate { get; set; }

        public decimal QProdBurRate { get; set; }

        public decimal QProdLabRate { get; set; }

        public decimal QSetupBurRate { get; set; }

        public decimal QSetupLabRate { get; set; }

        [Required]
        [StringLength(8)]
        public string QBurdenType { get; set; }

        public bool GetDefaultBurdenFromGroup { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(8)]
        public string BurdenType { get; set; }

        [Required]
        [StringLength(8)]
        public string CalendarID { get; set; }

        public decimal MoveHours { get; set; }

        public decimal QueHours { get; set; }

        public bool GetDefaultMQFromGroup { get; set; }

        public bool InformOverload { get; set; }

        public decimal MinOverloadPerc { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Required]
        [StringLength(5)]
        public string OpStdID { get; set; }

        public bool GetDefaultLaborFromGroup { get; set; }

        public int FiniteHorizon { get; set; }

        public bool AutoMove { get; set; }

        public bool SplitOperations { get; set; }

        public decimal DailyProdQty { get; set; }

        public decimal BillLaborRate { get; set; }

        public decimal DailyProdRate { get; set; }

        public bool GetDefaultWhseFromGroup { get; set; }

        public bool Location { get; set; }

        [Required]
        [StringLength(50)]
        public string InspPlanPartNum { get; set; }

        [Required]
        [StringLength(20)]
        public string SpecID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastCalDate { get; set; }

        [Required]
        [StringLength(12)]
        public string InspPlanRevNum { get; set; }

        [Required]
        [StringLength(12)]
        public string SpecRevNum { get; set; }

        [Required]
        [StringLength(20)]
        public string EquipID { get; set; }

        [Required]
        [StringLength(500)]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string JDFDevice { get; set; }

        public bool ExternalMES { get; set; }

        public decimal NumCavs { get; set; }

        public decimal RunnerWt { get; set; }

        public int SetupTime { get; set; }

        public int TearDownTime { get; set; }

        [Required]
        [StringLength(30)]
        public string MiscInfo1 { get; set; }

        [Required]
        [StringLength(30)]
        public string MiscInfo2 { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        [StringLength(20)]
        public string LocID { get; set; }

        public int PmMapNo { get; set; }

        [Required]
        [StringLength(256)]
        public string SetupURL { get; set; }

        public bool MobileResource { get; set; }
        public int TenantId { get; set; }
    }
}
