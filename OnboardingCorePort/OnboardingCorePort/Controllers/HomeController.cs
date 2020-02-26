using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OnboardingCorePort.Data;
using OnboardingCorePort.Models;
using Onboarding_CorePort.ViewModels;

namespace Onboarding_CorePort.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private OnboardingContext _db;

        public HomeController(ILogger<HomeController> logger)
        {
            _db = new OnboardingContext();
            _logger = logger;
        }

        public IActionResult Index()
        {
            UserViewModel userViewModel = new UserViewModel();
            FeedbackViewModel feedbackViewModel = new FeedbackViewModel();

            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Users.ToList();


            if (!dbCheck.Contains(dbUser))
            {

                User user = new User();
                user.Name = userClaims?.FindFirst("name")?.Value;
                user.Email = userClaims?.FindFirst("preferred_username")?.Value;
                user.Subject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                user.IsAdmin = false;
                Log log = new Log();
                log.UserID = user.UserID;

                User dbUserMatch = _db.Users.Find(user.UserID);
                if (dbUserMatch == null)
                {
                    if (ModelState.IsValid)
                    {

                        _db.Users.Add(user);
                        _db.Logs.Add(log);
                        _db.SaveChanges();

                    }

                }

            }

            var dbUserCheck = _db.Users.First(u => u.Subject == userClaimSubject);

            userViewModel.PrivacyChecked = CheckPrivacy().Value;
            userViewModel.NeuedaIntroChecked = CheckNeuedaIntro().Value;
            userViewModel.DAERAIntroChecked = CheckDAERAIntro().Value;
            userViewModel.InformationSecurityChecked = CheckInformationSecurity().Value;
            userViewModel.HealthAndSafetyChecked = CheckHealthAndSafety().Value;
            userViewModel.CompanyRelationsChecked = CheckCompanyRelations().Value;
            userViewModel.OrganisationStructureChecked = CheckOrganisationStructure().Value;
            userViewModel.IsAdmin = dbUserCheck.IsAdmin;



            ViewBag.Name = userClaims?.FindFirst("name")?.Value;

            return View(userViewModel);
        }

        public bool? CheckPrivacy()
        {
            System.Diagnostics.Debug.WriteLine("Checking Privacy");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.Privacy != null;
        }

        public bool? CheckNeuedaIntro()
        {
            System.Diagnostics.Debug.WriteLine("Checking Neueda Intro");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.NeuedaIntroduction != null;
        }

        public bool? CheckInformationSecurity()
        {
            System.Diagnostics.Debug.WriteLine("Checking Information Security");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.InformationSecurity != null;
        }

        public bool? CheckDAERAIntro()
        {
            System.Diagnostics.Debug.WriteLine("Checking DAERA Intro");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.DAERAIntroduction != null;
        }

        public bool? CheckHealthAndSafety()
        {
            System.Diagnostics.Debug.WriteLine("Checking Health and Safety");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.HealthAndSafety != null;
        }

        public bool? CheckCompanyRelations()
        {
            System.Diagnostics.Debug.WriteLine("Checking Company Relations");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.NeuedaDAERARelationship != null;
        }

        public bool? CheckOrganisationStructure()
        {
            System.Diagnostics.Debug.WriteLine("Checking Organisation Structure");
            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userClaimSubject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var dbUser = _db.Set<User>().Where(u => u.Subject == userClaimSubject).FirstOrDefault();
            var dbCheck = _db.Set<Log>().Where(l => l.UserID == dbUser.UserID).FirstOrDefault();

            return dbCheck.OrganisationStructure != null;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
