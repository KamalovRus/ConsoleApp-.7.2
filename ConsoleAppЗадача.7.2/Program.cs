using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача._7._1
{
	class Program
	{
		static double Ploshadiob(int a, out int per)
		{
			per = 6 * a * a;
			return Math.Pow(a, 3);
		}
		public static void Main()
		{
			Console.WriteLine("Введите длинну ребра");
			int a = Convert.ToInt32(Console.ReadLine());
			int per = 0;
			Console.WriteLine("Площадь = {0}, Периметр = {1} ", Ploshadiob(a, out per), per);
			Console.ReadKey();
		}
	}
}
