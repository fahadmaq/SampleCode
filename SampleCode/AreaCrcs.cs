using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    abstract public class AreaCrcs
    {
        public abstract void CalculateArea();

    }
    public class Circle: AreaCrcs
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"area of the circle{area}";

        }
        /*class Rectangle
        {
            public class Rectangle : AreaCrcs
            {
                private int l;
                private int b;
                private double area;

            }
            public Rectangle(int l, int b)
            {
                this.l = l;
                this.b = b;

            }
            public override void CalcuateArea()
            {
                area = l * b;
            }
            public override string ToString()
            {
                return $"area of rectangle{area}";
            }
        }*/
    }
}
