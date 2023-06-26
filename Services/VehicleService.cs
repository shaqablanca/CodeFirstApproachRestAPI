using System;
using EF7CodeFirst.Data;
using EF7CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF7CodeFirst.Services
{
    public class VehicleService : IVehicleService
    {

        private readonly DataContext _context;

        public VehicleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Vehicle>> AddVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<List<Vehicle>> GetAllVehicles() 
        {
            var vehicles = await _context.Vehicles.ToListAsync();
            return vehicles;
        }

        public async Task<Vehicle?> GetVehicleById(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle is null)
                return null;
            return vehicle;
        }

        public async Task<List<Vehicle>?> RemoveVehicle(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle is null)
                return null;
            _context.Vehicles.Remove(vehicle);

            await _context.SaveChangesAsync();
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<List<Vehicle>?> UpdateVehicle(int id, Vehicle modify)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle is null)
                return null;

            vehicle.VehicleType = modify.VehicleType;
            vehicle.Model = modify.Model;
            vehicle.PurposeOfUsage = modify.PurposeOfUsage;
            vehicle.Brand = modify.Brand;
            vehicle.Company = modify.Company;
            vehicle.CreationYear = modify.CreationYear;
            vehicle.Company = modify.Company;

            await _context.SaveChangesAsync();

            return await _context.Vehicles.ToListAsync();
        }
    }
}

