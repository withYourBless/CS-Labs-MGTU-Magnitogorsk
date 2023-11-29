namespace Lab1;

public class Engineer : Staff
{
    public Engineer(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
    public override void DoJob()
    {
        System.Console.WriteLine("Engineer: I've done my work");
    }

    public override void AddNewWorker()
    {
        WorkerList.Add(this);
    }
}