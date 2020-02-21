using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo8._0
{
    public class Printer
    {
        public event EventHandler<OutOfPaperEventArgs> OutOfPaperEvent;
        public event EventHandler<OutOfTonerEventArgs> OutOfTonerEvent;
        private List<Ink> _Toners;
        private Random _random = new Random();
        private int _paperCount { get; set; }
        public void Print(int pageNumber)
        {
            if (_paperCount == 0)
            {
                OutOfPaperEvent?.Invoke(this, new OutOfPaperEventArgs(pageNumber));
                return;
            }
            else
            {
                foreach (var toner in _Toners)
                {
                    if (toner.Level <= 0)
                    {
                        OutOfTonerEvent.Invoke(this, new OutOfTonerEventArgs(toner.Color));
                        return;
                    }
                }

                Console.WriteLine("Printing");
                --_paperCount;
                foreach (var toner in _Toners)
                {
                    toner.Level -= _random.NextDouble();
                }
            }
        }
        private void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("[Printer log] Out of Range");
        }
        private void OutOfTonerEventArgs(object sender, EventArgs args)
        {
            Console.WriteLine("[Printer log] Out of Range TONER");
        }
        public Printer()
        {
            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfTonerEvent += OutOfTonerEventHandler;
            _Toners = new List<Ink>{
                new Ink("Black",2),
                new Ink("Green",2),
                new Ink("Blue",2),
                new Ink("Red",2)
            };
        }
        public void OutOfTonerEventHandler(object sender, EventArgs args)
        {

        }
        public Printer(int paperCount) : this()
        {
            _paperCount = paperCount;
        }
    }
}
