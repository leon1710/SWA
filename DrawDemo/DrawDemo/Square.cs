using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawDemo
{
    public class Square : Shape
    {
        public double Height { get; set; }


        public override double CalculateArea()
        {
            return Height*Height;
        }

        public override double CalculatePerimeter()
        {
            return Height*4;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}