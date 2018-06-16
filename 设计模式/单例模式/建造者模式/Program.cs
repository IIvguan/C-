using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCar car = new  BMW();
            CarDirector carDirector = new CarDirector(car);
            carDirector.CreatCar();
            Console.ReadKey();
        }
    }
    public abstract class BaseCar
    {
        public  abstract  void SetWheel();
        public abstract void SetOilBox();
        public abstract void SetBody();

    }

    public class BMW : BaseCar
    {
        
        public override void SetBody()
        {
            Console.WriteLine("BMWBody");
        }

        public override void SetOilBox()
        {
            Console.WriteLine("BMWOilBox");
        }

        public override void SetWheel()
        {
            Console.WriteLine("BMWWheel");
        }
    }

    public class Benz : BaseCar
    {
        public override void SetBody()
        {
            Console.WriteLine("BenzBody");
        }

        public override void SetOilBox()
        {
            Console.WriteLine("BenzOilBox");
        }

        public override void SetWheel()
        {
            Console.WriteLine("BenzWheel");
        }
    }

    class CarDirector
    {
        private BaseCar Car;

        public CarDirector(BaseCar car)
        {
            this.Car = car;
        }

        public void CreatCar()
        {
            Car.SetBody();
            Car.SetOilBox();
            Car.SetWheel();
        }

    }

}
