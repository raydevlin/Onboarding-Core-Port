using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class Content
    {

        public string PageIdKey { get; set; }
        public string PageSectionKey { get; set; }
        public string SectionContent { get; set; }
        public string ContentDescription { get; set; }
        public string ContentType { get; set; }
        public DateTime Updated { get; set; }

    }
}
