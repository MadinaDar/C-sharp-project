String number1 = Console.ReadLine();
String number2 = Console.ReadLine();

int n1 = int.Parse (number1);
int n2 = int.Parse (number2);

if (n1 > n2)
{
    Console.Write ($"Number {n1} is greater than {n2}");
}
else if (n1 == n2)
{
    Console.Write ($"Number {n1} is equal to the number {n2}");
}
else
{
    Console.Write ($"Number {n2} is greater than {n1}");
}