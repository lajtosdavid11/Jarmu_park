using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jarmu_park
{
    class Program
    {
        static void Main(string[] args)
        {
            
            auto lada = new auto("piros","Lada 2112",11);
            auto trabant = new auto("zöld","trabant 1.1",8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();


            Console.WriteLine("Mennyit megy a lada?: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyit menjen trabant?: ");
            int kmm = int.Parse(Console.ReadLine());

            lada.Megy(km);
            trabant.Megy(kmm);

            lada.Allapot();
            trabant.Allapot();

            





            Console.ReadKey();
        }
    }
}
