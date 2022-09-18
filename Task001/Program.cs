Console.Clear();
Console.WriteLine("Введите число №1: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите число №2: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

if(number1 > number2)
{
    Console.WriteLine($"max = {number1}");
    Console.WriteLine($"min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2}");
    Console.WriteLine($"min = {number1}");
}
