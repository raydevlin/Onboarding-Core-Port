using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class Log
    {
        [Key]
        public int UserID { get; set; }
        public DateTime? NeuedaIntroduction { get; set; }
        public DateTime? DAERAIntroduction { get; set; }
        public DateTime? InformationSecurity { get; set; }
        public DateTime? HealthAndSafety { get; set; }
        public DateTime? Privacy { get; set; }
        public DateTime? OrganisationStructure { get; set; }
        public DateTime? NeuedaDAERARelationship { get; set; }

    }
}
