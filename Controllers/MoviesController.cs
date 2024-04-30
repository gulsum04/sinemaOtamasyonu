using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sinemaOtamasyonu.Data;
using sinemaOtamasyonu.Data.Services;

namespace sinemaOtamasyonu.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n=>n.Cinema);
            return View(allMovies);
        }
        //get:movies:details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //get/movies/create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our store";
            ViewBag.Description = "This is store description";
            return View();
        }

    }
}
