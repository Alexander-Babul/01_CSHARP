// Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 => 7
// 44, 5, 78 => 78
// 22, 3, 9 => 22

Console.Write("Напишите первое число: ");
int firsnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите третье число: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());

int maximal = firsnumber;

if(secondnumber > maximal)
{
    int max = secondnumber;
}

if(thirdnumber > maximal)
{
    int max = secondnumber;
}

Console.Write($"Максимальное число = {maximal}");