// Задание 1
void VvediNumberPokaNeVvedeshChetnoeOrQ()
{
    bool ext = false;
    do
    {
        string input = Console.ReadLine();
        if (GetNumberOrNot(input))
        {
            int writeNumber = Convert.ToInt32(input);
            ext = GetEvenNumberOrNot(writeNumber);
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

bool GetEvenNumberOrNot(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    return false;
}
