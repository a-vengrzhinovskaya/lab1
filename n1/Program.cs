/******************************************
 * Автор: Венгржиновская А. С.            *
 * Дата: 07.02.2022                       *
 * Название: Базовые понятия языка С# - 1 *
*******************************************/

using System;

namespace n1 {

	class Program {

		static void Main(string[] args) {

            Console.WriteLine("Enter a:");
			int Number = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter n:");
			int Exponent = int.Parse(Console.ReadLine());

			bool Negative = false;

			if (Exponent < 0) {

				Negative = true;
				Exponent *= -1;
            }

			int Result = 1;

			for (int ExponentIndex = 1; ExponentIndex <= Exponent; ++ExponentIndex) {

				Result *= Number;
            }

			if (Negative) {

                Console.WriteLine("\n" + "Result: 1/" + Result);
            } else {

				Console.WriteLine("\n" + "Result: " + Result);
			}

			Console.ReadKey();
		}
	}
}