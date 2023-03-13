// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine(SumNumber(PutNumber("Введите m :"), PutNumber("Введите n :")));

int PutNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
string SumNumber(int n, int m)

{
    if (n == 0 || m == 0) return (0);
    if (n < m || n > m)
    {       
        return (SumNumbers(n + 1, m)); 
        Console.Write($"{n} ");
    }
    if (n==m)
    {
        Console.Write($"{n} "); return;
    }
}
SumNumbers(m, n);
