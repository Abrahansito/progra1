using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROYECTO_WEB.Models;


namespace PROYECTO_WEB.Controllers
{
  
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public CustomerController(ILogger<CustomerController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }
        

        public IActionResult Index()
        {
            var userName = _userManager.GetUserName(User);
            Customer customer = new Customer();
            customer.Username = userName;   
            return View(customer);
        }

        [HttpPost]
        public IActionResult Registrar(Customer customer)
        {
            _logger.LogInformation("RegistrarInfo {1}", customer);   
            if (ModelState.IsValid)
            {
                ViewData["message"] = "Se registro los datos del cliente correctamente";
            }
            return View("Index");
        }
        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}