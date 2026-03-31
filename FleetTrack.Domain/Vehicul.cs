using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetTrack.Domain
{
    public class Vehicul
    {
        public string NumarInmatriculare { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public double CapacitateIncarcare { get; set; }
        public bool Disponibil { get; set; }
        public Culoare Culoare { get; set; }
        public Optiuni Optiuni { get; set; }

        public Vehicul(string nr, string marca, string model, double capacitate,
               Culoare culoare, Optiuni optiuni)
        {
            NumarInmatriculare = nr;
            Marca = marca;
            Model = model;
            CapacitateIncarcare = capacitate;
            Culoare = culoare;
            Optiuni = optiuni;
        }
    }
}