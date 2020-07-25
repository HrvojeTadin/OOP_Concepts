using ServisVozila.Interfaces;

namespace ServisVozila.Models
{
    public abstract class Vozac : IVozac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public virtual bool VoziTenk() => false;
        public virtual bool VoziHelikopter() => false;
        public virtual bool VoziZrakoplov() => false;
    }
}
