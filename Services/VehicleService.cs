using System;
using EF7CodeFirst.Data;
using EF7CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF7CodeFirst.Services
{
    public class VehicleService : IVehicleService
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

        private readonly DataContext _context;

        public VehicleService(DataContext context)
        {
            _context = context;
        }

        public List<Vehicle> AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicles;
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            var vehicles = await _context.Vehicles.ToListAsync();
            return vehicles;
        }

        public Vehicle? GetVehicleById(int id)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return null;
            return vehicle;
        }

        public List<Vehicle>? RemoveVehicle(int id)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return null;
            vehicles.Remove(vehicle);
            return vehicles;
        }

        public List<Vehicle>? UpdateVehicle(int id, Vehicle modify)
        {
            var vehicle = vehicles.Find(x => x.Id == id);
            if (vehicle is null)
                return null;

            vehicle.VehicleType = modify.VehicleType;
            vehicle.Model = modify.Model;
            vehicle.PurposeOfUsage = modify.PurposeOfUsage;
            vehicle.Brand = modify.Brand;
            vehicle.Company = modify.Company;
            vehicle.CreationYear = modify.CreationYear;
            vehicle.Company = modify.Company;

            return vehicles;
        }
    }
}

