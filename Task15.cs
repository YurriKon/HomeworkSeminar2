/*
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Entry:
Console.WriteLine("Введите цифру от одного до семи");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7) goto Entry;
if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день выходной");
}
else 
{
    Console.WriteLine("Это рабочий день");
}
*/