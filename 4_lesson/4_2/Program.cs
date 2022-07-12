// Напишите прогр, кот принимает на вход число и выдает количество цифр в числе.

int CountNum(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(CountNum(675776));
