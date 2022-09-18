Console.Clear();
Console.WriteLine("Введите число ");
string input1 = Console.ReadLine();
int a = int.Parse(input1);

if (a % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

