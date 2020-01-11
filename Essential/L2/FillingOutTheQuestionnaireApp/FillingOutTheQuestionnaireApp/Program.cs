using System;
using FillingOutTheQuestionnaireApp.Model;

namespace FillingOutTheQuestionnaireApp
{
    public class Program
    {
        private static void Main()
        {
            var user = new User
            {
                Login = "MyLogin",
                Name = "MyName",
                Surname = "MySurname",
                Age = "MyAge",
            };

            Console.WriteLine(user);
            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}