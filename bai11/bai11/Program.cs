using System;
using System.Text;
class program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int count = 0;
        int number = 2;
        Console.Write("20 số nguyên tố đầu tiên là: ");
         while (count < 20)
        {
            if (soNguyenTo(number))
            {
               count++;
                Console.Write(number+" ");
            }
            number++; // ktra số tiếp theo
        }

        }
    static bool soNguyenTo(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++) 
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true; 
    }

}
