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
        }
    }
}
