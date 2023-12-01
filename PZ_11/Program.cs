using System.Numerics;

namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определения площади поверхности и длины экватора планеты");
            double r; //радиус 
            double s; //площадь поверности планеты/шара 
            double Cr; //длина поверхности планеты/шара
            Console.WriteLine("Площадь поверхности и длина планеты\n");
            Console.WriteLine("Введите радиус -> ");
            r = Convert.ToDouble(Console.ReadLine());
            Planets(ref r, out s);
            Console.WriteLine("\nПлощадь поверхности равна: " + s);
            Len(ref r, out Cr);
            Console.WriteLine("\nДлина планеты равна: " + Cr);
        }

        static void Planets(ref double radius, out double sq)
        {
            sq = 4 * Math.PI * (radius * radius);
        }
        static void Len(ref double radius, out double C)
        {
            C =2* Math.PI* radius;
        }
     }

}      
        
   
