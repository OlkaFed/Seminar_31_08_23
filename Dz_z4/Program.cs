// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1); 

Console.Write("Введите второе число ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

Console.Write("Введите третье число ");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);

int max = num1; 

if (max < num2)
{
    max = num2; 
}
if (max < num3)
{
    max = num3;
}    
    System.Console.Write("MAX = ");
    System.Console.WriteLine(max);
