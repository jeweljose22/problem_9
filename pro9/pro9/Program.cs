using System.Diagnostics.CodeAnalysis;

DateTime[] dob = new DateTime[2];
TimeSpan[] ts1 = new TimeSpan[2];

//DateTime dob = DateTime.Parse(Console.ReadLine());
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(" dob of " + (i + 1));
    dob[i] = Convert.ToDateTime(Console.ReadLine());
    ts1[i] = DateTime.Now - dob[i];

}
for (int i = 0;i < 2; i++)
{
    int age = ts1[i].Days / 365;
        Console.WriteLine("age "+ age );
    if (age<10)
    {
        Console.WriteLine("KID");
    }
    else if (age>10 && age<30)
    {
        Console.WriteLine("YOUTH");
    }
    else if (age > 30 && age < 60)
    {
        Console.WriteLine("ADULT");
    }
    else
    {
        Console.WriteLine("older");
    }
}
