//Задача 4
//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine()); 

int max = firstNumber;
if(max < secondNumber)
{
    max = secondNumber;
}
if(max < thirdNumber)
{
    max = thirdNumber;
}
Console.WriteLine("Максимальное число: " + max);