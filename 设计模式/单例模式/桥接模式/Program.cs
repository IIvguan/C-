using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCoffe coffe = new Milk();
            BaseSize size = new SmallCoffee();
            coffe.SetSize(size);
            coffe.GetCoffee();
            Console.ReadLine();
        }
    }

    public abstract class BaseSize
    {
      public abstract void  SetSzie();
    }

    public class JorumCoffee : BaseSize
    {
        public override void SetSzie()
        {
            Console.WriteLine("JorumCoffee");
        }
    }

    public class MediumCoffee : BaseSize
    {
        public override void SetSzie()
        {
            Console.WriteLine("MediumCoffee");
        }
    }

    public class SmallCoffee : BaseSize
    {
        public override void SetSzie()
        {
            Console.WriteLine("SmallCoffee");
        }
    }

    public abstract class BaseCoffe
    {
        protected BaseSize BaseSize;
        public abstract void GetCoffee();
        public void SetSize(BaseSize size)
        {
            this.BaseSize = size;
            size.SetSzie();
        }
    }

    public class Milk : BaseCoffe
    {
        public override void GetCoffee()
        {
            Console.WriteLine("Milk"); ;
        }
    }
    public class Sugar : BaseCoffe
    {
        public override void GetCoffee()
        {
            Console.WriteLine("Sugar"); ;
        }
    }

    public class Lemon : BaseCoffe
    {
        public override void GetCoffee()
        {
            Console.WriteLine("Lemon"); ;
        }
    }
}
