using System;

namespace Nemo8._0
{
    class Program
    {
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
                {
                    return;
                }
            }
        }
        static void OutOfPaperEventHandler2(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine($"Please refill paper! Start from page {args.PageNumber}");
            printerOK = false;
        }
        static void OutOfTonerEventHandler2(object sender, OutOfTonerEventArgs args)
        {
            Console.WriteLine("Please refill ink " + args.Color);
        }
    }
}
