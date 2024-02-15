/* Задача 1 семинара 
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3] => 2

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for(int i =0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

int GetCount (int[] arr)
{
    int count = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if(arr[i]%7 == 0 && arr[i]%10 ==1) count++;
    }
    return count;
}

Console.Write ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] result_arr = CreateArray(N); //создан массив случайных чисел из N элементов
Console.WriteLine ($"Массив: [ {string.Join(";", result_arr)} ]");
Console.WriteLine ($"Результат: {GetCount(result_arr)}");
*/
//---------------------------------------------------------------
/* Задача 2 семинара 
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for(int i =0; i<array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

int ConvertArrayToInteger (int[] arr)
{
    int res = 0;
    for (int i = 0, j = arr.Length-1; i<arr.Length; i++, j--)
    {
        res = res + arr[i] * (int)Math.Pow(10, j);
    }
    return res;
}

Console.Write ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] result_arr = CreateArray(N); //создан массив случайных чисел из N элементов
Console.WriteLine ($"Массив: [ {string.Join(";", result_arr)} ]");
Console.WriteLine ($"Результат: {ConvertArrayToInteger(result_arr)}");
*/
//---------------------------------------------------------------
/*Домашняя работа
// Задача 1
//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string text = Console.ReadLine();
    if (text == "q") // Проверка на ввод 'q' для выхода
    {
        break;
    }

    int number;
    if (int.TryParse(text, out number)) // Проверка, является ли ввод числом
    {
        int sum = 0;
        while (number > 0)
        {
            sum = sum + number % 10;
            //Console.Write(sum);
            number /= 10;
        }
        if (sum % 2 == 0) break;
    }
    else // Если ввод не является числом и не 'q', повторить запрос
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}
*/
//---------------------------------------------------------------
/* Задача 2
//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Задайте количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
}
Console.Write($"[ {string.Join(";", arr)} ]");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0) count++;
}
Console.WriteLine ();  
Console.WriteLine ($"Количество четных чисел в массиве = {count}");
*/
//---------------------------------------------------------------
/* Задача 3 */
//Напишите программу, которая перевернёт одномерный массив (первый элемент 
//станет последним, второй – предпоследним и т.д.)

int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
int temp;
// Вывод исходного массива
Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
// Реверсирование массива
for (int i = 0; i < numbers.Length / 2; i++)
{
    // Меняем местами элементы
    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}
// Вывод измененного массива
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine ();