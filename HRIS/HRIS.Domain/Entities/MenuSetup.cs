using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRIS.Domain.Entities
{
    public class MenuSetup:BaseEntity
    {
        [Key]
        public int MenuIdentity { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string ParentMenuId { get; set; }
        public string RoleId { get; set; }
        public string MenuFileName { get; set; }
        public string MenuUrl { get; set; }
        public string ImgClass { get; set; }
        public string InstitutionCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string SectionName { get; set; }
        public string SectionImgClass { get; set; }

    }
}
