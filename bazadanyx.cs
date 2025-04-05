using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База 
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public User(string name, int id, bool isActive)
        {
            Name = name;
            Id = id;
            IsActive = isActive;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }

    public class UserDatabase
    {
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void ActivateUser(int userID)
        {
            User user = users.Find(u => u.Id == userID);
            if (user != null)
            {
                user.Activate();
                Console.WriteLine("пользователь активирован.");
            }
            else
            {
                Console.WriteLine("пользователь с таким id не найден");
            }
        }

        public void DeactivateUser(int userID)
        {
            User user = users.Find(u => u.Id == userID);
            if (user != null)
            {
                user.Deactivate();
                Console.WriteLine("Пользователь деактивирован");
            }
            else
            {
                Console.WriteLine("пользователь с таким id не найден");
            }
        }
        public void DisplayUser()
        {
            foreach (User user in users)
            {
                Console.WriteLine($"имя: {user.Name}, Id: {user.Id}, статус активности: {user.IsActive}");
            }
        }
    }
    class program
    {
        static void Main()
        {
            UserDatabase userDb = new UserDatabase();

            while (true)
            {
                Console.WriteLine("выберите действие :\n1. добавить нового пользователя\n2. активировать пользователя /n3. ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("введите имя пользователя:");
                        string name = Console.ReadLine();

                        Console.WriteLine("введите Id пользователя");
                        int id = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("введите логический статус пользователя (true/false)");
                        bool isActive = Boolean.Parse(Console.ReadLine());

                        User newUser = new User(name, id, isActive);
                        userDb.AddUser(newUser);

                        Console.WriteLine("пользователь добавлен");
                        break;
                    case "2":
                        Console.WriteLine("введите Id пользователя для активации:");
                        int activatedId = Int32.Parse(Console.ReadLine());
                        userDb.ActivateUser(activatedId);
                        break;
                    case "3":
                        Console.WriteLine("введите Id пользователя для деактивации");
                        int deactivateId = Int32.Parse(Console.ReadLine());
                        userDb.DeactivateUser(deactivateId);
                        break;
                    case "4":
                        userDb.DisplayUser();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("неверный выбор. попробуйте снова.");
                        break;
                }
            }

        }
    }
}

