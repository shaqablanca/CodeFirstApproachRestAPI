using System;
using EF7CodeFirst.Models;

namespace EF7CodeFirst.Services
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetAllVehicles();

        Task<Vehicle?> GetVehicleById(int id);

        Task<List<Vehicle>> AddVehicle(Vehicle vehicle);

        Task<List<Vehicle>?> UpdateVehicle(int id, Vehicle modify);

        Task<List<Vehicle>?> RemoveVehicle(int id);


    }
}

