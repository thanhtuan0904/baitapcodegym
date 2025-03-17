using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int gcd = USCLN(a, b);
        Console.WriteLine($"Ước số chung lớn nhất của {a} và {b} là: {gcd}");
    }

    static int USCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a); // Đảm bảo kết quả luôn dương
    }
}
