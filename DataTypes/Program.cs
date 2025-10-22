//#define DATA_TYPES
//#define CONSTANTS
#define TYPE_CONVERSION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		const string delimiter = "\n-------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обёртка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);
			bool rain = true;
			Console.WriteLine($"Дождь идёт? - {rain}");
			///////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обёртка - {typeof(char)}"
				);
			Console.WriteLine(delimiter);
			//@"Raw-строка"
			Console.WriteLine(@"Raw-строка - игнорирует все специальные символы и esc-последовательности \t\n, т.е., воспринимается как есть 'as-is'");
			//ushort, uint, ulong
			//sbyte		byte	1 байт
			//short		ushort	2 байта
			//int		uint	4 байта
			//long		ulong	8 байт
			Console.WriteLine
	(
$@"byte занимает {sizeof(byte)} Байт памяти, и принимает значения в диапазоне от
{byte.MinValue} до {byte.MaxValue}, класс-обёртка {typeof(byte)}"
	);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"byte занимает {sizeof(sbyte)} Байт памяти, и принимает значения в диапазоне от
{sbyte.MinValue} до {sbyte.MaxValue}, класс-обёртка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine($@"float занимает {sizeof(float)} Байт памяти");


			Console.WriteLine($@"decimal занимает {sizeof(decimal)} Байт памяти");

#endif
			//////////////////////////////////////////////////////////////////////////////////////


#if CONSTANTS
			Console.WriteLine("Hello".GetType());
			//Console.WriteLine(typeof("Hello"));
			Console.WriteLine(5.0.GetType());
#endif

#if TYPE_CONVERSION
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine(delimiter);
			//ushort b = (ushort) - 2;
			//Console.WriteLine(b);
			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(a);
			// C-Like notation	(type)value
			bool rain = Convert.ToBoolean("True");
			bool rain_1 = bool.Parse("False");
			Console.WriteLine(rain);
			//Console.WriteLine(rain as string);
			Console.WriteLine(rain_1);
#endif
		}
	}
}
