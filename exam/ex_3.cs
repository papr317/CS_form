using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    // объем параллепепипеда
    internal class ex_3
    {
        public class Parallelepiped
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public Parallelepiped(double length, double width, double height)
            {
                Length = length;
                Width = width;
                Height = height;
            }
            public double Volume()
            {
                return Length * Width * Height;
            }
        }
    }
}
