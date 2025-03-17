using System;

class program
{
    static void Main(string[] args)
    {
        //    int[] arrNames = null;
        //    arrNames = new int[] { 1, 2, 3, 4 };
        //    arrNames = new int[5];
        //    arrNames[1] = 3;
        //    Console.WriteLine(arrNames[1]);
        //    foreach (int i in arrNames)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //    for (int i = 0; i < arrNames.Length; i++)
        //    {
        //        Console.Write("hoang ");
        //    }
        //}
        //public int number;

        int[] number = new int[5] { 1, 2, 3, 4, 5 };
        int count = 0;

        foreach (int i in number)
        {
            count = count + i;
        }
        Console.WriteLine(count);

    }
}