/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] - strind - [st[1]] 
["1234", "1567", "-2", "computer science"] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] Array = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
int ArrayLength = Array.Length;

Console.Write($"Массив с элементами длиной меньше или равной 3: [");
Array_Output(FindElements(Array, ArrayLength));


//Метод поиска длины массива
int Get_Count_Elements (string[] Array, int size)
{
    int Count_Elements = 0;
    for (int i = 0; i < size; i++)
    {
        if (Array[i].Length <= 3)
        {
            Count_Elements += 1;
        }
    }
    return Count_Elements;
}

//Метод  поиска элементов
string[] FindElements(string[] Array, int size)
{
    string[] New_Array = new string [Get_Count_Elements(Array, size)];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (Array[i].Length <= 3)
        {
            New_Array[j] = Array[i];
            j += 1;
        }
    }
    return New_Array;
}

//Метод вывода массива
void Array_Output (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write("]");
}