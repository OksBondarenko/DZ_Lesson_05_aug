//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber < secondNumber)
{
    Console.WriteLine("Минимальное значение: " + firstNumber);
    Console.WriteLine("Максимальное значение: " + secondNumber);
}
else if(firstNumber > secondNumber)
{
    Console.WriteLine("Минимальное значение: " + secondNumber);
    Console.WriteLine("Максимальное значение: " + firstNumber);
}
else
{
    Console.WriteLine("Значения равны");
}

