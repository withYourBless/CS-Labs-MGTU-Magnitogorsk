namespace Lab1;

public class Labor : Staff
{
    public Labor(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
    public override void DoJob()
    {
        System.Console.WriteLine("Labor: I've done my work");
    }

    public override void AddNewWorker()
    {
        WorkerList.Add(this);
    }
}