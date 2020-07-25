using System;

namespace VehicleService.Helpers
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n---------- Vehicle Maintenance Application ----------");
            Console.WriteLine("\nSelect an option:\n");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - All vehicles");
            Console.WriteLine("2 - Land vehicles");
            Console.WriteLine("3 - Flying vehicles");
            Console.WriteLine("4 - All drivers");
            Console.WriteLine("5 - Land vehicle drivers");
            Console.WriteLine("6 - Pilots");
            Console.WriteLine("7 - Drivers of one vehicle");
            Console.Write("\nSelection: ");
        }

        public static void StartMenu()
        {
            int answer = 1;
            do
            {
                ShowMenu();

                try
                {
                    answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case (int)MenuEnum.Exit:
                            Console.WriteLine("\nThanks for using this app!");
                            break;
                        case (int)MenuEnum.AllVehicles:
                            Console.WriteLine("\nAll Vehicles: ");
                            Repository.ReturnAllVehicles().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}"));
                            break;
                        case (int)MenuEnum.LandVehicles:
                            Console.WriteLine("\nLand Vehicles: ");
                            Repository.ReturnLandVehicles().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name} "));
                            break;
                        case (int)MenuEnum.FlyingVehicles:
                            Console.WriteLine("\nVehicles which can fly: ");
                            Repository.ReturnFlyingVehicles().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}"));
                            break;
                        case (int)MenuEnum.AllDrivers:
                            Console.WriteLine("\nAll Drivers: ");
                            Repository.ReturnAllDrivers().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Surname: {x.Surname}"));
                            break;
                        case (int)MenuEnum.LandVehicleDriveri:
                            Console.WriteLine("\nLand vehicle drivers: ");
                            Repository.ReturnAllLandDrivers().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Surname: {x.Surname}"));
                            break;
                        case (int)MenuEnum.Pilots:
                            Console.WriteLine("\nPilots: ");
                            Repository.ReturnPilots().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Surname: {x.Surname}"));
                            break;
                        case (int)MenuEnum.DriveriOfOneVehicle:
                            Console.WriteLine("\nDrivers of one vehicle: ");
                            Repository.ReturnDriversOfOneVehicle().ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Surname: {x.Surname}"));
                            break;
                        default:
                            Console.WriteLine("\nYou have entered an unsupported entry. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nYou have entered an unsupported entry. Please try again.");
                }
            } while (answer != 0);
        }
    }

    public enum MenuEnum
    {
        Exit,
        AllVehicles,
        LandVehicles,
        FlyingVehicles,
        AllDrivers,
        LandVehicleDriveri,
        Pilots,
        DriveriOfOneVehicle
    }
}
