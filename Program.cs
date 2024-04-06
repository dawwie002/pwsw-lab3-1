using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //utworzenie dwóch obiektów klasy RGB
            RGB color1 = new RGB();
            RGB color2 = new RGB();

            // wartosci nadane przez konstruktor
            Console.Write("RGB values of color1: ");
            RGBController.printRGBValues(color1);
            Console.Write("RGB values of color2: ");
            RGBController.printRGBValues(color1);

            // wartosci zainicjowane przez metode initRGB
            RGBController.initRGB(200, 150, 100, color1);
            RGBController.initRGB(57, 83, 193, color2);

            // wyswietlenie wartosci po inicjalizacji
            Console.Write("\nRGB values of color1: ");
            RGBController.printRGBValues(color1);
            Console.Write("RGB values of color2: ");
            RGBController.printRGBValues(color2);

            //zmieszanie barw i wyswietlenie wyniku
            Console.Write("\nRGB values of color3 (mixed): ");
            RGB color3 = RGBController.mixRGB(color1, color2);
            RGBController.printRGBValues(color3);
        }
    }
}