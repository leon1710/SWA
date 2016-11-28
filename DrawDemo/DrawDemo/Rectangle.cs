using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawDemo
{
    public class Rectangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * height + 2 * width;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}