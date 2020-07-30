using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zenxu.Interfaces;
using zenxu.Models;

namespace zenxu.Controllers
{
    
    public class PropertiesController : Controller
    {
        private readonly IPropertyService _property;

        public PropertiesController(IPropertyService property)
        {
            _property = property;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var properties = _property.GetAllProperties();
            return View(properties);
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PropertyModel model)
        {
            if(!ModelState.IsValid) return View();

            await _property.Add(model);

            return RedirectToAction("Index");
        }
        
    }
}