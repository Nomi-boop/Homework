//задача 34
internal partial class task34
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);

        PrintArray(numbers);

        int count = 0;
        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] % 2 == 0)
            count++;
        }

        Console.WriteLine($"всего {count} чётных чисел");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
               numbers[i] = new Random().Next(100,1000);
            }
        }

    

        void PrintArray(int[] numbers)
        {
        Console.Write("[ ");
        {
        for(int i = 0; i < numbers.Length; i++)
        {
        Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
        }
        }
}



// задача 36
internal class task36
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
    }
}}
