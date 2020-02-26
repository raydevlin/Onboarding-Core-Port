using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class Page
    {

        [Key]
        public int PageID { get; set; }

        public string Title { get; set; }

        public int LayoutID { get; set; }
        public Layout Layout { get; set; }

    }
}
