using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OplugAbpProject.CMS.Dto
{
    [AutoMapTo(typeof(Members))]
    public class CreateMembersDto
    {
        [MaxLength(500)]
        public string Photo { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string Province { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string District { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string QQ { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Fax { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(8)]
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        [MaxLength(50)]
        public string IDNum { get; set; }
        [MaxLength(20)]
        public string Zipcode { get; set; }
    }
}
