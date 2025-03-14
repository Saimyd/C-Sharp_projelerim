using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AccountManagementSystem
{
    class Program
    {
        static List<User> users = new List<User>();
        static string usersFilePath = "users.txt";
        static string transactionsFilePath = "transactions.txt";

        static void Main(string[] args)
        {
            LoadUsers();
            int choice;

            do
            {
                Console.WriteLine("1. Kayıt Ol");
                Console.WriteLine("2. Giriş Yap");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminiz: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek.");
                        break;
                }
            } while (choice != 3);
        }

        static void Register()
        {
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Bu kullanıcı adı zaten kullanılıyor.");
            }
            else
            {
                users.Add(new User(username, password, 0));
                SaveUsers();
                Console.WriteLine("Kayıt başarılı.");
            }
        }

        static void Login()
        {
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("Giriş başarılı.");
                UserMenu(user);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı adı veya şifre.");
            }
        }

        static void UserMenu(User user)
        {
            int choice;
            do
            {
                Console.WriteLine("1. Hesap Bilgilerini Görüntüle");
                Console.WriteLine("2. Para Yatır");
                Console.WriteLine("3. Para Çek");
                Console.WriteLine("4. İşlem Geçmişini Görüntüle");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminiz: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewAccountDetails(user);
                        break;
                    case 2:
                        Deposit(user);
                        break;
                    case 3:
                        Withdraw(user);
                        break;
                    case 4:
                        ViewTransactionHistory(user);
                        break;
                    case 5:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek.");
                        break;
                }
            } while (choice != 5);
        }

        static void ViewAccountDetails(User user)
        {
            Console.WriteLine($"Kullanıcı Adı: {user.Username}");
            Console.WriteLine($"Bakiye: {user.Balance:C}");
        }

        static void Deposit(User user)
        {
            Console.Write("Yatırmak istediğiniz tutar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0)
            {
                user.Balance += amount;
                SaveUsers();
                RecordTransaction(user.Username, "Para Yatırma", amount);
                Console.WriteLine("Para yatırma başarılı.");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar.");
            }
        }

        static void Withdraw(User user)
        {
            Console.Write("Çekmek istediğiniz tutar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0 && amount <= user.Balance)
            {
                user.Balance -= amount;
                SaveUsers();
                RecordTransaction(user.Username, "Para Çekme", amount);
                Console.WriteLine("Para çekme başarılı.");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar veya yetersiz bakiye.");
            }
        }

        static void ViewTransactionHistory(User user)
        {
            if (File.Exists(transactionsFilePath))
            {
                var transactions = File.ReadAllLines(transactionsFilePath)
                                       .Select(line => line.Split(','))
                                       .Where(fields => fields[0] == user.Username)
                                       .Select(fields => new { Type = fields[1], Amount = decimal.Parse(fields[2]), Date = DateTime.Parse(fields[3]) })
                                       .ToList();

                Console.WriteLine("İşlem Geçmişi:");
                foreach (var transaction in transactions)
                {
                    Console.WriteLine($"{transaction.Date}: {transaction.Type} - {transaction.Amount:C}");
                }
            }
            else
            {
                Console.WriteLine("Henüz hiçbir işlem yapılmamış.");
            }
        }

        static void LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                var lines = File.ReadAllLines(usersFilePath);
                foreach (var line in lines)
                {
                    var fields = line.Split(',');
                    users.Add(new User(fields[0], fields[1], decimal.Parse(fields[2])));
                }
            }
        }

        static void SaveUsers()
        {
            var lines = users.Select(u => $"{u.Username},{u.Password},{u.Balance}");
            File.WriteAllLines(usersFilePath, lines);
        }

        static void RecordTransaction(string username, string type, decimal amount)
        {
            string record = $"{username},{type},{amount},{DateTime.Now}";
            File.AppendAllLines(transactionsFilePath, new[] { record });
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }

        public User(string username, string password, decimal balance)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }
    }
}
