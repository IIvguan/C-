using System;

namespace 策略模式
{
    
        public abstract class IBOOK
        {
            public abstract void BOOK();
        }
        class BOOKContext
        {
            private IBOOK book = null;
            public void SetBook(IBOOK book)
            {
                this.book = book;
            }

            public void BOOK()
            {
                this.book.BOOK();
            }
        }

        class ComputerBOOK : IBOOK
        {
        public override void BOOK()
            {
                Console.WriteLine("计算机类图书打七折");
            }
    }

        class EnglishBOOK : IBOOK
        {
            public override void BOOK()
            {
                Console.WriteLine("英语类图书打六折");
            }
        }

        class MusicBOOK : IBOOK
        {
            public override void BOOK()
            {
                Console.WriteLine("音乐类图书打五折");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            BOOKContext context = new BOOKContext();
            context.SetBook(new EnglishBOOK());
            context.BOOK();
            context.SetBook(new MusicBOOK());
            context.BOOK();
            context.SetBook(new ComputerBOOK());
            context.BOOK();
            Console.ReadLine();
        }
    }
}
