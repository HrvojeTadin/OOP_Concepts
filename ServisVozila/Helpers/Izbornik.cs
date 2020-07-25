using System;

namespace ServisVozila.Helpers
{
    public static class Izbornik
    {
        public static void PrikaziIzbornik()
        {
            Console.WriteLine("\n---------- Aplikacija za održavanje vozila ----------");
            Console.WriteLine("\nOdaberite opciju:\n");
            Console.WriteLine("0 - Izlaz");
            Console.WriteLine("1 - Sva vozila");
            Console.WriteLine("2 - Terenska vozila");
            Console.WriteLine("3 - Leteća vozila");
            Console.WriteLine("4 - Svi vozači");
            Console.WriteLine("5 - Terenski vozači");
            Console.WriteLine("6 - Piloti");
            Console.WriteLine("7 - Vozači jednog vozila");
            Console.Write("\nOdabir: ");
        }

        public static void PokreniIzbornik()
        {
            int odgovor = 1;
            do
            {
                PrikaziIzbornik();

                try
                {
                    odgovor = int.Parse(Console.ReadLine());
                    switch (odgovor)
                    {
                        case (int)IzbornikEnum.Izlaz:
                            Console.WriteLine("\nHvala što ste koristili ovu aplikaciju!");
                            break;
                        case (int)IzbornikEnum.SvaVozila:
                            Console.WriteLine("\nSva vozila: ");
                            Repozitorij.VratiSvaVozila().ForEach(x => Console.WriteLine($"Id: {x.Id}, Naziv: {x.Naziv}"));
                            break;
                        case (int)IzbornikEnum.TerenskaVozila:
                            Console.WriteLine("\nTerenska vozila: ");
                            Repozitorij.VratiTerenskaVozila().ForEach(x => Console.WriteLine($"Id: {x.Id}, Naziv: {x.Naziv} "));
                            break;
                        case (int)IzbornikEnum.LetecaVozila:
                            Console.WriteLine("\nVozila koja mogu letjeti: ");
                            Repozitorij.VratiLetecaVozila().ForEach(x => Console.WriteLine($"Id: {x.Id}, Naziv: {x.Naziv}"));
                            break;
                        case (int)IzbornikEnum.SviVozaci:
                            Console.WriteLine("\nSvi vozaci: ");
                            Repozitorij.VratiSveVozace().ForEach(x => Console.WriteLine($"Id: {x.Id}, Ime: {x.Ime}, Prezime: {x.Prezime}"));
                            break;
                        case (int)IzbornikEnum.TerenskiVozaci:
                            Console.WriteLine("\nVozači terenskih vozila: ");
                            Repozitorij.VratiSveTerenskeVozace().ForEach(x => Console.WriteLine($"Id: {x.Id}, Ime: {x.Ime}, Prezime: {x.Prezime}"));
                            break;
                        case (int)IzbornikEnum.Piloti:
                            Console.WriteLine("\nPiloti: ");
                            Repozitorij.VratiPilote().ForEach(x => Console.WriteLine($"Id: {x.Id}, Ime: {x.Ime}, Prezime: {x.Prezime}"));
                            break;
                        case (int)IzbornikEnum.VozaciJednogVozila:
                            Console.WriteLine("\nVozači jednog vozila: ");
                            Repozitorij.VratiVozaceJednogVozila().ForEach(x => Console.WriteLine($"Id: {x.Id}, Ime: {x.Ime}, Prezime: {x.Prezime}"));
                            break;
                        default:
                            Console.WriteLine("\nUnijeli ste nepodržan unos. Pokušajte ponovno.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nUnijeli ste nepodržan unos. Pokušajte ponovno.");
                }
            } while (odgovor != 0);
        }
    }

    public enum IzbornikEnum
    {
        Izlaz,
        SvaVozila,
        TerenskaVozila,
        LetecaVozila,
        SviVozaci,
        TerenskiVozaci,
        Piloti,
        VozaciJednogVozila
    }
}
