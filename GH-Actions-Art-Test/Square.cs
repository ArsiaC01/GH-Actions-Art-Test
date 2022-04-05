using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH_Actions_Art_Test
{
    class Square
    {
        // Fields for area and length of side.
        private readonly double side;
        private readonly double area;

        // Constructor for Square class that takes a side length as a parameter.
        public Square(double side)
        {
            this.side = side;
            this.area = side * side;
        }
        // Add read only properties to get a square side and area.
        public double Side
        {
            get { return side; }
        }
        public double Area
        {
            get { return area; }
        }
    }
}
