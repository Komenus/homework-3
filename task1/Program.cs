// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int N = int.Parse(Console.ReadLine());
// Console.WriteLine(N / 10000);
// Console.WriteLine(N % 10);
// Console.WriteLine((N - N / 10000 * 10000) / 1000);
// Console.WriteLine(N /10 % 10);
if (N >99 && N < 100000)
{
    if (N / 10000 == N % 10 && (N - N / 10000 * 10000) / 1000 == N /10 % 10)
    {
        Console.WriteLine("Число палидром ");
    }
    else
    {
         Console.WriteLine("Число  не палидром ");
    }
}
else 
     Console.WriteLine("Вы ввели некорректное число ");