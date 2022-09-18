Console.Clear();
Console.WriteLine("Введите положительное число");
int a = int.Parse(Console.ReadLine());
int count = 2;

while(count <= a)
{
    Console.Write($"{count}, ");
    count = count + 2;
}

