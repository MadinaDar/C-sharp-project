// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 14212 -> нет 12821 -> да

void Polindrom(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "Yes";

    while (i < size / 2)
    {
        if (num[i] != num [size - i])
        {
            flag = "No";
            break;
        }
        i += 1;    
    }
    Console.WriteLine($"{n} -> {flag}");
}

Polindrom(156789);
Polindrom(21712);
Polindrom(1237321);
Polindrom(156789);

