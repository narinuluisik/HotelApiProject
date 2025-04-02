using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class BookingAreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
