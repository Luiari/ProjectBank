using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    public class LogInView
    {
        public static void Run(List<User> UsersList)
        {
            Console.Clear();

            string Username;
            string Password;
            string inputPassword;
            string prompt = "";
            int LoginAttempts = 3;
            bool IsLocked = false;
            while (true)
            {
                Console.Clear();

                string text = @"
              /_\  _ __   __ _ _ __   __ _ ___   / __\ __ _ _ __ | | __
             //_\\| '_ \ / _` | '_ \ / _` / __| /__\/// _` | '_ \| |/ /
            /  _  \ | | | (_| | | | | (_| \__ \/ \/  \ (_| | | | |   < 
            \_/ \_/_| |_|\__,_|_| |_|\__,_|___/\_____/\__,_|_| |_|_|\_\";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" " + prompt);

                Console.Write(" Usename: ");
                Username = Console.ReadLine();
                try
                {
                    Password = UsersList.Find(u => u.Username == Username).password;//Gets password from the username entered above
                }
                catch (Exception)
                {
                    prompt = "This username does not exist";
                    throw;
                }
                
                
                Console.Write(" Password: ");
                inputPassword = Console.ReadLine();

                if (inputPassword == Password )
                {
                    if(!IsLocked)
                    {
                        Console.WriteLine("{0," + Console.WindowWidth / 2 + "}", "+Welcome to your dashboard+");
                        DashboardView.Run();
                    }               
                }
                else
                {                   
                        prompt = "Wrong username or password. Please try again";
                        LoginAttempts--;                           
                }

                if (LoginAttempts == 0)
                {
                    prompt = "You have attempt to many times. Your account is now locked. Please contact our costomer service";
                    IsLocked = true;
                }                
            }
           
        }
    }
}
