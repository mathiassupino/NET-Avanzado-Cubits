using Microsoft.AspNetCore.Mvc;
using NET.Avanzado.Models;

namespace NET.Avanzado.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var user = new UserViewModel
            {
                Name = "Mathias Supino",
                Email = "mathisupino@gmail.com"
            };

            return View(user);
        }
    }
}