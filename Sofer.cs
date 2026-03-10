using System;

namespace FleetTrack
{
    public class Sofer
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string PermisConducere { get; set; }
        public int ExperientaAni { get; set; }

        public Sofer(string nume, string prenume, string permisConducere, int experientaAni)
        {
            Nume = nume;
            Prenume = prenume;
            PermisConducere = permisConducere;
            ExperientaAni = experientaAni;
        }
    }
}