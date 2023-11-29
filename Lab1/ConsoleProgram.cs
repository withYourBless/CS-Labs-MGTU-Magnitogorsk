namespace Lab1;

internal static class ConsoleProgram
{
    public static void Main()
    {
        while (true)
        {
            System.Console.WriteLine("\nWhat do you want to do?\n" +
                                     "1. Employ new worker\n" +
                                     "2. Request to do job\n" +
                                     "3. Exit\n");
            string answer = Console.ReadLine()!;
            if (answer == "1")
            {
                System.Console.WriteLine("\nWhich of worker?\n" +
                                         "1. Engineer\n" +
                                         "2. Labor");
                answer = Console.ReadLine()!;
                System.Console.WriteLine("Write name:");
                string name = Console.ReadLine()!;
                if (answer == "1")
                    Administration.EmployNewWorker(name, "engineer");
                if (answer == "2")
                    Administration.EmployNewWorker(name, "labor");
            }

            if (answer == "2")
            {
                System.Console.WriteLine("\nWhich of worker?\n" +
                                         "1. Engineer\n" +
                                         "2. Labor");
                answer = Console.ReadLine()!;
                if (answer == "1")
                    Administration.RequestToDoJob(new Engineer(""));
                if (answer == "2")
                   Administration.RequestToDoJob(new Labor(""));
            }
            if (answer == "3")
                break;
        }
    }
}