Console.WriteLine("insert the 1st number");
string numberAstr = (Console.ReadLine());
int a = int.Parse(numberAstr);

Console.WriteLine("insert the 2nd number");
string numberBstr = (Console.ReadLine());
int b = int.Parse(numberBstr);

Console.WriteLine("insert the 3rd number");
string numberCstr = (Console.ReadLine());
int c = int.Parse(numberCstr);

int max = a;

if (b > max);
{
max = b;
}

if (c > max);
{
max = c;
}

Console.WriteLine(max);