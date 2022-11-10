using System;
using System.Collections.Generic;
using System.Text;
using ProjectBank.Views;

namespace ProjectBank
{
    class Login
    {
        private new string Username;
        private new string Password;
        public int LoginAttempts;
        public bool IsLocked;

        public void Logint()
        {

            string text = @"
              /_\  _ __   __ _ _ __   __ _ ___   / __\ __ _ _ __ | | __
             //_\\| '_ \ / _` | '_ \ / _` / __| /__\/// _` | '_ \| |/ /
            /  _  \ | | | (_| | | | | (_| \__ \/ \/  \ (_| | | | |   < 
            \_/ \_/_| |_|\__,_|_| |_|\__,_|___/\_____/\__,_|_| |_|_|\_\";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Username: ");
            Username = Console.ReadLine();

            Console.WriteLine("Password: ");
            Password = Console.ReadLine();
            

            if (Username == "Marre" & Password == "Cykel")
            {
                IsLocked = false;
                
                Console.WriteLine("{0," + Console.WindowWidth / 2 + "}", "+Welcome to your dashboard+");
                DashboardView.Run();
            }
            else
                Console.WriteLine("Wrong username or password. Please try again");
            IsLocked = true;
            LoginAttempts--;
            if (LoginAttempts == 0)
            {
                Console.WriteLine("You have attempt to many times. Your account is now locked. Please contact our costomer service");
            }

            
        }
        
    }
}
