using System;

public class InsertIntoArray
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Mảng ban đầu: [" + string.Join(", ", arr) + "]");

        Console.Write("Nhập giá trị cần chèn: ");
        int value = int.Parse(Console.ReadLine());

        Console.Write("Nhập vị trí cần chèn (index, bắt đầu từ 0): ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index > arr.Length)
        {
            Console.WriteLine("Lỗi: Vị trí chèn không hợp lệ.");
            return; // Kết thúc chương trình nếu index không hợp lệ
        }

        int[] newArr = new int[arr.Length + 1];

        // Sao chép các phần tử từ mảng ban đầu vào mảng mới và chèn giá trị vào vị trí mong muốn
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == index)
            {
                // Chèn giá trị vào vị trí index
                newArr[i] = value;
            }
            else
            {
                // Sao chép phần tử từ mảng ban đầu
                newArr[i] = arr[j];
                j++;
            }
        }

        // In mảng mới
        Console.WriteLine("Mảng sau khi chèn: [" + string.Join(", ", newArr) + "]");
    }
}