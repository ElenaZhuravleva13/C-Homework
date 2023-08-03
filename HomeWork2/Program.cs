/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int max = 0;

Console.WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > max)
{
    max = FirstNumber;
}
if (SecondNumber > max)
{
    max = SecondNumber;
}
if (ThirdNumber > max)
{
    max = ThirdNumber;
}

Console.WriteLine("max = " + max);