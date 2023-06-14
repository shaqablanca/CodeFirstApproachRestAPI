using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF7CodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF7CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehichleController : ControllerBase
    {
        private static List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle
                {   Id = 1,
                    VehicleType ="Aircraft",
                    Brand = "F-16",
                    Model = "Viper",
                    PurposeOfUsage = "Air Defence/Attack",
                    Company = "Lockheed Martin Corp",
                    CreationYear = 1976,
                    Country = "United States of America"
                },

                 new Vehicle
                {   Id = 2,
                    VehicleType ="Aircraft",
                    Brand = "Mirage",
                    Model = "MF2000",
                    PurposeOfUsage = "Air Defence/Attack",
                    Company = "Dassault Aviation SA",
                    CreationYear = 1984,
                    Country = "France"
                }

            };
        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> GetAllVehicles()
        {
	        return Ok(vehicles);
        }
        [HttpGet("{id}")] 
	    public async Task<ActionResult<Vehicle>> GetVehicleById(int id)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return NotFound("Ooppss!! This vehicle doesn't exist");
            return Ok(vehicle);
	    }

        [HttpPost]
        public async Task<ActionResult<List<Vehicle>>> AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return Ok(vehicles);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Vehicle>>> UpdateVehicle(int id,Vehicle modify)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return NotFound("Ooppss!! This vehicle doesn't exist");

            vehicle.Model = modify.Model;
            vehicle.Brand = modify.Brand;
            vehicle.PurposeOfUsage = modify.PurposeOfUsage;

            return Ok(vehicles);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Vehicle>>> RemoveVehicle(int id)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return NotFound("Ooppss!! This vehicle doesn't exist");
            vehicles.Remove(vehicle);
            return Ok(vehicles);
        }

    }
}
