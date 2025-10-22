using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static int PlayerX = 0;	//начальная позиция символа
		static int PlayerY = 0;
		static char[] Player = {'@'};	//сам 'игрок'
		static bool GameRunning = true;	//Для задачи условия цикла в мэйне
		static void Main(string[] args)
		{
			while (GameRunning)	//Условия работы игры
			{
				Game();
				Management();
			}
		}
		static void Game()	
		{
			Console.SetCursorPosition(PlayerX, PlayerY);	//Для перемещения в консоли по координатам
			Console.Write(Player);
		}
		static void Management()
		{
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo key = Console.ReadKey(true);
				switch (key.Key)
				{
					case ConsoleKey.W:
						PlayerY--;
						Console.Clear();
						break;
					case ConsoleKey.S: 
						PlayerY++;
						Console.Clear();
						break;
					case ConsoleKey.A: 
						PlayerX--;
						Console.Clear();
						break;
					case ConsoleKey.D:
						PlayerX++;
						Console.Clear();
						break;
					case ConsoleKey.Escape:
						GameRunning = false;
						break;
				}
			}
		}
	}
}
