using System.ComponentModel.Design;
using System.Net.Http.Headers;

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
            //3
            double vkezdo;
            do
            {
                Console.WriteLine("Adja meg a futó sebességét 3.00 és 5.00(m/s) között:");
                vkezdo = double.Parse(Console.ReadLine());
            }
            while (vkezdo < 3.0 || vkezdo > 5.0);

            const double tav = 100;
            double fele = tav / 2;
            double lassulTav = 10;

            double vMax = vkezdo + 4.0;

            double a1 = (vMax - vkezdo) * (vMax + vkezdo) / (2 * fele);

            Console.WriteLine("Tízméterenként a sebességek (km/h): ");

            for (int i = 10; i <= tav;i=i+10)
            {
                double v;
                if (i <= fele)
                {
                    v = vkezdo + (vMax - vkezdo) * (i / fele);
                }
                else if (i >= tav - lassulTav)
                {
                    double vVeg = vMax / 2;
                    v = vMax - (vMax - vVeg) * ((i - (tav - lassulTav)) / lassulTav);
                }
                else
                {
                    v = vMax;    
                }

                double vKmH = v * 3.6;
                Console.WriteLine($"{i,3} m: {vKmH,6:F2}");
            }
        }   
    }
}
