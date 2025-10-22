internal class Program
{
    private static void Main(string[] args)
    {
        const string USERNAME = "root";
        const string PASSWORD = "toor";
        const int MAX_ATTEMPTS = 3;
        int currentAttempts = 1;
        bool accessGranted = false;

        while (currentAttempts <= MAX_ATTEMPTS && !accessGranted)
        {
            Console.WriteLine($"Attempt {currentAttempts} of {MAX_ATTEMPTS}");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == USERNAME && password == PASSWORD)
            {
                accessGranted = true;
            }
            else
            {
                Console.WriteLine("Error: Username and/or password incorrect.");
                currentAttempts++;
            }
        }

        if (accessGranted)
            Console.WriteLine("Access granted");
        else
            Console.WriteLine("This incident will be reported.");
    }
}