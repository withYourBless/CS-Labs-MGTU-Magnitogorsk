using System.ComponentModel;

namespace Lab1;

public abstract class Staff
{
    public ICollection<Staff> WorkerList { get; protected set; } = new List<Staff>();
    public abstract void DoJob();

    public abstract void AddNewWorker();
}