using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu_park
{
    class auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        private double fogyaszt;
        private double km;
        private double megtehetoKm;

        public double KM { get { return km; } }
        public double UZEMANYAG { get { return uzemAnyag; } }
        public double MEGTEHETO { get { return megtehetoKm; } }



        public auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.km = 0;
            this.uzemAnyag = 0;




        }

        private void Megteheto()
        {
            megtehetoKm = uzemAnyag / fogyaszt * 100;
        }


        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            
            Megteheto();
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            
            Megteheto();
        }

        public void Allapot()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"KM óra: {km}");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Fogyasztas: {fogyaszt} l");
            Console.WriteLine($"Megteheto {megtehetoKm}");
        }

    }
}
