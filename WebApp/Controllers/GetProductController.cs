using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    // SRP därför att den här controllern gör bara en sak.

    public class GetProductController : Controller
    {
        private readonly IProductService _service;
        
        public GetProductController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllAsync());
        }
    }
}
