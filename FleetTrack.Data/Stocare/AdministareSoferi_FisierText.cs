using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FleetTrack.Domain;

namespace FleetTrack.Data.StocareDate
{
    public class AdministratorSoferi_FisierText
    {
        private string fisier;

        public AdministratorSoferi_FisierText(string fisier)
        {
            this.fisier = fisier;
        }

        public void Adauga(Sofer s)
        {
            using (StreamWriter sw = new StreamWriter(fisier, true))
            {
                sw.WriteLine($"{s.Nume};{s.Prenume};{s.PermisConducere};{s.ExperientaAni}");
            }
        }

        public List<Sofer> GetAll()
        {
            List<Sofer> lista = new List<Sofer>();

            if (!File.Exists(fisier))
                return lista;

            foreach (var linie in File.ReadAllLines(fisier))
            {
                var p = linie.Split(';');

                lista.Add(new Sofer(p[0], p[1], p[2], int.Parse(p[3])));
            }

            return lista;
        }
    }
}