using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace assetsMvc
{
    public class CarService: BaseService;
    {

        private string _GetCarByLicensePlateUrl = $"http://localhost:5216/Cars/licensePlate";
        private string _GetCarsByModelUrl = $"http://localhost:5216/Cars/model";
        private string _GetCarsByUnitUrl = $"http://localhost:5216/Cars/unit/";


        // Get car by LicensePlate
        public async Task<Car> GetCarByLicensePlateUrl(string LicensePlate)
        {
            var response = await _httpClient.GetAsync(_GetCarByLicensePlateUrl + LicensePlate);
            return response;
        }

        // Get car by model
        public async Task<Car> GetCarsByModel(string Model)
        {
            var response = await _httpClient.GetAsync(_GetCarsByModelUrl + Model);
            return response;
        }

        // Get car by unit
        public async Task<car> GetCarsByUnit(string unit)
        {
            var response = await _httpClient.GetAsync(_GetCarsByUnitUrl + unit);
            return response;
        }
    }
}
