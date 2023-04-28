using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Practice_1
{
    internal class Sea : Vehicle
    {
        string _type;

        public Sea(string color, string type) : base(color)
        {
            _type = type;
        }
    }
}
