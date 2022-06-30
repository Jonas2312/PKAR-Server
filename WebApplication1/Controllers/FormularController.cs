using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PKAR.Domain;
using PKAR.WebApplication.Extensions;

namespace PKAR.WebApplication.Controllers
{
    public class FormularController : Controller
    {
        const string UserModelKey = "_UserModel";

        public FormularController()
        {
            
        }

        public IActionResult FormularPage1()
        {            
            HttpContext.Session.Set<IUserModel>(UserModelKey, new UserModel());
            return View();
        }

        public IActionResult FormularPage2()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            userModel.FirstName = Request.Form["FirstNameTextBox"];
            userModel.LastName = Request.Form["LastNameTextBox"];
            userModel.Versicherungsart = Request.Form["Versicherungsart"];
            userModel.PhoneNumber = Request.Form["phoneNumberTextBox"];
            userModel.EmailAddress = Request.Form["emailAddressTextBox"];
            HttpContext.Session.Set<IUserModel>(UserModelKey, userModel);
            return View();
        }

        public IActionResult FormularPage3()
        {
            //UserModel.FirstName = Request.Form["FirstNameTextBox"];
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            userModel.WriteToFile();
            return View();
        }
    }
}
