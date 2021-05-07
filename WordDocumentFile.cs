using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class WordDocumentFile : File
    {

        public override void Compress()
        {
            Console.WriteLine("Compressing WordFile");
        }

        public void Print()
        {
            Console.WriteLine($"{Filename} printing..");
        }
    }
}
