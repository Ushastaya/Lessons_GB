#region // Задание 1

EnterUntilYouEnterOutputValue();

void EnterUntilYouEnterOutputValue()
{
    bool ext = false;
    do
    {
        string input = Console.ReadLine();
        if (GetNumberOrNot(input))
        {
            int writeNumber = Convert.ToInt32(input);
            ext = GetSumNumberEvenOrNot(writeNumber);
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

bool GetSumNumberEvenOrNot(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int remainder = number % 10;
        sum = sum + remainder;
        number = number / 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}
#endregion

