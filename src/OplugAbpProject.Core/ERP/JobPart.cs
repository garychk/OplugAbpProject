using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("JobPart")]
    public partial class JobPart : Entity<Guid>, IMustHaveTenant
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public int PartsPerOp { get; set; }

        public decimal PartQty { get; set; }

        public decimal StockQty { get; set; }

        public decimal ShippedQty { get; set; }

        public decimal ReceivedQty { get; set; }

        public decimal WIPQty { get; set; }

        public decimal QtyCompleted { get; set; }

        public decimal ReservedQty { get; set; }

        public decimal AllocatedQty900 { get; set; }

        public decimal PickingQty { get; set; }

        public decimal PickedQty { get; set; }

        public int LbrCostBase { get; set; }

        public int MtlCostBase { get; set; }

        public bool JobClosed { get; set; }

        public bool JobComplete { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public bool ShipDocReq { get; set; }

        public bool ShipDocAvail { get; set; }

        [Required]
        public string MtlList { get; set; }

        public bool PreventSugg { get; set; }
        public int TenantId { get; set; }
    }
}
