using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FleetTrack.Domain;

namespace FleetTrack.Data.StocareDate
{
    public class AdministratorVehicule_FisierText
    {
        private string numeFisier;

        public AdministratorVehicule_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
        }

        public void Adauga(Vehicul v)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
            {
                sw.WriteLine($"{v.NumarInmatriculare};{v.Marca};{v.Model};{v.CapacitateIncarcare};{v.Culoare};{v.Optiuni}");
            }
        }

        public List<Vehicul> GetAll()
        {
            List<Vehicul> lista = new List<Vehicul>();

            if (!File.Exists(numeFisier))
                return lista;

            foreach (var linie in File.ReadAllLines(numeFisier))
            {
                var parts = linie.Split(';');

                Vehicul v = new Vehicul(
                    parts[0],
                    parts[1],
                    parts[2],
                    double.Parse(parts[3]),
                    (Culoare)Enum.Parse(typeof(Culoare), parts[4]),
                    (Optiuni)Enum.Parse(typeof(Optiuni), parts[5])
                );

                lista.Add(v);
            }

            return lista;
        }

        public Vehicul Cauta(string nr)
        {
            return GetAll().FirstOrDefault(v => v.NumarInmatriculare == nr);
        }
        public void Modifica(Vehicul vehiculNou)
        {
            var lista = GetAll();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NumarInmatriculare == vehiculNou.NumarInmatriculare)
                {
                    lista[i] = vehiculNou;
                }
            }

            using (StreamWriter sw = new StreamWriter(numeFisier, false))
            {
                foreach (var v in lista)
                {
                    sw.WriteLine($"{v.NumarInmatriculare};{v.Marca};{v.Model};{v.CapacitateIncarcare};{v.Culoare};{v.Optiuni}");
                }
            }
        }
        public Vehicul CautaDupaNumar(string nr)
        {
            return GetAll().FirstOrDefault(v => v.NumarInmatriculare == nr);
        }
    }
}