using assetsApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace assetsApi.Models
{
    public class Vehicle
    {
        [Key]
        public Guid? Id { get; set; }
        public Guid UnitId { get; set; }
        public string Model { get; set; }
        public Status Status { get; set; }
        public string LicensePlate {  get; set; }
        public string type { get; set; }
    }
}
