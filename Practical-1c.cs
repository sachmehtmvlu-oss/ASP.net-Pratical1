using System;
class fylod
{
    static void Main()
    {
        string[] city = new string[5];
        Console.WriteLine("Sachin Ramesh Mehta");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter city name: ");
            city[i] = Console.ReadLine();
        }
        city.Sort();
        Console.WriteLine("------------sorted-------------");
        for (int i = 0; i < city.Length; i++)
        {
            Console.WriteLine(city[i]);
        }
    }
}