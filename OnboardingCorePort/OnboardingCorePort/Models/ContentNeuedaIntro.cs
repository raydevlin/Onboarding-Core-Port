using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
    public class ContentNeuedaIntro
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string TopTextBox { get; set; }
        public string TopImage { get; set; }
        public string BottomImage { get; set; }
        public string BottomTextLeft { get; set; }
        public string BottomTextRight { get; set; }
        public System.DateTime UpdatedAt { get; set; }

    }
}
