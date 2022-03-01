using System;
using RectangleProject.Models;
namespace RectangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle teglalap1 = new Rectangle(12.33, 17);
            Rectangle teglalap2 = new Rectangle(6.65, 9);
            Console.WriteLine("Első téglalap");
            Console.WriteLine(teglalap1);
            Console.WriteLine("Második téglalap");
            Console.WriteLine(teglalap2);
            Console.WriteLine("A nagyobb területű téglalap kerülete: " + teglalap1.Area);
            Console.ReadKey();
        }
    }
}
