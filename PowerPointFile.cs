using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class PowerPointFile : File
    {

        public override void Compress()
        {
            Console.WriteLine("Compressing PowerPointFile");
        }

        public void Present()
        {
            Console.WriteLine($"{Filename} presenting...");
        }
    }
}
