using VehicleService.Models;
using System.Collections.Generic;
using System.Linq;

namespace VehicleService
{
    public static class Repository
    {
        public static List<Driver> AllDrivers { get; set; }
        public static List<Vehicle> AllVehicles { get; set; }

        static Repository()
        {
            InsertAllVehicles();
            InsertAllDrivers();
        }

        private static void InsertAllVehicles()
        {
            AllVehicles = new List<Vehicle>() {
                new Tenk() { Id=11, Name="Tenk 11" },
                new Tenk() { Id=12, Name="Tenk 12" },
                new Helicopter() { Id=21, Name="Helicopter 21" },
                new Helicopter() { Id=22, Name="Helicopter 22" },
                new Airplane() { Id=31, Name="Airplane 31" },
                new Airplane() { Id=32, Name="Airplane 32" }
            };
        }

        private static void InsertAllDrivers()
        {
            AllDrivers = new List<Driver>
            {
                new Pilot(){ Id=21, Name="Henrik", Surname="Andersen"},
                new Pilot(){Id=23, Name="Edith", Surname="Borg"},
                new LandVehicleDriver(){Id=24, Name="Espen", Surname="Thor"},
                new LandVehicleDriver(){Id=25, Name="Markus", Surname="Trulson"},
                new OneVehicleDriver(true,false,false){Id=26, Name="Astrid", Surname="Lund"},
                new OneVehicleDriver(false,true,false){Id=27, Name="Hansel", Surname="Nord"}
            };
        }

        public static List<Vehicle> ReturnAllVehicles() => AllVehicles;
        public static List<Vehicle> ReturnLandVehicles() => AllVehicles.Where(x => x.ItCanBeDriveOnLand()).ToList();
        public static List<Vehicle> ReturnFlyingVehicles() => AllVehicles.Where(x => x.CanItFly()).ToList();
        public static List<Driver> ReturnAllDrivers() => AllDrivers;
        public static List<Driver> ReturnAllLandDrivers() => AllDrivers.Where(x => x.DriveTenk()).ToList();
        public static List<Driver> ReturnPilots() => AllDrivers.Where(x => x.DriveAirplane() || x.DriveHelicopter()).ToList();
        public static List<Driver> ReturnDriversOfOneVehicle() => AllDrivers.Where(x => x is OneVehicleDriver).ToList();
    }
}
