using OnboardingCorePort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onboarding_CorePort.ViewModels
{
    public class FeedbackViewModel
    {
        public UserFeedback UserFeedback { get; set; }
        public List<Category> Categories { get; set; }
        public List<LevelSatisfied> LevelSatisfied { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
    }

}
