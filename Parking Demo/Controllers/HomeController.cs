using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

using Parking_Demo.Models;

namespace Parking_Demo.Controllers
{
    public class ParkingSpot
    {
        public string Id { get; set; }

        public bool Occupied { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ParkingSpot[] parkingSpot = {
                new ParkingSpot() {
                    Id = "A1",
                    Occupied = true,
                },
            new ParkingSpot() {
                    Id = "A2",
                    Occupied = false,
                },new ParkingSpot() {
                    Id = "A3",
                    Occupied = false,
                },new ParkingSpot() {
                    Id = "A4",
                    Occupied = false,
                }};

            return View(parkingSpot);
        }

        [HttpPost]
        public IActionResult Index(RequestInputModel input)
        {
            ParkingSpot[] parkingSpot = {
                new ParkingSpot() {
                    Id = "A1",
                    Occupied = true,
                },
            new ParkingSpot() {
                    Id = "A2",
                    Occupied = false,
                },new ParkingSpot() {
                    Id = "A3",
                    Occupied = false,
                },new ParkingSpot() {
                    Id = "A4",
                    Occupied = false,
                }};

            return View(parkingSpot);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
