using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("ResourceGroup")]
    public partial class ResourceGroup : Entity<int>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(8)]
        public string CalendarID { get; set; }

        public bool Inactive { get; set; }

        public bool AllowManualOverride { get; set; }

        public int FiniteHorizon { get; set; }

        public int NumberOfMachines { get; set; }

        public int SchMachine { get; set; }

        [Required]
        [StringLength(8)]
        public string BurdenType { get; set; }

        public decimal MoveHours { get; set; }

        [Required]
        [StringLength(8)]
        public string JCDept { get; set; }

        public decimal QueHours { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        public decimal ProdBurRate { get; set; }

        public decimal ProdLabRate { get; set; }

        public decimal SetupBurRate { get; set; }

        public decimal SetupLabRate { get; set; }

        public decimal QProdBurRate { get; set; }

        public decimal QProdLabRate { get; set; }

        public decimal QSetupBurRate { get; set; }

        public decimal QSetupLabRate { get; set; }

        public bool SplitBurden { get; set; }

        public decimal ProdCrewSize { get; set; }

        public decimal SetupCrewSize { get; set; }

        [Required]
        [StringLength(5)]
        public string OpStdID { get; set; }

        public int ReloadNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ReloadStatus { get; set; }

        public decimal DailyCapacity1 { get; set; }

        public decimal DailyCapacity2 { get; set; }

        public decimal DailyCapacity3 { get; set; }

        public decimal DailyCapacity4 { get; set; }

        public decimal DailyCapacity5 { get; set; }

        public decimal DailyCapacity6 { get; set; }

        public decimal DailyCapacity7 { get; set; }

        [Required]
        [StringLength(8)]
        public string QBurdenType { get; set; }

        public bool BurdenEQLabor { get; set; }

        public bool SplitOperations { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceType { get; set; }

        [Required]
        [StringLength(8)]
        public string InputWhse { get; set; }

        [Required]
        [StringLength(10)]
        public string InputBinNum { get; set; }

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

        public bool InformOverload { get; set; }

        public decimal MinOverloadPerc { get; set; }

        [Required]
        [StringLength(8)]
        public string BackflushEmpID { get; set; }

        public bool SubContract { get; set; }

        public bool AutoMove { get; set; }

        public bool UseEstimates { get; set; }

        public decimal DailyProdQty { get; set; }

        public decimal BillLaborRate { get; set; }

        public decimal DailyProdRate { get; set; }

        public bool Location { get; set; }

        public bool DistributeLoad { get; set; }

        public bool TrkProdAct { get; set; }

        public bool SetShopLoad { get; set; }

        public decimal TAKTValue { get; set; }

        public bool UseCalendarForMove { get; set; }

        public bool UseCalendarForQueue { get; set; }

        [Required]
        [StringLength(500)]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string JDFDevice { get; set; }

        [Required]
        [StringLength(50)]
        public string JDFOperation { get; set; }
        public int TenantId { get; set; }
    }
}
