// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kaz" };

int length_string = 3;

int value_elements = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= length_string)
    {
        value_elements++;
    }
}

string[] result_array = new string[value_elements];

for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length <= length_string)
    {
        result_array[j] = array[i];
        j++;
    }
}


PrintArray(result_array);




void PrintArray(string[] array)
{
    for (int i = 0; i < result_array.Length; i++)        //вывод массива на экран
    {
        Console.Write($" {array[i]}");
    }
}