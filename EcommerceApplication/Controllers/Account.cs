using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EcommerceApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceApplication.Controllers
{
    public class Account : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<Customer> _signInManager;
        public Account(UserManager<Customer> userManager,RoleManager<ApplicationRole> roleManager, SignInManager<Customer> signManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }


    }
}
