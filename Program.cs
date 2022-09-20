Console.Clear();

Console.WriteLine("введите первое число: ");
string input = Console.ReadLine();
int number1 = int.Parse(input);

Console.WriteLine("введите второе число: ");
string input1 = Console.ReadLine();
int number2 = int.Parse(input1);

if (number1 > number2)
{
    Console.WriteLine($"max= {number1} min= {number2}");
}
else{
    Console.WriteLine($"max= {number2} min= {number1}");
}