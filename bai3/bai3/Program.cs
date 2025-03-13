using System;

class Program
{
    static void Main()
    {
        Console.Write("nhập năm :");
        int nam = Convert.ToInt32(Console.ReadLine());

        if (nam % 4 == 0 && nam % 100 != 0 )
        {
            Console.WriteLine(" nam nhuan");
        }
        else if(nam %400 == 0)
        {
            Console.WriteLine("nam nhuan");
        }
        else 
        {
            Console.WriteLine("nam khong nhuan");
        }
    }
}