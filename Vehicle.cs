using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Practice_1
{
    internal class Vehicle
    {
        string _color;

        public Vehicle(string color)
        {
            _color = color;
        }

        public string Color { get => _color; set => _color = value; }
    }
}
