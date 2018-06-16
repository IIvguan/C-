using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Basenoshery basenoshery = new KFC();
            BaseFood food = basenoshery.GetCola();
            food.Eat();
            basenoshery = new McDonalds();
            food = basenoshery.GetHamburg();
            food.Eat();
            Console.ReadKey();
        }
    }
    public abstract class BaseFood
    {

       public abstract void Eat();
    }

    public abstract class Basenoshery
    {
        public abstract BaseFood GetHamburg();
        public abstract BaseFood GetCola();
    }
    public class Cola : BaseFood
    {
        public override void Eat()
        {
            Console.WriteLine("eat Cola");
        }
    }

    public class Hamburg : BaseFood
    {
        public override void Eat()
        {
            Console.WriteLine("eat Hamburg");
        }
    }

    public class McDonalds : Basenoshery
    {
        public override BaseFood GetCola()
        {
            return new Cola();
        }

        public override BaseFood GetHamburg()
        {
            return new Hamburg();
        }
    }
    public class KFC : Basenoshery
    {
        public Hamburg Hamburg
        {
            get => default(Hamburg);
            set
            {
            }
        }

        public override BaseFood GetCola()
        {
            return new Cola();
        }

        public override BaseFood GetHamburg()
        {
            return new Hamburg();
        }
    }
}
