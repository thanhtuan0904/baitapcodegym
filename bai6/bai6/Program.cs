using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số cần đọc: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine(SoThanhChu(number));
        }
        else
        {
            Console.WriteLine("Dữ liệu không hợp lệ");
        }
    }

    static string SoThanhChu(int num)
    {
        if (num < 0 || num > 999)
            return "ngoài khả năng";

        if (num == 0)
            return "không";

        string result = "";
        int tram = num / 100;
        int chuc = (num % 100) / 10;
        int donVi = num % 10;

        if (tram > 0)
        {
            switch (tram)
            {
                case 1: result += "một trăm"; break;
                case 2: result += "hai trăm"; break;
                case 3: result += "ba trăm"; break;
                case 4: result += "bốn trăm"; break;
                case 5: result += "năm trăm"; break;
                case 6: result += "sáu trăm"; break;
                case 7: result += "bảy trăm"; break;
                case 8: result += "tám trăm"; break;
                case 9: result += "chín trăm"; break;
            }
            if (num % 100 != 0)
                result += " ";
        }

        if (chuc == 1)
        {
            switch (num % 100)
            {
                case 10: result += "mười"; break;
                case 11: result += "mười một"; break;
                case 12: result += "mười hai"; break;
                case 13: result += "mười ba"; break;
                case 14: result += "mười bốn"; break;
                case 15: result += "mười lăm"; break;
                case 16: result += "mười sáu"; break;
                case 17: result += "mười bảy"; break;
                case 18: result += "mười tám"; break;
                case 19: result += "mười chín"; break;
            }
        }
        else if (chuc > 1)
        {
            switch (chuc)
            {
                case 2: result += "hai mươi"; break;
                case 3: result += "ba mươi"; break;
                case 4: result += "bốn mươi"; break;
                case 5: result += "năm mươi"; break;
                case 6: result += "sáu mươi"; break;
                case 7: result += "bảy mươi"; break;
                case 8: result += "tám mươi"; break;
                case 9: result += "chín mươi"; break;
            }
            if (donVi != 0)
                result += " ";
        }

        if (chuc != 1 && donVi > 0)
        {
            switch (donVi)
            {
                case 1: result += "một"; break;
                case 2: result += "hai"; break;
                case 3: result += "ba"; break;
                case 4: result += "bốn"; break;
                case 5: result += "năm"; break;
                case 6: result += "sáu"; break;
                case 7: result += "bảy"; break;
                case 8: result += "tám"; break;
                case 9: result += "chín"; break;
            }
        }

        return result;
    }
}