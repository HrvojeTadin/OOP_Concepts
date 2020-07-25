using VehicleService.Interfaces;

namespace VehicleService.Models
{
    public abstract class Vehicle : IVehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual bool CanItFly() => false;
        public virtual bool ItCanBeDriveOnLand() => false;
     }
}
