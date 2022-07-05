// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "No";
    if (num == 6 || num == 7) text = "Yes";
    Console.WriteLine($"{num} -> {text}");
}
Weekend (3);
Weekend (7);
Weekend (1);