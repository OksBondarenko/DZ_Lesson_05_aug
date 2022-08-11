//задача 6
//Напишите программу, которая принимает на вход число и выдаёт, является ли число четным (делится ли оно на два)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write(number + " является четным");
}
else
{
    Console.Write(number + " является нечетным");
}