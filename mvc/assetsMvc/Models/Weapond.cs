using System.Xml.Linq;

namespace assetsMvc.Models
{
    public class Weapond
    {
        public Guid Id;
        public Guid PersonId;
        public Guid VehicleId;
        public Guid Unit;
        public string Name;
        public bool Status;
        public string SerialNumber;
        public int AmmunitionCount;
        public double Caliber;

    }
}
