using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPlayerXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Renderer renderer = new Renderer();            
            renderer.DrawPlayer(player.CoordinateX, player.CoordinateY, player.SingPlayer);
        }
    }

    class Player
    {
        private readonly string _nameCoordinateX = "X";
        private readonly string _nameCoordinateY = "Y";
        private readonly int _xMinCoordinate = 3;
        private readonly int _xMaxCoordinate = 30;
        private readonly int _yMinCoordinate = 2;
        private readonly int _yMaxCoordinate = 20;
        public char SingPlayer { get; private set; }
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }
        
        public Player()
        {
            CoordinateX = ReadInput(_xMinCoordinate, _xMaxCoordinate, _nameCoordinateX);
            CoordinateY = ReadInput(_yMinCoordinate, _yMaxCoordinate, _nameCoordinateY);
            SingPlayer = '$';
        }

        private int ReadInput(int minCoordinate,  int maxCoordinate, string nameCoordinate)
        {
            bool completed = false;
            int intValue = 0;
            Console.WriteLine($"Введите число для установления координат по {nameCoordinate} от {minCoordinate} до {maxCoordinate}");
            while (completed == false)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out intValue))
                {
                    if ( intValue >= minCoordinate && intValue <= maxCoordinate)
                    {
                        completed = true;
                    }
                    else
                    {
                        Console.WriteLine($"Не верный ввод значения.Введите  целое число от {minCoordinate} до {maxCoordinate}.");
                    }                    
                }
                else
                {
                    Console.WriteLine($"Не верный ввод значения.Введите  целое число от {minCoordinate} до {maxCoordinate}.");
                }
            }
            return intValue;
        }        
    }

    class Renderer
    {
        public void DrawPlayer(int x, int y, char player)
        {
            Console.WriteLine("Значения установлены нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(x - 1, y - 1);
            Console.WriteLine(player);            
        }
    }
}
