namespace VehicleService.Models
{
    public class Pilot : Driver
    {
        public override bool DriveHelicopter() => true;
        public override bool DriveAirplane() => true;
    }
}
