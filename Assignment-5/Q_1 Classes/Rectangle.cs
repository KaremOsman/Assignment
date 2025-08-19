using Assignment_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Classes
{
    internal class Rectangle :IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Width = {Width} cm, Rectangle Height = {Height} cm, Rectangle Area = {Area} cm2");
        }
    }
}
