// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N= ");
string strNum = Console.ReadLine();
int N = int.Parse(strNum); 

if (N<=1)
{Console.Write("Число не попадает в диапазон [1,N], среди которых есть четные числа");}
else 
{

for (int i=1;i<=N;i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i+", ");
    }
}
}