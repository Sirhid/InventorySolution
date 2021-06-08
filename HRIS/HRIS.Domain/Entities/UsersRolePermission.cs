﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRIS.Domain.Entities
{
    public class UsersRolePermission:BaseEntity
    {
        [Key]
        public int UserPermissionId { get; set; }
        public int MenuIdentity { get; set; }
        public string UserId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
