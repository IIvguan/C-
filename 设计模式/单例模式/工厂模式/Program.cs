using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory factory = new ComputerFactory();
            BaseComputer computer1 = factory.Production("Dell");
            computer1.run();
            BaseComputer computer2 = factory.Production("Acer");
            computer2.run();
            Console.ReadKey();
        }
    }

    public abstract class BaseComputer
    {
        public abstract void run();
    }

    public class Laptop : BaseComputer
    {
        public override void run()
        {
            Console.WriteLine("Laptop run");
        }
    }
    public class Acer : BaseComputer
    {
        public override void run()
        {
            Console.WriteLine("Acer run");
        }
    }

    public class Lenovo : BaseComputer
    {
        public override void run()
        {
            Console.WriteLine("Lenovo run");
        }
    }
    public class Dell : BaseComputer
    {
        public override void run()
        {
            Console.WriteLine("Dell run");
        }
    }

    public class ComputerFactory
    {
        public BaseComputer Production(String type)
        {
            if (type == null)
            {
                return null;
            }
            else if (type.Equals("Laptop"))
            {
                return new Laptop();
            }
            else if (type.Equals("Dell"))
            {
                return new Dell();
            }
            else if (type.Equals("Acer"))
            {
                return new Acer();
            }
            else if (type.Equals("Lenovo"))
            {
                return new Lenovo();
            }
            return null;
        }
    }

}
