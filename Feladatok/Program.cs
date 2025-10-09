using System.ComponentModel.Design;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            DateTime now = DateTime.Now;
            int ora = now.Hour;
            if (ora >= 5 && ora < 12)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ora >= 12 && ora < 18)
            {
                Console.WriteLine("Jó napot!");
            }
            else
            {
                Console.WriteLine("Jó estét!");
            }
            //2
            Console.WriteLine("Adjon meg egy összeget:");
            int osszeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg hány évre akarja lekötni:");
            int ev = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a kamatot(%):");
            double kamat = double.Parse(Console.ReadLine());

            double kamat2 = kamat / 100;

            double vissza = osszeg + osszeg * ev * kamat2;
            Console.WriteLine($"A visszajaro osszeg: {vissza}");
        }
    }
}
