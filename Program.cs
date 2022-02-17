using System;

namespace UserRegistrationProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to User Registration program...!!!");

            Registration reg = new Registration();

            reg.UserRegistration();

        }
    }
}