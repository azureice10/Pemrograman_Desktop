
namespace UserManagement
{
    // class user
    class User
    {
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    class Program
    {
        static readonly List<User> users = new();

        
        static void Main()
        {
            // menampilkan menu utama
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input tidak valid!");
                        break;
                }
            }
        }

        static void Register()
        {
            Console.Write("Input nama: ");
            string name = Console.ReadLine();

            Console.Write("Input username: ");
            string username = Console.ReadLine();

            Console.Write("Input password: ");
            string password = "";

            // masking inputan password
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            
            // ditambah objek user ke list user
            User user = new ()
            {
                Name = name,
                Username = username,
                Password = password
            };

            users.Add(user);

            Console.WriteLine("User berhasil didaftarkan");
        }

        static void Login()
        {
            Console.Write("Input username: ");
            string username = Console.ReadLine();

            Console.Write("Input password: ");
            string password = "";
            // masking password
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();

            // matching username dan password
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine($"Selamat datang {user.Name}!");
                    return;
                }
            }

            Console.WriteLine("Username atau password tidak valid.");
        }

        static void Search()
        {
            Console.Write("Input nama untuk mencari user: ");
            string name = Console.ReadLine();

            foreach (User user in users)
            {
                // pencarian berdasarkan nama
                if (user.Name.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"Name: {user.Name}, Username: {user.Username}");
                }
            }
        }
    }
}
