// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static System.Console;
Clear();

WriteLine("Введите пятизначноечисло N");
string result = Convert.ToString (ReadLine());
if (result.Length == 5)
{
    if (result[0]==result [4] && result[1]==result [3])
    {
    WriteLine("Да");
    }
    else
    {
    WriteLine("Нет");  
    }
}
else
{
        WriteLine("Некорректный ввод");
}