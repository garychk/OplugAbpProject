using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("RMAHead")]
    public partial class RMAHead : Entity<Guid>, IMustHaveTenant
    {
        public bool OpenRMA { get; set; }

        [StringLength(8)]
        public string Company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RMANum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RMADate { get; set; }

        public int CustNum { get; set; }

        [Required]
        [StringLength(15)]
        public string DebitMemoRef { get; set; }

        [Required]
        [StringLength(16)]
        public string CLCallNum { get; set; }

        [Required]
        [StringLength(20)]
        public string XRefRMANumber { get; set; }

        public int HDCaseNum { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public int ConNum { get; set; }

        public bool AutoPrintReady { get; set; }

        public int BTCustNum { get; set; }

        public bool UseOTS { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress3 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSZIP { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSResaleID { get; set; }

        [Required]
        [StringLength(4)]
        public string OTSTaxRegionCode { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }

        public int ShipToCustNum { get; set; }

        public int InvoiceNum { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string RetInvoiceNum { get; set; }

        [Required]
        [StringLength(10)]
        public string ECCRMANum { get; set; }

        [Required]
        [StringLength(255)]
        public string ECCCustRef { get; set; }

        public bool DocumentPrinted { get; set; }

        [Required]
        public string RMAComment { get; set; }

        [Required]
        public string WebComment { get; set; }
        public int TenantId { get; set; }
    }
}
