using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    public class Registration
    {
        public void UserRegistration()
        {
            Regex firstName = new Regex("^[A-Z]{1}[a-z]{3,14}$");

            System.Console.WriteLine("Enter Fisrt Name :");
            string fname = Console.ReadLine();
            if (firstName.IsMatch(fname))
            {
                System.Console.WriteLine("Your Name is :"+fname);
            }
            else
            {
                System.Console.WriteLine("please enter valid name format");
            }
        }
        
    }
}