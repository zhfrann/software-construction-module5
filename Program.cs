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


﻿class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>(); 
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {this.storedData[i]}, yang disimpan pada waktu UTC: {this.inputDates[i].ToString()}");
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
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();

        simpleDataBase.AddNewData(10);
        simpleDataBase.AddNewData(30);
        simpleDataBase.AddNewData(22);

        simpleDataBase.PrintAllData();
    }
}