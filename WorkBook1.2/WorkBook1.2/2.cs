void Converter(int n)
{
    if (n%100!=0)
    {
        Console.WriteLine($"������ ������ ����� {n} ������, ����� �� ������� �� 100");
        return;
    }
    if (n > 150000)
    {
        Console.WriteLine($"������ ������ ������ {150000} ������");
        return;
    }
    int[] bills = new int[6];
    if (n >= 5000)
    {
        bills[0] = n / 5000;
        n -= 5000*bills[0];
        Console.WriteLine($"{bills[0]} �� {5000}");
    }
    if (n >= 2000)
    {
        bills[1] = n / 2000;
        n -= 2000 * bills[1];
        Console.WriteLine($"{bills[1]} �� {2000}");
    }
    if (n >= 1000)
    {
        bills[2] = n / 1000;
        n -= 1000 * bills[2];
        Console.WriteLine($"{bills[2]} �� {1000}");
    }
    if (n >= 500)
    {
        bills[3] = n / 500;
        n -= 500 * bills[3];
        Console.WriteLine($"{bills[3]} �� {500}");
    }
    if (n >= 200)
    {
        bills[4] = n / 200;
        n -= 200 * bills[4];
        Console.WriteLine($"{bills[4]} �� {200}");
    }
    if (n >= 100)
    {
        bills[5] = n / 100;
        n -= 100 * bills[5];
        Console.WriteLine($"{bills[5]} �� {100}");
    }
}


Console.WriteLine("������� ���������� ����� ��� �������������");
int n = Convert.ToInt32(Console.ReadLine());
Converter(n);


