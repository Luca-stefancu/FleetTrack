using System.Collections.Generic;
using System.Linq;
using FleetTrack.Domain;

namespace FleetTrack.Data
{
    public class AdministratorVehicule
    {
        private List<Vehicul> vehicule = new List<Vehicul>();

        public void Adauga(Vehicul v)
        {
            vehicule.Add(v);
        }

        public List<Vehicul> GetAll()
        {
            return vehicule;
        }

        public Vehicul CautaDupaNumar(string nr)
        {
            return vehicule.FirstOrDefault(v => v.NumarInmatriculare == nr);
        }
    }
}