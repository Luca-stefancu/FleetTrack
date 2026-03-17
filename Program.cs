
namespace FleetTrack
{
    class Program
    {
        static void Main()
        {
            List<Vehicul> vehicule = new List<Vehicul>();
            int optiune;

            do
            {
                Console.WriteLine("\n1. Adauga vehicul");
                Console.WriteLine("2. Afiseaza vehicule");
                Console.WriteLine("3.Cauta vehicul dupa numar");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege optiunea: ");

                int.TryParse(Console.ReadLine(), out optiune);

                switch (optine)
                {
                    case 1:
                        AdaugaVehicul(vehicule);
                        break;
                    case 2:
                        AfiseazaVehicule(vehicule);
                        break;
                    case 3:
                        CautaVehicul(vehicule);
                        break;

                }
            } while (optiune != 0);

        }

        static void AdaugaVehicul(List<Vehicul> lista)
        {
            Console.Write("Numar inmatriculare: ");
            string nr = Console.ReadLine();

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Capacitate incarcare: ");
            double capacitate;
            double.TryParse(Console.ReadLine(), out capacitate);

            Vehicul v = new Vehicul(nr, marca, model, capacitate);
            lista.Add(v);

            Console.WriteLine("Vehicul adaugat.");

            static void AfiseazaVehicule(List<Vehicul> lista)
            {
                if (lista.Count == 0)
                {
                    Console.WriteLine("Nu exista vehicule.");
                    return;
                }

                foreach (var v in lista)
                {
                    Console.WriteLine($"{v.NumarInmatriculare} - {v.Marca} {v.Model} - {v.CapacitateIncarcare} kg");
                }
            }

            static void CautaVehicul(List<Vehicul> lista)
            {
                Console.Write("Introdu numarul de inmatriculare: ");
                string nr = Console.ReadLine();

                foreach (var v in lista)
                {
                    if (v.NumarInmatriculare.Equals(nr, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Gasit: {v.Marca} {v.Model}");
                        return;
                    }
                }

                Console.WriteLine("Vehiculul nu a fost gasit.");
            }
    }
}