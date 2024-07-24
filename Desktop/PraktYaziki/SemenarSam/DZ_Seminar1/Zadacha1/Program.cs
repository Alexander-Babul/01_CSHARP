// // DZ 1
// Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.
// a=5;b=7 => max=7, min=5
// a=2;b=10 => max=10, min=2
// a=-9;b=-3 => max=-3, min=-9


// Первый вариант решения:

Console.Write("Напишите первое число: ");
int firsnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if(firsnumber > secondnumber)
{
    int maxnumber = firsnumber;
    int minnumber = secondnumber;
    Console.Write($"Максимальное число = {maxnumber}, минимальное число = {minnumber}");
}
else
{
    int maxnumber = secondnumber;
    int minnumber = firsnumber;
    Console.Write($"Максимальное число = {maxnumber}, минимальное число = {minnumber}");
}