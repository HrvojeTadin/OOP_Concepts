namespace ServisVozila.Models
{
    public class Pilot : Vozac
    {
        public override bool VoziHelikopter() => true;
        public override bool VoziZrakoplov() => true;
    }
}
