using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public struct Distance
    {
        public double feet;
        public double inches;
        public double feet_and_inches;
    };
    class Program
    {
        static void Main(string[] args)
        {
            
            Distance dist1;
            Distance dist2;
            Distance final;
            Console.WriteLine("Enter foot 1");
             dist1.feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches 1");
            dist1.inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter foot 1");
            dist2.feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches 2");
            dist2.inches = double.Parse(Console.ReadLine());

            final.feet_and_inches = (dist1.feet * 12) + (dist2.feet * 12) + dist1.inches + dist2.inches;

            Console.WriteLine("You entered {0} feet and {1}inches", (int)final.feet_and_inches/12, final.feet_and_inches%12);
            Console.Read();        }
    }
}
