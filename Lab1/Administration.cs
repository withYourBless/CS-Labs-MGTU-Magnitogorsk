namespace Lab1;

public static class Administration
{
    public static void RequestToDoJob(Staff worker)
    {
        worker.DoJob();
    }

    public static void EmployNewWorker(string name, string position)
    {
        if (position == "engineer")
        {
            var engineer = new Engineer(name);
            engineer.AddNewWorker();
        }
        else
        {
            var labor = new Labor(name);
            labor.AddNewWorker();
        }
    }
}