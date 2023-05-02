using _1MayTaskHome.DataContex;
using _1MayTaskHome.Models;
using _1MayTaskHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1MayTaskHome.Controllers
{
    public class HomeController : Controller
    {
        private EvaraDbContext _dbContext;
        public HomeController(EvaraDbContext evardbcontex)
        {
            _dbContext = evardbcontex;
        }

        public List<Product> Products { get; private set; }
        public List<Slider> Sliders { get; private set; }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _dbContext.Sliders.ToListAsync();
            List<Product> products = await _dbContext.Products.ToListAsync();
            HomeVM homeVM = new HomeVM();
            {
                Products = products;
                Sliders=sliders;
            }
            return View(sliders);
        }
    }
}
