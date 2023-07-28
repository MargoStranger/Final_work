/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] Array = {"Hello", "2", "world", ":-)"};
Console.Write($"Массив с элементами длиной меньше или равной 3: ");
Array_Output(FindElements(Array));


string[] FindElements(string Array)
{
    string New_Array = new string (Array.Length);
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            New_Array[i] = Array[i];
        }
    }
    return New_Array;
}

void Array_Output (string array)
{
    for (int i = 0; i < array.length; i++)
    {
        Console.Write($" {array[i]},");
    }
}