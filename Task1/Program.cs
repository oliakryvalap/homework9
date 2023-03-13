// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

System.Console.WriteLine(ReturnNumber(PutNumber("Введите m :")));

int PutNumber(string message)
{
System.Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
string ReturnNumber(int m)
{
    if(m > 1) return (m - "");
    else 
    return m - " " + ReturnNumber(m - 1);
}