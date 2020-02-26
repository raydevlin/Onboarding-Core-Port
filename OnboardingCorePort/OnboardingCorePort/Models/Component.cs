using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class Component
    {

        [Key]
        public int ComponentID { get; set; }

        public string Content { get; set; }

        public string Tag { get; set; }

        public Layout Layout { get; set; }

    }
}
