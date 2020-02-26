using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class Layout
    {

        [Key]
        public int LayoutID { get; set; }

        public string Name { get; set; }

        public string Framework { get; set; }

        public ICollection<Component> Components { get; set; }

    }
}
