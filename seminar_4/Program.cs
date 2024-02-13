/* Задачи семинара */
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