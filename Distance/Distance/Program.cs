using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Point
    {
        public double x;
        public double y;
    }

    class Line
    {
        public Point punct1 = new Point();
        public Point punct2 = new Point();
        public double Lungime()
        {
            double l;
            l = Math.Sqrt((punct1.x - punct2.x) * (punct1.x - punct2.x) + (punct1.y - punct2.y) * (punct1.y - punct2.y));
            return l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Line segment = new Line();
            double distanta;
            segment.punct1.x = 3;
            segment.punct2.x = 9;
            segment.punct1.y = 6;
            segment.punct2.y = 9;
            distanta = segment.Lungime();
            Console.WriteLine("Distanta dintre punctele ({0},{1}) si ({2},{3}) este: {4:#.##}", segment.punct1.x, segment.punct1.y, segment.punct2.x, segment.punct2.y, distanta);
            Console.ReadLine();
        }
    }
}
