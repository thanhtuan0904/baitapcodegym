using System;
using System.ComponentModel.Design;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;


        Console.WriteLine("Chọn số để in ra hình :");
        Console.WriteLine("1-hình vuông");
        Console.WriteLine("2- Hình Chữ Nhật");
        Console.WriteLine("3- Hình Tam Giác Vuông");
        Console.WriteLine("4- Hình Tam Giác Vuông Ngược");

        Console.Write("mời nhập số:");
        int n = Convert.ToInt32(Console.ReadLine());

        // hv
        if (n == 1)
        {
            for (int i = 0; i < 7; i++)

            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" " + "*");

                }
                Console.WriteLine("\t");
            }
        }
        else if (n == 2)
        {
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" " + "*");

                }
                Console.WriteLine("\t");
            }
        }
        else if (n == 3)
        {
            for (int i = 7; i > 0; i--)
            {
                for (int j = i; j < 7; j++)
                {
                    Console.Write(" " + "*");

                }
                Console.WriteLine("\t");

            }
        }
        else if (n == 4)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    Console.Write(" " + "*");

                }
                Console.WriteLine("\t");

            }

        }
        else if (n == 5)
        {
            Console.Write("Nhập chiều cao tam giác (m): ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
