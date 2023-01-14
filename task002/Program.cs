/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine ("Введите первое число");
string NumberStr1 = Console.ReadLine();
int a = Convert.ToInt32 (NumberStr1);

Console.WriteLine ("Введите второе число");
string NumberStr2 = Console.ReadLine();
int b = Convert.ToInt32 (NumberStr2);

Console.WriteLine ("Введите третье число");
string NumberStr3 = Console.ReadLine();
int c = Convert.ToInt32 (NumberStr3);

int max = a;

if (max > b)
{
    max = a;
}
else {
    max = b;
}

if (max > c)
{
    max = max;
}
else {
    max = c;
}
Console.WriteLine("Максимальное число из этих чисел - ");
Console.Write(max);