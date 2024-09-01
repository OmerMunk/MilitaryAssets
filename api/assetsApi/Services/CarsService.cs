using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel;
using System.Reflection;

namespace assetsApi.Services
{
    public class CarsService
    {
        private readonly DbCondtext dbContext {  get; set; }

        public CarsService(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // get all vehicle
        public async Task<List<Vehicle>> GetAll()
        {
            return await this.dbContext.Vehicles.ToListAsync();
        }

        // get one vehicle
        public async Task<Vehicle> GetOneVehicle(Guid id)
        {
            var vehicle = await this.dbContext.Vehicles.FindAsync(id);
            if (vehicle == null) return null;
            return vehicle;
        }

        // get license's vehicle
        public async Task<List<Vehicle>> GetLicenseVehicle(string License)
        {
            var result = await this.dbContext.Vehicles.ToListAsync();
            List<Vehicle> vehicles = new List<Vehicle>();
            foreach (var item in result)
            {
                if (item.LicensePlate == License)
                {
                    vehicles.Add(item);
                }
            }
            return vehicles;
        }

        // get model's vehicle
        public async Task<List<Vehicle>> GetModelVehicle(string Model)
        {
            var result = await this.dbContext.Vehicles.ToListAsync();
            List<Vehicle> vehicles = new List<Vehicle>();
            foreach (var item in result)
            {
                if (item.Model == Model)
                {
                    vehicles.Add(item);
                }
            }
            return vehicles;
        }

        // get unit's vehicle
        public async Task<List<Vehicle>> GetUnitVehicle(string Unit)
        {
            var result = await this.dbContext.Vehicles.ToListAsync();
            List<Vehicle> vehicles = new List<Vehicle>();
            foreach (var item in result)
            {
                if (item.UnitId == Unit)
                {
                    vehicles.Add(item);
                }
            }
            return vehicles;
        }

        // create vehicle
        public async Task<Vehicle> CreateVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return null ;
            vehicle.Status = Status.Active;
            var result = await dbContext.Vehicles.AddAsync(vehicle);
            await dbContext.SaveChangesAsync();
            return vehicle;
        }

        // update vehicle
        public async Task<bool> UpdateVehicle(Vehicle NewVehicle)
        {
            var vehicle = await this.dbContext.Vehicles.FindAsync(NewVehicle.id);
            if (vehicle == null) return false;
            vehicle = NewVehicle;
            this.dbContext.Vehicles.Update(vehicle);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
