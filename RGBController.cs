using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1
{
    public class RGBController
    {
        //metoda inicjująca wartosci na podane przez user'a, dla obiektu RGB
        public static void initRGB(int R, int G, int B, RGB rgb)
        {
            rgb.setRed(R);
            rgb.setGreen(G);
            rgb.setBlue(B);
        }

        // metoda wyświetlająca aktualne wartosci R, G, B dla obiektu klasy RGB
        public static void printRGBValues(RGB rgb)
        {
            Console.Write($"[ {rgb.getRed()}, {rgb.getGreen()}, {rgb.getBlue()} ]\n");
        }

        //metoda mieszająca barwy - jako argumenty przyjmuje dwa obiekty klasy RGB
        public static RGB mixRGB(RGB rgb1, RGB rgb2)
        {
            //utworzenie wynikowego obiektu klasy RGB
            RGB resultRGB = new RGB();

            // wyliczenia dla poszczególnych składowych
            resultRGB.setRed( (rgb1.getRed() + rgb2.getRed()) / 2 );
            resultRGB.setGreen((rgb1.getGreen() + rgb2.getGreen()) / 2);
            resultRGB.setBlue((rgb1.getBlue() + rgb2.getBlue()) / 2);

            //zwrócenie wynikowego obiektu klasy RGB
            return resultRGB;
        }
    }
}