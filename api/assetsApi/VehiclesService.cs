namespace assetsApi
{
    public class VehiclesService
    {
        public bool IsCreated(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                if (vehicle.Model != null)
                {

                    if (vehicle.LicensePlate != null && vehicle.LicensePlate.Length > 8)
                    {
                        if (vehicle.Type != null && vehicle.Type.Length > 2)
                        {
                            vehicle.Status = Status.Active;
                            //Here I need to know the names of the services to send it to him
                            return true;
                        } else { return false; }
                    } else { return false; }
                } else { return false; }
            } else { return false; }
        }
    }
}
