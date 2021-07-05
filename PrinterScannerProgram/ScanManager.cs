using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerProgram
{
    public class ScanManager
    {
        public void ScanDocument(IScanner scaner)
        {
            scaner.Scan();
        }
    }
}
