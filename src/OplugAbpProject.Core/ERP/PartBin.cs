using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("PartBin")]
    public partial class PartBin : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [StringLength(50)]
        public string PartNum { get; set; }

        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [StringLength(10)]
        public string BinNum { get; set; }

        public decimal OnhandQty { get; set; }

        [StringLength(30)]
        public string LotNum { get; set; }

        [StringLength(6)]
        public string DimCode { get; set; }

        public decimal AllocatedQty { get; set; }

        public decimal SalesAllocatedQty { get; set; }

        public decimal SalesPickingQty { get; set; }

        public decimal SalesPickedQty { get; set; }

        public decimal JobAllocatedQty { get; set; }

        public decimal JobPickingQty { get; set; }

        public decimal JobPickedQty { get; set; }

        public decimal TFOrdAllocatedQty { get; set; }

        public decimal TFOrdPickingQty { get; set; }

        public decimal TFOrdPickedQty { get; set; }

        public decimal ShippingQty { get; set; }

        public decimal PackedQty { get; set; }

        [StringLength(12)]
        public string PCID { get; set; }
        public int TenantId { get; set; }
    }
}
