﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    class Role
    {
        [Key]

        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
