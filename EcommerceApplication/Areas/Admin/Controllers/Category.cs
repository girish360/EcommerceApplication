using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EcommerceApplication.Services.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceApplication.Areas.Admin.Controllers
{
    public class Category : Controller
    {
        private readonly ICategory _categoryRepository;
        public Category(ICategory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
