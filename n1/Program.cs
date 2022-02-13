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
			var NumberStr = Console.ReadLine();

			Console.WriteLine("Enter n:");
			var ExponentStr = Console.ReadLine();

			int Number, Exponent;

			if (!int.TryParse(NumberStr, out Number) || !int.TryParse(ExponentStr, out Exponent)) {

				Console.WriteLine("\n" + "Invalid number");

				return;
			}

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