using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sinemaOtamasyonu.Data;
using sinemaOtamasyonu.Data.ViewModels;
using sinemaOtamasyonu.Models;

namespace sinemaOtamasyonu.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInmanager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInmanager, AppDbContext context)
        {
            _userManager= userManager;
            _signInmanager= signInmanager;
            _context= context;
        }
        public IActionResult Login() => View(new LoginVM());
      
    }
}
