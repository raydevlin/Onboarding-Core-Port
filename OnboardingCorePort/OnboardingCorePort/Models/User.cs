﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class User
    {

        [Key]
        public int UserID { get; set; }
        
        public string Name { get; set; }
        
        public string Subject { get; set; }
        
        public string Email { get; set; }

        public bool IsAdmin { get; set; }

    }
}
