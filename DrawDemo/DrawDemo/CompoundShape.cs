using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawDemo
{
    public class CompoundShape : Shape
    {
        public List<Shape> ListOfShapes { get; set; }

        public override double CalculateArea()
        {
            double temp = 0;
            foreach (var item in ListOfShapes)
            {
               temp += item.CalculateArea();
            }
            return temp;
        }

        public override double CalculatePerimeter()
        {
            double temp = 0;
            foreach (var item in ListOfShapes)
            {
                temp += item.CalculatePerimeter();
            }
            return temp;
        }

        public override void Draw()
        {
            foreach(var item in ListOfShapes)
            {
                item.Draw();
            }
        }
    }
}