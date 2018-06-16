using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一字棋
{
    class chess
    {
        private int pinX=0, pinY=0;
        private int user=0;

        public chess(int pinX, int pinY, int user)
        {
            this.pinX = pinX;
            this.pinY = pinY;
            this.user = user;
        }
        public chess()
        {

        }

        public int PinX { get => pinX; set => pinX = value; }
        public int PinY { get => pinY; set => pinY = value; }
        public int User { get => user; set => user = value; }

        public bool Equal_chess(chess chess)
        {
            if (this.pinX == chess.PinX && this.pinY == chess.PinY)
                return true;
            else
                return false;
        }
        public void add_chess(chess chess)
        {
            this.pinX = chess.PinX;
            this.PinY = chess.PinY;
        }
                
    }

    class chess_r
    {
        chess[][] chesses = new chess[3][3];
        for (int i = 0; i<3; i++)
			{
              for (int j = 0; j<3; j++)
			   {
            chesses.add_chess(chess());
			   }

			}

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
