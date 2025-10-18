//#define CONSOLE
//#define name_age
//#define SQUARE
//#define TRIANGLE_1
//#define TRIANGLE_2
//#define TRIANGLE_3
//#define TRIANGLE_4
//#define SQUARE_PLUS_MINUS
//#define RHOMBUS
#define HARD_CHESS


using System;   //#include
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{

#if CONSOLE
            Console.WriteLine("HelloWorld!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Hello .NET\t");
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            Console.Beep(137, 500);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor();
#endif
#if name_age
			Console.Write("Введите Ваше имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age);  //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age));  //Форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}"); //Интерполяция строк  
#endif

#if SQUARE
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			
			for (int i = 1; i < n+1; i++)
			{
				for (int j = 1; j < n; j++)Console.Write("* ");
				Console.WriteLine("* ");
			}

#endif

#if TRIANGLE_1
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string star = "* ";
			string empty = "  ";

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)Console.Write(star);
				Console.WriteLine(empty);
			}
#endif

#if TRIANGLE_2
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string star = "* ";
			string empty = "  ";

			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)Console.Write(star);
				Console.WriteLine(empty);
			}
#endif

#if TRIANGLE_3
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string star = "* ";
			string empty = "  ";
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)Console.Write(star);
				Console.WriteLine(empty);
			}
#endif
#if TRIANGLE_4
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string star = "* ";
			string empty = "  ";
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n - i; j++)Console.Write(empty);
				for (int j = 0; j < i; j++)Console.Write(star);
				Console.WriteLine();
			}
#endif

#if SQUARE_PLUS_MINUS
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string Plus = "+ ";
			string Minus = "- ";

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if(j % 2 ==  i % 2 )
						Console.Write(Plus);
					else
						Console.Write(Minus);
				}
				Console.WriteLine();
			}
#endif

#if RHOMBUS
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			string left = "/";
			string right = "\\";
			string empty = " ";

			for (int i = 0; i < n * 2; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if (i + n == j || j + n == i) Console.Write(right);
					else if (i == n - 1 - j || i - n == n * 2 - j - 1) Console.Write(left);
					else Console.Write(empty);
				}
				Console.WriteLine();
			}
#endif
#if HARD_CHESS
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int size = n;
			string star = "* ";
			string empty = "  ";
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < size; j++)
				{
					for (int k = 0; k < n; k++)
					{
						for (int l = 0; l < size; l++)
						{
							if (i % 2 == k % 2)Console.Write(star);
							else Console.Write(empty);
						}
					}
					Console.WriteLine();
				}
			}
#endif

		}
	}
}
