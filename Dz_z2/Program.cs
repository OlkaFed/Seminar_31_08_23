// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1); 

Console.Write("Введите второе число ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

if (num1 > num2)
{
System.Console.Write("MAX = ");
System.Console.WriteLine(num1);
}
else
{
    System.Console.Write("MAX = ");
    System.Console.WriteLine(num2);
}