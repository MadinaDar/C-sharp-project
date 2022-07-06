void OneOfNum(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"{num1}, {num2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num1}, {num2} -> not multiple, the remainder {num1 % num2}");
    }
}

OneOfNum(16,4);
OneOfNum(22,4);
