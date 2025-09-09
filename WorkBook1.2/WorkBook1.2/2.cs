void Converter(int n)
{
    if (n%100!=0)
    {
        Console.WriteLine($"Нельзя выдать ровно {n} рублей, число не делится на 100");
        return;
    }
    if (n > 150000)
    {
        Console.WriteLine($"Нельзя выдать больше {150000} рублей");
        return;
    }
    int[] bills = new int[6];
    if (n >= 5000)
    {
        bills[0] = n / 5000;
        n -= 5000*bills[0];
        Console.WriteLine($"{bills[0]} по {5000}");
    }
    if (n >= 2000)
    {
        bills[1] = n / 2000;
        n -= 2000 * bills[1];
        Console.WriteLine($"{bills[1]} по {2000}");
    }
    if (n >= 1000)
    {
        bills[2] = n / 1000;
        n -= 1000 * bills[2];
        Console.WriteLine($"{bills[2]} по {1000}");
    }
    if (n >= 500)
    {
        bills[3] = n / 500;
        n -= 500 * bills[3];
        Console.WriteLine($"{bills[3]} по {500}");
    }
    if (n >= 200)
    {
        bills[4] = n / 200;
        n -= 200 * bills[4];
        Console.WriteLine($"{bills[4]} по {200}");
    }
    if (n >= 100)
    {
        bills[5] = n / 100;
        n -= 100 * bills[5];
        Console.WriteLine($"{bills[5]} по {100}");
    }
}


Console.WriteLine("Введите количество денег для обналичивания");
int n = Convert.ToInt32(Console.ReadLine());
Converter(n);


