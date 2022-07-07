// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int TwoNum(int a, int b)
{
    int n_two = a;

    for(int i = 2; i < b; i++)
    {
        n_two *= a;
    }
    return n_two;
}
Console.WriteLine(TwoNum(2, 2));
Console.WriteLine(TwoNum(3, 3));

