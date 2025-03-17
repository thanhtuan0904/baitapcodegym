using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Các số nguyên tố nhỏ hơn 100:");
        for (int i = 2; i < 100; i++)
        {
            if (soNguyenTo(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool soNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++) //
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
