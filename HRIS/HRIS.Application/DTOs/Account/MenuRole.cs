using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.DTOs.Account
{
  public class MenuRole
    {
        public int RoleID { get; set; }
        public int UserID { get; set; }
        public int MenuId { get; set; }
        public string  MenuName { get; set; }
        public int ParentMenuId { get; set; }
        public string   MenuFileName { get; set; }
        public string  MenuUrl { get; set; }
        public string  ImgClass { get; set; }
        public string  InstitutionCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SectionName { get; set; }
        public string SectionImgClass { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime DateUpdated { get; set; }
        public string DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string UpdatedBy { get; set; }
    }
}
