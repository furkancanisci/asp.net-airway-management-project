using Microsoft.AspNetCore.Mvc;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AirportsController : Controller
    {
        private readonly AirportsDbContext _context;

        public AirportsController(AirportsDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var airports = _context.Airports.ToList();
            List<AirportsViewModel> airportList = new List<AirportsViewModel>();

            foreach (var airport in airports)
            {
                var AirportsViewModel = new AirportsViewModel()
                {
                    AirportID = airport.AirportID,
                    AirportName = airport.AirportName,
                    Location = airport.Location,
                };
                airportList.Add(AirportsViewModel);
            }

            return View(airportList);


        }
    }
}
