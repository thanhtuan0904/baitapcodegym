using System;

public class SoNgayTrongThang
{
    public static void Main(string[] args)
    {
        Console.Write("Nhập tháng (1-12): ");
        int thang = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập năm: ");
        int nam = Convert.ToInt32(Console.ReadLine());

        int soNgay = TinhSoNgayTrongThang(thang, nam);

        if (soNgay != -1)
        {
            Console.WriteLine($"Tháng {thang} năm {nam} có {soNgay} ngày.");
        }
        else
        {
            Console.WriteLine("Tháng không hợp lệ. Vui lòng nhập tháng từ 1 đến 12.");
        }
    }

    public static int TinhSoNgayTrongThang(int thang, int nam)
    {
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                if (LaNamNhuan(nam))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            default:
                return -1; // Tháng không hợp lệ
        }
    }

    public static bool LaNamNhuan(int nam)
    {
        return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
    }
}