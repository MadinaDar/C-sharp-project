void OneOfNum(int num1)
{
    if (num1 % 7 == 0 && num1 % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

OneOfNum(16);
OneOfNum(161);