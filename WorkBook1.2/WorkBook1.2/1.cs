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


Console.WriteLine("¬ведите номер дн€ недели, с которого начинаетс€ мес€ц (1-пн,...7-вс)");
byte dayBeginning = Convert.ToByte(Console.ReadLine());
Console.WriteLine("¬ведите день мес€ца");
int day = Convert.ToByte(Console.ReadLine());
Console.WriteLine("-----ѕровер€ем выходной ли день-----");
string restOrNot = Check(day,dayBeginning)? ("выходной") : ("рабочий день");
Console.WriteLine(restOrNot);