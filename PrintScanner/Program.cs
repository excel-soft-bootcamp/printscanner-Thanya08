using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
   
     public class Program 
        {
         static void Main(string[] args)
         {
            PrintManager manager = new PrintManager();
            PrintScanner printer = new PrintScanner(manager);
            PrintScanner scanner = new PrintScanner(new ScanManager());
            printer.PrintDocument();
            scanner.ScanDocument();


         }

     }
 }

    

