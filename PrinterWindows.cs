using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string ukuran { get; set; }
        public string ketrngan { get; set; }

        public virtual void show()
        {
            Console.WriteLine("Display dimension : ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printing ...");
        }
    }
    public class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson Display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon display : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
    public class Laserjet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Laserjet printer printing ...");
        }
    }

}
