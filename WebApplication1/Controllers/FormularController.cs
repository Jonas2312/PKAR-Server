using Microsoft.AspNetCore.Mvc;
using PKAR.Domain;

namespace WebApplication1.Controllers
{
    public class FormularController : Controller
    {
        public IUserModel UserModel { get; set; }

        public FormularController()
        {
            UserModel = new UserModel();
        }

        public IActionResult FormularPage1()
        {
            Console.WriteLine("Page1");
            ViewBag.firstNameTextBox = "abc";
            return View();
        }

        public IActionResult FormularPage2()
        {
            UserModel.FirstName = Request.Form["FirstNameTextBox"];
            UserModel.LastName = Request.Form["LastNameTextBox"];
            UserModel.Versicherungsart = Request.Form["Versicherungsart"];
            Console.WriteLine(UserModel.ToString());
            return View();
        }

    }
}
