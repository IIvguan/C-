using System;


namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            XiY xiY = new XiY("喜洋洋");
            ReadApple readApple = new ReadApple();
            YApple yApple = new YApple();
            BApple bApple = new BApple();
            readApple.Decorate(xiY);
            bApple.Decorate(readApple);
            yApple.Decorate(bApple);
            yApple.Act();
            Console.ReadKey();
        }
    }
    abstract class IssAct
    {
        public abstract void Act();
    }
    class XiY : IssAct
    {
        private string name;

        public override void Act()
        {
            Console.WriteLine("装饰的{0}", name);
        }

        public XiY(string name)
        {
            this.name = name;
        }

    }
    abstract class act : IssAct
    {
        protected IssAct iact;
        public override void Act()
        {
            if (iact != null)
                iact.Act();
        }
        public void Decorate(IssAct iact)
        {
            this.iact = iact;
        }
    }

    class ReadApple : act
    {
        public override void Act()
        {
            base.Act();
            Console.WriteLine("红苹果");

        }
    }
    class YApple:act
    {
        public override void Act()
        {
            base.Act();
            Console.WriteLine("黄苹果");

        }
    }

    class BApple:act
    {
        public override void Act()
        {
            base.Act();
            Console.WriteLine("绿苹果");
        }
    }
}
