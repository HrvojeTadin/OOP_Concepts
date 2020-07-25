namespace VehicleService.Models
{
    public class OneVehicleDriver : Driver
    {
        public bool DoesItDriveTenk { get; set; }
        public bool DoesItDriveAirplane { get; set; }
        public bool DoesItDriveHelicopter { get; set; }

        public OneVehicleDriver(bool tenk, bool Airplane, bool Helicopter)
        {
            DoesItDriveTenk = tenk;
            DoesItDriveAirplane = Airplane;
            DoesItDriveHelicopter = Helicopter;
        }

        public override bool DriveTenk() => DoesItDriveTenk;
        public override bool DriveAirplane() => DoesItDriveAirplane;
        public override bool DriveHelicopter() => DoesItDriveHelicopter;

    }
}
