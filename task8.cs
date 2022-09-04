internal class task8
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");

        int b = int.Parse(Console.ReadLine());

        int x = 1; // x - наш счетчик

        while (x <= b)
        {
            if (x % 2 == 0) Console.WriteLine(x); //выводим x;

            x++;
        }
    }
}