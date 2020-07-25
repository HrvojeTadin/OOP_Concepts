using ServisVozila.Interfaces;

namespace ServisVozila.Models
{
    public abstract class Vozilo : IVozilo
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual bool MozeLetjeti() => false;
        public virtual bool MozeSeTerenskiVoziti() => false;
     }
}
