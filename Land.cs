using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Practice_1
{
    internal class Land : Vehicle
    {
        int _wheels;

        public Land(string color, int wheels) : base(color)
        {
            _wheels = wheels;
        }
    }
}
