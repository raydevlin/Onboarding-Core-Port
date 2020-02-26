using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class LevelSatisfied
    {
        [Key]
        public int LevelSatisfiedID { get; set; }

        public string LevelSatisfiedName { get; set; }

    }
}
