class PemrosesData
{
    public int DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        dynamic val1 = nilai1, val2 = nilai2, val3 = nilai3;

        if (val1 >= val2 && val1 >= val3)
        {
            return val1;
        }
        else if (val2 >= val1 && val2 >= val3)
        {
            return val2;
        }
        else
        {
            return val3;
        }
    }
}

class Program
{
    public static void Main()
    {
        int nilai1 = 10, nilai2 = 30, nilai3 = 22;

        PemrosesData pemrosesData = new PemrosesData();
        int nilaiTerbesar = pemrosesData.DapatkanNilaiTerbesar<int>(nilai1, nilai2, nilai3);

        Console.WriteLine($"Nilai Terbesar: {nilaiTerbesar}");
    }
}