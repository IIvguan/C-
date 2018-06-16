using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseNPC baseNPC;
            baseNPC = new Dell();
            baseNPC.MakeNPC();
            Console.ReadKey();
        }
    }

    interface IBaseNPC
    {
            void MakeNPC();
    }
    class Laptop : IBaseNPC
    {
        public void MakeNPC()
        {
            Console.WriteLine("LaptopPC");
        }
    }
    class Acer : IBaseNPC
    {
        public void MakeNPC()
        {
            Console.WriteLine("AcerPC");
        }
    }
    class Lenovo : IBaseNPC
    {
        public void MakeNPC()
        {
            Console.WriteLine("LenovoPC");
        }
    }
    class Dell : IBaseNPC
    {
        public void MakeNPC()
        {
            Console.WriteLine("DellPC");
        }
    }
}
