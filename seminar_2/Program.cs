﻿/* Первая задача семинара
//Напишите программу, которая принимает на вход
//трёхзначное число и удаляет вторую цифру этог числа.
//Примеры:
//a = 256 => 26
//a = 891 => 81

int number = 947;
int firstDigit = number / 100; // 453 / 100 = 4
int thirdDigit = number % 10; // 453 % 10 = 3
int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43
// $"Текст {result} текст {a+100} текст {a - 500}"
Console.WriteLine($"В числе {number} => {result}");
*/

/* Вторая задача семинара
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int initialNumber = 369;

int secondDigit = initialNumber/10%10;
int thirdDigit = initialNumber%10;
int result = (int)Math.Pow (secondDigit, thirdDigit);
Console.WriteLine ($"{secondDigit} ^ {thirdDigit} = {result}");
*/

/*Третья задача семинара*/
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

int number = 235443;
if(number >= 100)
{
    int thirdDigEnd = (number /100) %10;
    Console.WriteLine ($"Третья цифра с конца в числе {number} равна {thirdDigEnd}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}