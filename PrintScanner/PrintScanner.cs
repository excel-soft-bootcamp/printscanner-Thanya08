using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public class PrintScanner
    {
           
        Iprintmanager printmanager;
        public PrintScanner(Iprintmanager printmanager)
        {
            this.printmanager = printmanager;
        }
        public void PrintDocument()
        {
            printmanager.Print();

        }
        Iscanmanager scanmanager;
        public PrintScanner(Iscanmanager scanmanager)
        {
            this.scanmanager = scanmanager;
        }
        public void ScanDocument()
        {
            scanmanager.Scan();
        }

    }
}

