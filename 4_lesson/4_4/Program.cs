// SНапишите прогр, кот выводит массив из 8 эл, заполнен 0 и 1 в случайном порядке

void Arr()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array [i]= new Random().Next(0,2);
        Console.Write ($"{array [i]} " );
    }
}

Arr();