using CascadingDropdown.Data;
using Microsoft.AspNetCore.Mvc;

namespace CascadingDropdown.Controllers
{
    public class DropDownController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DropDownController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Dropdown()
        {
            return View();
        }

        public JsonResult Country()
        {
            var cnt = _context.Countries.ToList();
            return new JsonResult(cnt);
        }
        public JsonResult State(int id)
        {
            var st = _context.States.Where(e=> e.Country.Id == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult City(int id)
        {
            var ct = _context.Cities.Where(e => e.State.Id == id).ToList();
            return new JsonResult(ct);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
