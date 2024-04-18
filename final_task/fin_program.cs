// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
//задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//ввод массива с клавиатуры
void createArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент под индексом {i}:\t ");
        array[i] = Console.ReadLine();
    }
}

// подсчет количества элементов массива с длиной строки меньше или равно 3
int CountArray(string[] arr)
{
    int newSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newSize++;
        }
    }
    return newSize;
}

Console.Write("Введите количество элементов массива\t");
int N = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[N];
createArray(inputArray);

Console.WriteLine("Исходный массив:");

for (int i = 0; i < inputArray.Length; i++)
{
    Console.Write(inputArray[i]);
    Console.Write("\t");
}
