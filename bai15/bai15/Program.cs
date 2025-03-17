using System;
using System.Text;

class program
{
    private static int n;

    static void Main(string[] args)
    {
        int n;
        Console.OutputEncoding = Encoding.UTF8;
        do
        {
            Console.Write("mời nhập số tỷ phú:");
         n = Convert.ToInt32(Console.ReadLine());
            if (n > 20)
            {
                Console.WriteLine("mời nhập số lượng bé hơn 20.");
            }
        } while (n > 20);

        int[] arr = new int[n];

        Console.WriteLine("Mời nhập giá trị tài sản của các tỷ phú:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("tài sản tỷ phú thứ " + (i + 1) + " là:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("danh sách tài sản tỷ phú:");
        foreach (int value in arr)
        {
            Console.WriteLine(value+"\t");
        }
        Console.WriteLine();

        int max = arr[0];
        int index = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                index = i + 1;
            }
        }
        Console.WriteLine($"Tỷ phú giàu nhất có tài sản là {max} tại vị trí {index}");

    }
}