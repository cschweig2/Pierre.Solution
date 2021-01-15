using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Pierre.Models;
using System.Threading.Tasks;
using Pierre.ViewModels;

namespace Pierre.Controllers
{
    public class AccountController : Controller
    {
        private readonly PierreContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierreContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}