using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawDemo
{
    public class Circle : Shape
    {
        public double Diameter { get; set; }


        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Diameter/2,2);
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * Diameter;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}