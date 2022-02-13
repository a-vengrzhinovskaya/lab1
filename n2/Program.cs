/******************************************
 * Автор: Венгржиновская А. С.            *
 * Дата: 07.02.2022                       *
 * Название: Базовые понятия языка С# - 2 *
*******************************************/

using System;

namespace n2 {

	class Program {

		static void Main(string[] args) {

			Console.WriteLine("Enter x:");
			var Number = Console.ReadLine();

			int NumberInt;

			if (!int.TryParse(Number, out NumberInt) || NumberInt < 100) {

                Console.WriteLine("\n" + "Invalid number");

				return;
			}

			Console.Clear();

			Console.WriteLine("x: " + Number);

			Number = Number.Remove(1, 1) + Number.Substring(1, Number.Length - (Number.Length - 1));

			Console.WriteLine("n: " + Number);

			Console.ReadKey();
		}
	}
}