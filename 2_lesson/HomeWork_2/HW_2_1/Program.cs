﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

int NumSec(int num)
{
    return num / 10 % 10;
}

Console.WriteLine(NumSec(876));


