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
                System.Console.WriteLine("Your first Name is :"+fname);
            }
            else
            {
                System.Console.WriteLine("please enter valid first name!!");
            }

            Regex lastName = new Regex("^[A-Z]{1}[a-z]{3,14}$");

            System.Console.WriteLine("Enter Last Name :");
            string lname = Console.ReadLine();
            if (lastName.IsMatch(lname))
            {
                System.Console.WriteLine("Your last Name is :"+lname);
            }
            else
            {
                System.Console.WriteLine("please enter valid last name!!");
            }

            Regex regEmail1 = new Regex("^([a-zA-Z0-9.]{3,})?[@][a-zA-Z]{3,}[.][a-zA-Z]{2,3}[.][a-zA-Z]{2}?$");
            Regex regEmail2 = new Regex("^([a-zA-Z0-9.]{3,})?[@][a-zA-Z]{3,}[.][a-zA-Z]{2,3}?$");

            System.Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            if (regEmail1.IsMatch(email) || regEmail2.IsMatch(email))
            {
                System.Console.WriteLine("Your Email id is :"+email);
            }
            else
            {
                System.Console.WriteLine("please enter valid email id format!!");
            }

            Regex regContact = new Regex("^[9]{1}[1]{1}[ ][6-9]{1}[0-9]{9}$");

            System.Console.WriteLine("Enter Contact Number :");
            string contact = (Console.ReadLine());
            
            if (regContact.IsMatch(contact))
            {
                System.Console.WriteLine("Your contact number is :"+contact);
            }
            else
            {
                System.Console.WriteLine("please enter valid contact number format!!");
            }
        }       
    }
}