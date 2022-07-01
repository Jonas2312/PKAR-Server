using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PKAR.AnamneseFormular.Domain;
using PKAR.AnamneseFormular.WebApplication.Extensions;

namespace PKAR.AnamneseFormular.WebApplication.Controllers
{
    public class FormularController : Controller
    {
        const string UserModelKey = "_UserModel";

        public FormularController()
        {
            
        }

        public IActionResult FormularPage1()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            if (userModel == null)
            {
                userModel = new UserModel();
                HttpContext.Session.Set<IUserModel>(UserModelKey, userModel);
            }
            ViewBag.UserModel = userModel;
            return View();
        }

        public IActionResult FormularPage2()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey); 
            if (userModel == null)
                return View();
            if(Request.HasFormContentType == true && Request.Form.ContainsKey("FirstNameTextBox"))
            {
                userModel.FirstName = Request.Form["FirstNameTextBox"];
                userModel.LastName = Request.Form["LastNameTextBox"];
                userModel.Versicherungsart = Request.Form["Versicherungsart"];
                userModel.PhoneNumber = Request.Form["phoneNumberTextBox"];
                userModel.EmailAddress = Request.Form["emailAddressTextBox"];
            }
            HttpContext.Session.Set<IUserModel>(UserModelKey, userModel);
            return View();
        }

        public IActionResult FormularPage3()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            if(userModel == null)
                return View();

            if (Request.HasFormContentType == true && Request.Form.ContainsKey("warumKommenSieTextBox"))
            {
                userModel.WarumKommenSie = Request.Form["warumKommenSieTextBox"];
            }
            return View();
        }

        public IActionResult FormularPage4()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            if (userModel == null)
                return View();
            
            if (Request.HasFormContentType == true && Request.Form.ContainsKey("WieHaeufigPeriode"))
            {
                userModel.PeriodeAlle4Wochen = Request.Form["WieHaeufigPeriode"] == "Alle4Wochen";
                userModel.PeriodeDasLetzteMal = Request.Form["dasLetzteMalSeit"];
            }
            return View();
        }

        public IActionResult FormularPage5()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            if (userModel == null)
                return View();
            /*
            if (Request.HasFormContentType == true && Request.Form.ContainsKey("warumKommenSieTextBox"))
            {
                userModel.WarumKommenSie = Request.Form["warumKommenSieTextBox"];
            }*/
            return View();
        }

        public IActionResult FormularPageFinal()
        {
            var userModel = HttpContext.Session.Get<IUserModel>(UserModelKey);
            if (userModel == null)
                return View();

            userModel.WriteToFile(ServerVariables.Name);
            return View();
        }
    }
}
