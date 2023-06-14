using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF7CodeFirst.Models;
using EF7CodeFirst.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF7CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehichleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        public VehichleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> GetAllVehicles()
        {
            return  _vehicleService.GetAllVehicles();
        }
        [HttpGet("{id}")] 
	    public async Task<ActionResult<Vehicle>> GetVehicleById(int id)
        {
            var result = _vehicleService.GetVehicleById(id);
            if (result == null)
                return NotFound("Ooppss!! Vehicle not found!!");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Vehicle>>> AddVehicle(Vehicle vehicle)
        {
            var result = _vehicleService.AddVehicle(vehicle);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Vehicle>>> UpdateVehicle(int id,Vehicle modify)
        {
            var result = _vehicleService.UpdateVehicle(id, modify);
            if (result == null)
                return NotFound("Ooppss!! Vehicle not found!!");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Vehicle>>> RemoveVehicle(int id)
        {
            var result = _vehicleService.RemoveVehicle(id);
            if (result == null)
                return NotFound("Ooppss!! Vehicle not found!!");
            return Ok(result);
        }

    }
}
