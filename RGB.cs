using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1
{
    public class RGB
    {
        // konstuktor z ustawieniem wartosci na 0
        public RGB()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        // zmienne
        private int Red, Green, Blue;

        //metody get
        public int getRed() {  return Red; }
        public int getGreen() { return Green; }
        public int getBlue() { return Blue; }

        //metody set
        public void setRed(int value) 
        {
            if (value >= 0 && value <= 255) Red = value;
            else Console.WriteLine("Red value is not in between 0-255");
        }
        public void setGreen(int value) 
        {
            if (value >= 0 && value <= 255) Green = value;
            else Console.WriteLine("Green value is not in between 0-255");
        }
        public void setBlue(int value) 
        {
            if (value >= 0 && value <= 255) Blue = value;
            else Console.WriteLine("Blue value is not in between 0-255");
        }
    }
}
