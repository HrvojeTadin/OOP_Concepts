namespace ServisVozila.Models
{
    public class VozacJednogVozila : Vozac
    {
        public bool VozimTenk { get; set; }
        public bool VozimZrakoplov { get; set; }
        public bool VozimHelikopter { get; set; }

        public VozacJednogVozila(bool tenk, bool zrakoplov, bool helikopter)
        {
            VozimTenk = tenk;
            VozimZrakoplov = zrakoplov;
            VozimHelikopter = helikopter;
        }

        public override bool VoziTenk() => VozimTenk;
        public override bool VoziZrakoplov() => VozimZrakoplov;
        public override bool VoziHelikopter() => VozimHelikopter;

    }
}
