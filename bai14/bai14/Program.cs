using System;

class program
{
    static void Main(string[] args)
    {
        string[] students = { "tuan", "an", "phong", "tung", "quan", "son" };
        Console.Write("nhap ten 1 hoc sinh:");
        string input_name = Console.ReadLine();

        bool inExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == input_name)
            {
                Console.WriteLine("vi tri hoc sinh "+input_name+" trong danh sach la : " + (i + 1));
                inExist = true;
                break;
            }
        }
        if (!inExist)
        {
            Console.WriteLine("ko thay hoc sinh");
        }
    }
}