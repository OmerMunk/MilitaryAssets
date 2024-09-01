namespace assetsApi.service
{
    public class VehicleService
    {

        public async Task<bool> UpdateHandler(int id, Vehicle vehicle)
        {
            bool result = false;
          string res = _service.vehicle(id, vehicle);
           if (res == "status200")
            {
                result = true;
            }
           return result;
        }
    }
}
