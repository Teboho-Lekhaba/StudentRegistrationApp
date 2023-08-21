using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class UserName
    {
        public string User_details()
        {
            // Prompt user input
            Console.WriteLine("Enter your First name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Cohort year: ");
            int cohort = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Campus name: ");
            string finalCampus = Console.ReadLine().ToUpper();
            

            Console.WriteLine(firstName + " " + lastName + " " + cohort + " " + finalCampus);

            string userName = CreateUsername(firstName, lastName, cohort, finalCampus);
            Console.WriteLine(userName);

            Console.ReadLine();

            return userName;
        }

        public  string CreateUsername(string firstName, string lastName, int cohort, string finalCampus)
        {
            // Create and return a valid user name
            string numbers = "1234567890";
            string campus;
            string result = null;
            string userName = "";
            DateTime cohortTime = DateTime.Now;

            if (firstName.Length < 3 || lastName.Length < 3)
            {
                firstName = firstName + "o";
                lastName = lastName + "o";
            }
            foreach (char number in numbers)
            {
                if (firstName.Contains(number) && lastName.Contains(number))
                {
                    result = "The name: " + firstName + "and " + lastName + "contains numbers";
                    Console.WriteLine("Please Enter a first name and last name without numbers!");
                    User_details();
                }
            }

            campus = user_campus(finalCampus);


            if (cohort < cohortTime.Year)
            {
                string msg = "Cohort you have selected is completed!!!";
                Console.WriteLine("Please enter the cohort for the upcoming year!");
                User_details();
            }
            else
            {
                userName = firstName.Substring(firstName.Length - 3, 3) + "" + lastName.Substring(0, 3) + "" + campus + "" + cohort;
            }

            return userName;
        }

        public  string user_campus(string campus)
        {
            //string campus = "";
            //Return valid campus abbreviations
            if (campus == "JOHANNESBURG" || campus == "JHB")
            {
                campus = "JHB";
            }
            else
                if (campus == "CAPE TOWN" || campus == "CPT")
            {
                campus = "CPT";
            }
            else if (campus == "DURBAN" || campus == "DBN")
            {
                campus = "DBN";
            }
            else if (campus == "PHOKENG" || campus == "PHO")
            {
                campus = "PHO";
            }
            else
            {
                Console.WriteLine("The campus you have entered does not exist!!!!");
                Console.WriteLine("Please enter the correct campus!");
                User_details();
            }

            return campus;
        }

    }
}
