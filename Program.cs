namespace Challenge2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string storedUserName = "Brennan";
            string storedPassword = "password";
            bool loginSuccess = false;

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("You have " + (3 - i) + " login attempts remaining");
                Console.WriteLine("Enter username");
                string userName = Console.ReadLine();
                Console.WriteLine("enter password");
                string password = Console.ReadLine();
                if (userName == storedUserName && password == storedPassword)
                {
                    loginSuccess = true;
                    break;
                }
                Console.WriteLine("login attempt failed");

            }
            if (loginSuccess)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Account locked");
            }
            ;
        }
    }
}
