﻿using System;
using FillingOutTheQuestionnaireApp.Model;

namespace FillingOutTheQuestionnaireApp
{
    class Program
    {
        static void Main()
        {
            var user = new User
            {
                Login = "MyLogin",
                Name = "MyName",
                Surname = "MySurname",
                Age = "MyAge",
            };

            Console.WriteLine(user.Login);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Surname);
            Console.WriteLine(user.Age);
            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}