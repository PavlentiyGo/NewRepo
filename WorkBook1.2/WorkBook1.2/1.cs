static bool Check(int day,byte dayBeginning)
{
    if (day>=1 && day<=5 || day>=8 && day <= 10)
    {
        return true;
    }
    day = day % 7;
    if (day == 7-dayBeginning || day == 8 - dayBeginning)
    {
        return true;
    }
    return false;
}


Console.WriteLine("������� ����� ��� ������, � �������� ���������� ����� (1-��,...7-��)");
byte dayBeginning = Convert.ToByte(Console.ReadLine());
Console.WriteLine("������� ���� ������");
int day = Convert.ToByte(Console.ReadLine());
Console.WriteLine("-----��������� �������� �� ����-----");
string restOrNot = Check(day,dayBeginning)? ("��������") : ("������� ����");
Console.WriteLine(restOrNot);