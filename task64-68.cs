using System;
					
internal class tasks_64_66_68
{
	public static void Main()
	{
		// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
		
		void PrintInterval(int a, int b)
		{
			int start = a;
			int end = b;
			if(a > b)
			{
				start = b;
				end = a;
			}
			for(int i = start; i <= end; i++)
			{
				Console.Write($"{i}, ");
			}
		}
		PrintInterval(1, 8);
		
		Console.WriteLine();
		
		// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
		
		int FindSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; //формула суммы членов арифметической прогрессии
		}
		
		Console.WriteLine(FindSumm(2, 3));
		
		// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
		
		int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
	}
}
