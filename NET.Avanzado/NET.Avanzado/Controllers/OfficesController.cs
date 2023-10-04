using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace NET.Avanzado.Controllers
{
    [Route("offices")]
    public class OfficesController : Controller
    {
        [Route("")]
        public async Task<ActionResult> Index()
        {
            var officeService = new ServiceClient();

            var office = await officeService.GetOfficeDataAsync();

            return View(office);
        }
    }
}