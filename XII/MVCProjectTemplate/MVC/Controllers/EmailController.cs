using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class EmailController : Controller
    {
        private IEmailSender emailSender;

        private UserManager<User> userManager;

        private User loggedUser;

        public EmailController(IEmailSender emailSender, UserManager<User> userManager)
        {
            this.emailSender = emailSender;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Send(string toAddress)
        {
            try
            {
                loggedUser = await HelperController.GetLoggedUser(userManager, this);

                if (string.IsNullOrEmpty(toAddress))
                {
                    toAddress = loggedUser.Email;
                }

                string token = await userManager.GenerateEmailConfirmationTokenAsync(loggedUser);
                var subject = "Registration Confirmation";
                var body = "http://localhost:44350/Email/Confirm/" + token;
                await emailSender.SendEmailAsync(toAddress, subject, body);

                return View((object)toAddress);
                //return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml", HelperController.Errors);
                //return RedirectToAction(HelperController.Error);
            }
        }

        public async Task<IActionResult> Confirm()
        {
            loggedUser = await HelperController.GetLoggedUser(userManager, this);

            RouteValueDictionary data = HttpContext.Request.RouteValues;
            string token = data["id"].ToString();
            IdentityResult result = await userManager.ConfirmEmailAsync(loggedUser, token);

            if (!result.Succeeded)
            {
                HelperController.AddErrors(result);
                return RedirectToAction(nameof(Error));
            }

            return View();
        }

        public async Task<IActionResult> Error()
        {
            return View(HelperController.Errors);
        }

    }
}
