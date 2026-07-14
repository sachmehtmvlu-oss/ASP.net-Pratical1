using System;
class Floyd
{
    static void Main(string[] args)
    {
        int count = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Sachin Ramesh Mehta");
    }
}