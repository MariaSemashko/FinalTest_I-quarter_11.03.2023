/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна З символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться, лучше обойтись исключительно массивами. */

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или не корректное число. Повторите ввод.");
        }
    }

    return result;
}


string[] InitArray(int initialArrayLength)
{
    string [] result = new string[initialArrayLength];

    for (int i = 0; i < result.Length; i++)
    {
        string temp = String.Empty;
        while (true)
        {
            Console.WriteLine("Введите следующий элемент массива: ");
            temp = Console.ReadLine();
            if (temp == "") Console.WriteLine("Некорректный ввод");
            else break;
        }
        
        result[i] = temp;
    }

    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] GetNewArray (string[] array)
{

    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            result = result + "," + array[i];
        }

    }
    
    string[] resultArray = result.Split(",");

    return resultArray;

}

int initialArrayLength = GetNumber("Введите длину исходного массива: ");
string[] initialArray = InitArray(initialArrayLength);
Console.WriteLine();
PrintArray(initialArray);
Console.WriteLine();
string[] newArray = GetNewArray(initialArray);
PrintArray(newArray);