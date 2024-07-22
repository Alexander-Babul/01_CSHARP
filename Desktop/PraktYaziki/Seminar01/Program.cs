// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

int firstValue = 25;
int secodValue = 5;

if(firstValue == secodValue * secodValue) // true
{
    Console.WriteLine($"a = {firstValue}, b = {secodValue} => Да");
}
else{
    Console.WriteLine("Нет");
}

int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(chislo + 3);
