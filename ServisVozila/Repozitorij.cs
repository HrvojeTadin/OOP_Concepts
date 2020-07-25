using ServisVozila.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServisVozila
{
    public static class Repozitorij
    {
        public static List<Vozac> SviVozaci { get; set; }
        public static List<Vozilo> SvaVozila { get; set; }

        static Repozitorij()
        {
            UnesiSvaVozila();
            UnesiSveVozace();
        }

        private static void UnesiSvaVozila()
        {
            SvaVozila = new List<Vozilo>() {
                new Tenk() { Id=11, Naziv="Tenk 11" },
                new Tenk() { Id=12, Naziv="Tenk 12" },
                new Helikopter() { Id=21, Naziv="Helikopter 21" },
                new Helikopter() { Id=22, Naziv="Helikopter 22" },
                new Zrakoplov() { Id=31, Naziv="Zrakoplov 31" },
                new Zrakoplov() { Id=32, Naziv="Zrakoplov 32" }
            };
        }

        private static void UnesiSveVozace()
        {
            SviVozaci = new List<Vozac>
            {
                new Pilot(){ Id=21, Ime="Henrik", Prezime="Andersen"},
                new Pilot(){Id=23, Ime="Edith", Prezime="Borg"},
                new TerenskiVozac(){Id=24, Ime="Espen", Prezime="Thor"},
                new TerenskiVozac(){Id=25, Ime="Markus", Prezime="Trulson"},
                new VozacJednogVozila(true,false,false){Id=26, Ime="Astrid", Prezime="Lund"},
                new VozacJednogVozila(false,true,false){Id=27, Ime="Hansel", Prezime="Nord"}
            };
        }

        public static List<Vozilo> VratiSvaVozila() => SvaVozila;
        public static List<Vozilo> VratiTerenskaVozila() => SvaVozila.Where(x => x.MozeSeTerenskiVoziti()).ToList();
        public static List<Vozilo> VratiLetecaVozila() => SvaVozila.Where(x => x.MozeLetjeti()).ToList();
        public static List<Vozac> VratiSveVozace() => SviVozaci;
        public static List<Vozac> VratiSveTerenskeVozace() => SviVozaci.Where(x => x.VoziTenk()).ToList();
        public static List<Vozac> VratiPilote() => SviVozaci.Where(x => x.VoziZrakoplov() || x.VoziHelikopter()).ToList();
        public static List<Vozac> VratiVozaceJednogVozila() => SviVozaci.Where(x => x is VozacJednogVozila).ToList();
    }
}
