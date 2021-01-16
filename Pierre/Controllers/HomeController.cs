using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pierre.Controllers
{
    public class HomeController: Controller
    {
        private readonly PierreContext _db;

        public HomeController(PierreContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            List<Flavor> flavors = _db.Flavors.ToList();
            List<Treat> treats = _db.Treats.ToList();
            model.Add("flavors", flavors);
            model.Add("treats", treats);
            return View(model);
        }
    }
}