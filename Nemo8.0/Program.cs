using System;

namespace Nemo8._0
{
    class Program
    {
        static bool printerOK = true;
        static void Main(string[] args)
        {
            var printer = new Printer(11);
            
            printer.OutOfPaperEvent += OutOfPaperEventHandler2;
            for(int i=0; i <12; i++)
            {
                printer.Print(i+1);
                if(!printerOK)
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
