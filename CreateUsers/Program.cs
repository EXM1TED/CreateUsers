﻿using System;
using System.Collections.Generic;
using CreateUsers.Classes;

namespace CreateUsers
{
    public class Programm
    {
        public static void Main()
        {
            int COUNT_OF_USERS;

            Console.Write("Введите количество пользователей, которых Вы хотите создать: ");

            COUNT_OF_USERS = Convert.ToInt32(Console.ReadLine());
            List<User> users = new List<User>();

            for (int i = 0; i < COUNT_OF_USERS; i++)
            {

                Console.Write("Введите имя пользователя: ");
                string userName = Console.ReadLine();
                Console.Write("Введите возраст пользователя: ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------");

                User user = new User(userName, userAge);

                users.Add(user);
            }

            Console.WriteLine();
            Console.WriteLine("Список пользователей:");
            Console.WriteLine($"Всего пользователей: {users.Count()}");

            foreach (User user in users)
            {                
                Console.WriteLine($"Имя: {user.Name}, возраст: {user.Age}");
            }
        }
    }
}
