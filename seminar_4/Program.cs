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
/* Задача 2 семинара */
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