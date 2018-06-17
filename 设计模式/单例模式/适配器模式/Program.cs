using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDraw draw1 = new Circle();
            draw1.Draw();
            BaseDraw draw2 = new Rectangle();
            draw2.Draw();
            BaseDraw draw3 = new Translator();
            draw3.Draw();
            Console.ReadKey();
        }
    }
    public abstract class  BaseDraw
    {
       public abstract void Draw();
    }

    public class Circle : BaseDraw
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    public class Rectangle : BaseDraw
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Line : BaseDraw
    {
        public override void Draw()
        {
            Console.WriteLine("Line");
        }
    }
    public class Angle
    {
        public void DrawAngle()
        {
            Console.WriteLine("Angle");
        }
    }
    public class Translator : BaseDraw
    {
        private Angle angle = new Angle();
        public  override void Draw()
        {
            angle.DrawAngle();
        }
    }

}
