using System;
using FleetTrack.Domain;
using FleetTrack.Data;
using FleetTrack.Data.StocareDate;
using System.Configuration;
namespace FleetTrack
{
    class Program
    {
        static void Main()
        {
            AdministratorVehicule_FisierText admin = new AdministratorVehicule_FisierText("vehicule.txt");
            AdministratorSoferi_FisierText adminSoferi = new AdministratorSoferi_FisierText("soferi.txt");
            int optiune;

            do
            {
                Console.WriteLine("\n--- VEHICULE ---");
                Console.WriteLine("1. Adauga vehicul");
                Console.WriteLine("2. Afiseaza vehicule");
                Console.WriteLine("3. Cauta vehicul dupa numar");

                Console.WriteLine("\n--- SOFERI ---");
                Console.WriteLine("4. Adauga sofer");
                Console.WriteLine("5. Afiseaza soferi");

                Console.WriteLine("0. Iesire");

                int.TryParse(Console.ReadLine(), out optiune);

                switch (optiune)
                {
                    case 1:
                        AdaugaVehicul(admin);
                        break;
                    case 2:
                        AfiseazaVehicule(admin);
                        break;
                    case 3:
                        CautaVehicul(admin);
                        break;
                    case 4:
                        AdaugaSofer(adminSoferi);
                        break;

                    case 5:
                        AfiseazaSoferi(adminSoferi);
                        break;
                }

            } while (optiune != 0);
        }

        static void AdaugaVehicul(AdministratorVehicule_FisierText admin)
        {
            Console.Write("Numar inmatriculare: ");
            string nr = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Capacitate incarcare: ");
            double capacitate;
            double.TryParse(Console.ReadLine(), out capacitate);

            Console.WriteLine("Culoare (0-Rosu, 1-Alb, 2-Negru, 3-Albastru): ");
            int culoareInput;
            int.TryParse(Console.ReadLine(), out culoareInput);
            Culoare culoare = (Culoare)culoareInput;

            Console.WriteLine("Optiuni (suma valorilor): ");
            Console.WriteLine("1-AerConditionat, 2-Navigatie, 4-CutieAutomata, 8-PilotAutomat");
            int optiuniInput;
            int.TryParse(Console.ReadLine(), out optiuniInput);
            Optiuni optiuni = (Optiuni)optiuniInput;

            Vehicul v = new Vehicul(nr, marca, model, capacitate, culoare, optiuni);
            admin.Adauga(v);

            Console.WriteLine("Vehicul adaugat.");
        }

        static void AfiseazaVehicule(AdministratorVehicule_FisierText admin)
        {
            var lista = admin.GetAll();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nu exista vehicule.");
                return;
            }

            foreach (var v in lista)
            {
                Console.WriteLine($"{v.NumarInmatriculare} - {v.Marca} {v.Model} - {v.CapacitateIncarcare} kg - {v.Culoare} - {v.Optiuni}");
            }
        }

        static void CautaVehicul(AdministratorVehicule_FisierText admin)
        {
            Console.Write("Introdu numarul de inmatriculare: ");
            string nr = Console.ReadLine();

            var v = admin.CautaDupaNumar(nr);

            if (v != null)
            {
                Console.WriteLine($"Gasit: {v.Marca} {v.Model} - {v.Culoare} - {v.Optiuni}");
            }
            else
            {
                Console.WriteLine("Vehiculul nu a fost gasit.");
            }
        }
        static void AdaugaSofer(AdministratorSoferi_FisierText admin)
        {
            Console.Write("Nume: ");
            string nume = Console.ReadLine();

            Console.Write("Prenume: ");
            string prenume = Console.ReadLine();

            Console.Write("Permis: ");
            string permis = Console.ReadLine();

            Console.Write("Experienta ani: ");
            int experienta;
            int.TryParse(Console.ReadLine(), out experienta);

            Sofer s = new Sofer(nume, prenume, permis, experienta);
            admin.Adauga(s);

            Console.WriteLine("Sofer adaugat.");
        }
        static void AfiseazaSoferi(AdministratorSoferi_FisierText admin)
        {
            var lista = admin.GetAll();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nu exista soferi.");
                return;
            }

            foreach (var s in lista)
            {
                Console.WriteLine($"{s.Nume} {s.Prenume} - Permis: {s.PermisConducere} - Experienta: {s.ExperientaAni} ani");
            }
        }
    }
}