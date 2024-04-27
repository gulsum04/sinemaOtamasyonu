using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sinemaOtamasyonu.Data;
using sinemaOtamasyonu.Data.Services;

namespace sinemaOtamasyonu.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
           // var allActors = await _context.Actors.ToListAsync();
            var allActors = await _service.GetAll();
            return View(allActors);
        }
    }
}
