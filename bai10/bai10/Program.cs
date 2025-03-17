using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Mời nhập số: ");
        int sont = Convert.ToInt32(Console.ReadLine());

        if (sont < 2)
        {
            Console.WriteLine($"{sont} không phải là số nguyên tố.");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(sont); i++)
            {
                if (sont % i == 0)
                {
                    isPrime = false;
                    break; // Nếu tìm thấy ước số, dừng vòng lặp ngay
                }
            }

            if (isPrime)
                Console.WriteLine($"{sont} là số nguyên tố.");
            else
                Console.WriteLine($"{sont} không phải là số nguyên tố.");
        }
    }
}
