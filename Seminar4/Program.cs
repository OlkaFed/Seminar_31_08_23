// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2" 

Console.WriteLine("ВВедите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = num * -1;

while (num0<=num)
{
Console.Write(num0);
num0++;
}