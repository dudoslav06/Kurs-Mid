using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class ExcelFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing ExcelFile");
        }

        public void GenerateReport()
        {
            string prop = ProtectedProp;
            Console.WriteLine($"{Filename} report..");
        }
    }
}
