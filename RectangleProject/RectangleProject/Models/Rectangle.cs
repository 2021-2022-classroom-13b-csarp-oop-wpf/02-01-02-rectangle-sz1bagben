using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
   public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            if (sideA > 0 && sideB > 0)
            {
                this.sideA = sideA;
                this.sideB = sideB;
            }
        } 
        public double SideA 
        {
            get => sideA;
            set => sideA = value;
        }
        public double SideB
        {
            get => sideB;
            set => sideB = value;
        }
        public double Area { get => sideA * sideB; }
        public double Perimeter { get => 2 * (sideA + sideB); }
        public override string ToString()
        {
            string szoveg = "A téglalap 'a' oldala: " + sideA + "\n";
            szoveg += "A téglalap 'b' oldala: " + sideB + "\n";
            szoveg += "A téglalap területe: " + Math.Round(Area, 2) + "\n";
            szoveg += "A téglalap kerülete: " + Math.Round(Perimeter, 2) + "\n";
            return szoveg;
        }
    }
}
