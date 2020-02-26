using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onboarding_CorePort.ViewModels
{
    public class UserViewModel
    {
        public bool PrivacyChecked { get; set; }
        public bool NeuedaIntroChecked { get; set; }
        public bool InformationSecurityChecked { get; set; }
        public bool DAERAIntroChecked { get; set; }
        public bool HealthAndSafetyChecked { get; set; }
        public bool CompanyRelationsChecked { get; set; }
        public bool OrganisationStructureChecked { get; set; }
        public bool IsAdmin { get; set; }
    }
}
