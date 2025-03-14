using System;

public class MayDoChieuCaoCanNang
{
    public static void Main(string[] args)
    {
        Console.Write("Nhập một số nguyên không âm (tối đa 3 chữ số): ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0 || number > 999)
        {
            Console.WriteLine("Số không hợp lệ. Vui lòng nhập một số nguyên không âm có tối đa 3 chữ số.");
            return;
        }

        string result = NumberToWords(number);
        Console.WriteLine(result);
    }

    public static string NumberToWords(int number)
    {
        if (number < 10)
        {
            // Bước 2: Đọc số có một chữ số
            switch (number)
            {
                case 0: return "không";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "out of ability"; // Không cần thiết vì đã kiểm tra number >= 0
            }
        }
        else if (number < 20)
        {
            // Bước 3: Đọc số có hai chữ số nhỏ hơn 20
            switch (number)
            {
                case 10: return "mười";
                case 11: return "mười một";
                case 12: return "mười hai";
                case 13: return "mười ba";
                case 14: return "mười bốn";
                case 15: return "mười lăm";
                case 16: return "mười sáu";
                case 17: return "mười bảy";
                case 18: return "mười tám";
                case 19: return "mười chín";
                default: return "out of ability"; // Không cần thiết vì đã kiểm tra number < 20
            }
        }
        else if (number < 100)
        {
            // Bước 4: Đọc số có hai chữ số lớn hơn hoặc bằng 20
            int tens = number / 10;
            int ones = number % 10;
            string tensString = "";
            string onesString = "";

            switch (tens)
            {
                case 2: tensString = "hai mươi"; break;
                case 3: tensString = "ba mươi"; break;
                case 4: tensString = "bốn mươi"; break;
                case 5: tensString = "năm mươi"; break;
                case 6: tensString = "sáu mươi"; break;
                case 7: tensString = "bảy mươi"; break;
                case 8: tensString = "tám mươi"; break;
                case 9: tensString = "chín mươi"; break;
            }

            switch (ones)
            {
                case 0: onesString = ""; break;
                case 1: onesString = "một"; break;
                case 2: onesString = "hai"; break;
                case 3: onesString = "ba"; break;
                case 4: onesString = "bốn"; break;
                case 5: onesString = "lăm"; break;
                case 6: onesString = "sáu"; break;
                case 7: onesString = "bảy"; break;
                case 8: onesString = "tám"; break;
                case 9: onesString = "chín"; break;
            }

            return tensString + (onesString != "" ? " " + onesString : "");
        }
        else
        {
            // Bước 5: Đọc số có ba chữ số
            int hundreds = number / 100;
            int remainder = number % 100;
            string hundredsString = "";

            switch (hundreds)
            {
                case 1: hundredsString = "một trăm"; break;
                case 2: hundredsString = "hai trăm"; break;
                case 3: hundredsString = "ba trăm"; break;
                case 4: hundredsString = "bốn trăm"; break;
                case 5: hundredsString = "năm trăm"; break;
                case 6: hundredsString = "sáu trăm"; break;
                case 7: hundredsString = "bảy trăm"; break;
                case 8: hundredsString = "tám trăm"; break;
                case 9: hundredsString = "chín trăm"; break;
            }

            string remainderString = (remainder > 0) ? " và " + NumberToWords(remainder) : "";  // Thêm "và" nếu có phần còn lại

            return hundredsString + remainderString;
        }
    }
}