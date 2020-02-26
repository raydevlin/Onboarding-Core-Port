using Microsoft.AspNetCore.Mvc;
using OnboardingCorePort.Data;
using Onboarding_CorePort.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Controllers
{
    public class FeedbackFormViewComponent : ViewComponent
    {

        private readonly OnboardingContext _db = new OnboardingContext();

        public FeedbackFormViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FeedbackViewModel feedbackViewModel = new FeedbackViewModel();
            feedbackViewModel.Categories = _db.GetCategories();
            feedbackViewModel.LevelSatisfied = _db.LevelsSatisfied.ToList();
            feedbackViewModel.Comment = "";
            return View(feedbackViewModel);
        }

    }
}
