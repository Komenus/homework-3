// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine());
double cube = 1;
int count = 1;
while(count <= N )
{
    cube = Math.Pow(count, 3);
    Console.WriteLine($"Куб числа {count} : {cube}");
    count ++;
}