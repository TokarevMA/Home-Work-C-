Console.Clear();
Console.WriteLine("Введите число №1: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите число №2: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

Console.WriteLine("Введите число №3: ");
string input3 = Console.ReadLine();
int number3 = int.Parse(input3);

if(number1 > number2 && number1 > number3)
{
    Console.WriteLine($"max = {number1}");
}
if(number2 > number1 && number2 > number3)
{
    Console.WriteLine($"max = {number2}");
}
if(number3 > number1 && number3 > number2)
{
    Console.WriteLine($"max = {number3}");
}

