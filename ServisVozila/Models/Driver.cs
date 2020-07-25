using VehicleService.Interfaces;

namespace VehicleService.Models
{
    public abstract class Driver : IDriver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual bool DriveTenk() => false;
        public virtual bool DriveHelicopter() => false;
        public virtual bool DriveAirplane() => false;
    }
}
