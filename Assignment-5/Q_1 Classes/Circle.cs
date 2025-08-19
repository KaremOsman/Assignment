using Assignment_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Classes
{
    internal class Circle : ICircle
    {
     public double Radius { get; set; }
     public double Area => Math.PI * Radius * Radius;

    public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Radius = {Radius} cm, Circle Area = {Area} cm2");
        }
    }
}
