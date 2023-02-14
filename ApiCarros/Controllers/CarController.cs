using ApiCarros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace ApiCarros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarModel _Cars;


        [HttpGet]
        [Route("Cars")]
        public  IActionResult CarList()
        {
            
            List<CarModel> cars = new List<CarModel> {_Cars};
            var ListJson = System.IO.File.ReadAllText(@"ImportData/Cars.json");
            cars = JsonSerializer.Deserialize<List<CarModel>>(ListJson);
            return Ok(cars);
        }
    }
}
