using System;

namespace FleetTrack
{
    public class Cursa
    {
        public string OrasPlecare { get; set; }
        public string OrasDestinatie { get; set; }
        public double DistantaKm { get; set; }
        public DateTime DataPlecare { get; set; }
        public Vehicul VehiculAlocat { get; set; }
        public Sofer SoferAlocat { get; set; }

        public Cursa(string orasPlecare, string orasDestinatie, double distantaKm, DateTime dataPlecare, Vehicul vehicul, Sofer sofer)
        {
            OrasPlecare = orasPlecare;
            OrasDestinatie = orasDestinatie;
            DistantaKm = distantaKm;
            DataPlecare = dataPlecare;
            VehiculAlocat = vehicul;
            SoferAlocat = sofer;
        }
    }
}