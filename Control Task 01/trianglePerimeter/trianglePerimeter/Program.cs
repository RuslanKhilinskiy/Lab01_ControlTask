using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglePerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter perimiter value:");
                double perimiter = double.Parse(Console.ReadLine());

                double side = perimiter / 3;
                double semiPerimiter = perimiter / 2;
                double S = Math.Sqrt(semiPerimiter * (semiPerimiter - side) * (semiPerimiter - side) * (semiPerimiter - side));
                Console.WriteLine("Сторона\t\tПлощадь");
                Console.WriteLine($"{side}\t\t{S:F2}");
            }
            catch (FormatException e) {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
