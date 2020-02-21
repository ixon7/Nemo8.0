using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo8._0
{
    public class Ink
    {
        public Ink(string c, double l)
        {
            Color = c;
            Level = l;
        }
        public string Color { get; set; }
        public double Level { get; set; }
    }
}
