using System;
using EF7CodeFirst.Models;

namespace EF7CodeFirst.Services
{
	public interface IVehicleService
	{
        List<Vehicle> GetAllVehicles();

        Vehicle? GetVehicleById(int id);

        List<Vehicle> AddVehicle(Vehicle vehicle);

        List<Vehicle>? UpdateVehicle(int id, Vehicle modify);

        List<Vehicle>? RemoveVehicle(int id);


    }
}

