namespace Login
{
    class Program
    {


        static void Main(string[] args)
        {
            var arrUsers = new Users[]
            {
            new Users("wayne","admin123"),
            new Users("dave","demo123"),
            new Users("steve","me123")
            };

            Console.WriteLine("Write your username:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();

            int MaxAttempts = 3;


            foreach (Users user in arrUsers)
            {
                if (username == user.username && password == user.password)
                {
                    Console.WriteLine($"Welcome [username]");
                    Console.ReadLine();
                    break;
                }
            }

            if (username != "username" || password != "password")
            {
                MaxAttempts++;

            }
            if (MaxAttempts > 2)
                Console.WriteLine("Login failure");
        }



        public class Users
        {
            public string username;
            public string password;
   
            public Users(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
        }
    }
}