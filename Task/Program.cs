/* 
Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых <= 3 символа.

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллециями, лучше обойтись исключительно массивами.

Примеры :

* ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]

* ["1234", "1567", "-2"] -> ["-2"]

* ["Russia", "Denmark", "Kazan"] -> [] 
*/

Console.Clear(); // Метод очистки консоли после каждого ввода.


int Prompt(string message) // Метод ввода с консоли строки и конвертации его в число.
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

string[] CreateArray(int lenght) // Метод создания одномерного массива, который принимает аргумент целого числа.
{
    string[] array = new string[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}

void PrintArray(string[] array) //Статический метод печати массива.
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] CheckingNumbersArray(string[] newArray) //Метод форматирования массива из строк при помощи сравнения символов строки.
{
    string[] array = new string[newArray.Length];
    string empty = String.Empty;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3) Console.Write(newArray[i] + " ");
    }
    return array;
}

int value = Prompt("Задайте длину массива (например > 5)"); // Создаем и присваиваем переменной value значение метода Prompt.

string[] myArray = CreateArray(value);
Console.Write($"Массив длиною [{value}] > ");
PrintArray(myArray);

Console.Write("Результат > ");
string[] formattedArray = CheckingNumbersArray(myArray);
PrintArray(formattedArray);