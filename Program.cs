
namespace FleetTrack
{
    class Program
    {
        static void Main()
        {
            Vehicul v1 = new Vehicul("SV01ABC", "Volvo", "FH16", 20000);
            Sofer s1 = new Sofer("Popescu", "Ion", "C+E", 8);

            Cursa c1 = new Cursa("Suceava", "Cluj", 300, DateTime.Now, v1, s1);

            Console.WriteLine($"Cursa: {c1.OrasPlecare} -> {c1.OrasDestinatie}");
            Console.WriteLine($"Vehicul: {v1.Marca} {v1.Model}");
            Console.WriteLine($"Sofer: {s1.Nume} {s1.Prenume}");
        }
    }
}