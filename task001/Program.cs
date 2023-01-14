/*

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine ("Введите число a");
string NumberStr1 = Console.ReadLine();
int a = Convert.ToInt32 (NumberStr1);

Console.WriteLine ("Введите число b");
string NumberStr2 = Console.ReadLine();
int b = Convert.ToInt32 (NumberStr2);

if (a > b)
{
Console.WriteLine("a > b");
}
else
{
 Console.WriteLine("a < b");
}