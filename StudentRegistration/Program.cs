using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {



           


            Team_Allocator team = new Team_Allocator();
            UserName user = new UserName();

            Console.WriteLine(string.Join("\n", team.Adding_User_To_List()));
            
            //Console.WriteLine("List of all the students");
            //Console.WriteLine(string.Join("\n", team.studentList()));
            //Console.WriteLine("Physical Team for Johannesburg");
            //Console.WriteLine(string.Join("\n", team.Jhb_physical_students(team.studentList())));
            //Console.WriteLine("Physical Team for Durban");
            //Console.WriteLine(string.Join("\n", team.Dbn_physical_students(team.studentList())));
            //Console.WriteLine("Physical Team for Cape Town");
            //Console.WriteLine(string.Join("\n", team.Cpt_physical_students(team.studentList())));
            //Console.WriteLine("Physical Team for Phokeng");
            //Console.WriteLine(string.Join("\n", team.nw_physical_students(team.studentList())));
            //Console.WriteLine("Physical Team for Virtual team");
            //Console.WriteLine(string.Join("\n", team.Virtual_students(team.studentList())));


            //Console.WriteLine(team.Teams(team.studentList()));

            // team_Allocator.studentList();
            // team_Allocator.dbn_campus_students(team_Allocator.studentList());
            //Console.WriteLine("The correct username is as follows: \n 1. Last 3 letters of first name (if their name is less than 3 letters you should add the\r\nletter O at the end)" +
            //    "\r\n\n2. First 3 letters of their last name (if their name is less than 3 letters you should\r\nadd the letter O at the end)\r\n" +
            //    "3.\n Final Campus selection - Johannesburg is JHB, Cape Town is CPT, Durban is DBN,\r\nPhokeng is PHO\r\n" +
            //    "\n4.The cohort year they are entering ");
            //Console.WriteLine();
            //User_details();
        }

       


    }
}
