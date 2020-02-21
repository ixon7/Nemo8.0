using System;

namespace Nemo8._0
{
    public class Printer
    {
        public event EventHandler<OutOfPaperEventArgs> OutOfPaperEvent;
        public event EventHandler<OutOfTonerEventArgs> OutOfTonerEvent;

        public void print(int pageNumber)
        {
            if (_paperCount == 0)
            {
                OutOfPaperEvent?.Invoke(this, new OutOfPaperEventArgs(pageNumber));
                return;
            }
            else
            {
                Console.WriteLine("Printing...");
                --_paperCount;
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
        }
        private int _paperCount;
        public void OutOfTonerEventHandler(object sender,EventArgs args)
        {

        }
        public Printer(int paperCount):this()
        {
            _paperCount = paperCount;
        }
    }
    public class OutOfPaperEventArgs : EventArgs
    {
        public OutOfPaperEventArgs(int pageNumber)
        {
            PageNumber = pageNumber;
        }
        public int PageNumber { get;} // właśiwość funkcji 
    }
    public class OutOfTonerEventArgs : EventArgs
    {

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
    }
    class Program
    {
<<<<<<< HEAD
        public static bool printerOK = true;
        static void Main(string[] args)
        {
            Printer printer = new Printer(10);
            printer.OutOfPaperEvent += OutOfPaperEventHandler2;
            printer.OutOfTonerEvent += OutOfTonerEventHandler2;

            for (int i = 1; i < 315; i++)
            {
                printer.Print(i);
                if (!printerOK)
=======
        static bool printerOK = true;
        static void Main(string[] args)
        {
            var printer = new Printer(11);
            
            printer.OutOfPaperEvent += OutOfPaperEventHandler2;
            for(int i=0; i <12; i++)
            {
                printer.print(i+1);
                if(!printerOK)
>>>>>>> c4c5dd1e217e1b2b5c58daf844582607f2125368
                {
                    return;
                }
            }
        }
        static void OutOfPaperEventHandler2(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine($"Please refill paper! Start from page {args.PageNumber}");
            printerOK = false;
<<<<<<< HEAD
        }
        static void OutOfTonerEventHandler2(object sender, OutOfTonerEventArgs args)
        {
            Console.WriteLine("Please refill ink " + args.Color);
=======
>>>>>>> c4c5dd1e217e1b2b5c58daf844582607f2125368
        }
    }
}
