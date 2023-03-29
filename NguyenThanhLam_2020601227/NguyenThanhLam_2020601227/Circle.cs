using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhLam_2020601227
{
    class Circle
    {
        public double radius {  get; set; }
        public Circle(double radius)
        { 
             this.radius = radius; 
        }

        public double areaValue(double radiusValue)
        {
            return 2 * Math.PI * Math.Pow(radiusValue, 2);
        }

        public double perimeterValue (double radiusValue)
        {
            return 2 * Math.PI * radiusValue;
        }

        public void output()
        {
            Console.Write("Radius = ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area value: " + areaValue(radius));
            Console.WriteLine("Perimeter value: " + perimeterValue(radius));
        }
    }
}
