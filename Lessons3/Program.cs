#region // Задание 1

//Task1();

void Task1()
{
    bool ext = false;
    do
    {
        string input = Console.ReadLine();
        if (GetNumberOrNot(input))
        {
            int writeNumber = Convert.ToInt32(input);
            ext = GetNumberEvenOrNot(GetSumNumber(writeNumber));
        }
        else
        {
            if (input == "q")
            {
                ext = true;
            }
        }

    } while (!ext);
}

bool GetNumberOrNot(string text)
{
    if (int.TryParse(text, out int number))
    {
        return true;
    }
    return false;
}

int GetSumNumber(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int remainder = number % 10;
        sum = sum + remainder;
        number = number / 10;
    }
    return sum;
}
bool GetNumberEvenOrNot(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    return false;
}


#endregion

#region // Задание 2 и 3

Task2();

void Task2()
{
    int arraySize = GetArraySize();
    int[] arrayRandom = RandomMas(new int[arraySize]);
    PrintArray(arrayRandom);
    Console.Write("Количество чётных чисел в массиве: ");
    Console.WriteLine(GetCoyntEvenNumbers(arrayRandom));
    arrayRandom = ReverseMas(arrayRandom);
    Console.WriteLine("Перевернутый массив:");
    PrintArray(arrayRandom);
}

int GetCoyntEvenNumbers(int[] array)
{
    int sumEvenNumber = 0;
    foreach (var item in array)
    {
        if (GetNumberEvenOrNot(item))
        {
            sumEvenNumber++;
        }
    }
    return sumEvenNumber;
}

int[] RandomMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
}

void PrintArray(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int GetArraySize()
{
    string input;
    do
    {
        Console.Write("Введи размер массива: ");
        input = Console.ReadLine();
    } while (!GetNumberOrNot(input));
    int writeNumberForMas = Convert.ToInt32(input);
    return writeNumberForMas;
}

#endregion

#region // Функция для задания 3

int[] ReverseMas(int[] mas)
{
    int[] newArray = new int[mas.Length];
    int k = 0;
    for (int i = mas.Length - 1; i >= 0; i--)
    {
        newArray[k] = mas[i];
        k++;
    }
    return newArray;
}

#endregion