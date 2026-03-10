namespace FleetTrack
{
    public class Vehicul
    {
        public string NumarInmatriculare { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public double CapacitateIncarcare { get; set; }
        public bool Disponibil { get; set; }

        public Vehicul(string numarInmatriculare, string marca, string model, double capacitateIncarcare)
        {
            NumarInmatriculare = numarInmatriculare;
            Marca = marca;
            Model = model;
            CapacitateIncarcare = capacitateIncarcare;
            Disponibil = true;
        }
    }
}