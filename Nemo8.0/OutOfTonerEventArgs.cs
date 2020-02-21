using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo8._0
{
    public class OutOfTonerEventArgs : EventArgs
    {
        private string color;

        public OutOfTonerEventArgs(string color)
        {
            this.color = color;
        }

        public OutOfTonerEventArgs(int black, int red, int green, int blue)
        {
            Black = black;
            Red = red;
            Green = green;
            Blue = blue;
        }
        public int Black { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Color { get; internal set; }
    }
}
