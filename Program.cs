class SimpleDataBase<T>
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
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();

        simpleDataBase.AddNewData(10);
        simpleDataBase.AddNewData(30);
        simpleDataBase.AddNewData(22);

        simpleDataBase.PrintAllData();
    }
}