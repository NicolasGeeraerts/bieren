using BierenApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BierenApplication.Controllers
{
    public class BierController : Controller
    {
        public IActionResult Index()
        {
            var bieren = new List<Bier>();
            bieren.Add(new Bier { Id = 1, Naam = "Romy pils", Alcohol = 5F });
            bieren.Add(new Bier { Id = 2, Naam = "Kasteelbier", Alcohol = 12F });
            bieren.Add(new Bier { Id = 3, Naam = "Maes radler", Alcohol = 0F });
            return View(bieren);
        }
    }
}
