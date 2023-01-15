/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine ("Введите число ");
string NumberStr1 = Console.ReadLine();
int a = Convert.ToInt32 (NumberStr1);

if (a%2 == 0)
{
Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является не чётным");
}