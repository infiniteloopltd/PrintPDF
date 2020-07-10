using System;
using Spire.Pdf;
using System.Drawing.Printing;

namespace PrintPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var iSelection = 1;
            Console.WriteLine("Which printer do you wish to use:");
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                Console.WriteLine(iSelection + ":" + printer);
                iSelection++;
            }
            iSelection = Convert.ToInt16(Console.ReadLine());
            var printerName = PrinterSettings.InstalledPrinters[--iSelection];
            // Install-Package Spire.PDF -Version 6.7.6
            // http://www.joyprinter.com/index.html -- handy for development
            var document = new PdfDocument();
            document.LoadFromFile("hello-world.pdf");
            document.PrintSettings.PrinterName = printerName;
            document.Print();
            document.Dispose();
        }
    }
}
