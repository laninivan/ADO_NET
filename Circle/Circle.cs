using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private Point point;
        private double r;

        public Circle()
        {
            this.r = 1;
            this.point = new Point(1, 1);
        }

        public Circle(double p,double x,double y)
        {
            this.r = p;
            this.point = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Радиус:{r}\nТочка: ({point.X};{point.Y})";
        }


        public double S()
        {
            return Math.PI * r * r;
        }

        public double L()
        {
            return 2*Math.PI  * r;
        }

        public static Circle Valide(double r, double x,double y)
        {
            Circle circle;
            if (r >= 0)
                circle = new Circle(r, x, y);
            else circle = new Circle();

            return circle;
        }

        
    }
}
