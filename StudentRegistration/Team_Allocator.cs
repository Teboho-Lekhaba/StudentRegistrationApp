using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Team_Allocator
    {
        //This is the team allocator project solution example project
        
        public List<string> studentList()
        {
            List<string> students = new (){"zakithikhDBN2022 - 4 April - Johannesburg Physical - seat 3",
                "ddhaalJHB2022 - 2 May - Cape Town Virtual","thandohDBN2022 - 4 April - Phokeng Physical - seat 3",
                "zaneleJHB2022 - 2 May - Durban Virtual","ntobekoDBN2022 - 4 April - Phokeng Physical - seat 2",
                "zinhlehDBN2022 - 4 April - Phokeng Physical - seat 1", "CebiJHB2022 - 2 May - Durban Virtual",
                "lukhona - 4 April - Phokeng Virtual", "ddhaalJHB2022 - 2 May - Durban Physical - seat 4",
                "gabiDBN2022 - 4 April - Phokeng Virtual", "ngakithilJHB2022 - 2 May - Durban Physical - seat 5",
                "zimthembilehDBN2022 - 4 April - Phokeng Virtual", "ngakuyelJHB2022 - 2 May - Durban Physical - seat 2",
                "zimlindilehDBN2022 - 4 April - Phokeng Virtual", "yenzileJHB2022 - 2 May - Durban Physical - seat 3",
                "zimthandilehDBN2022 - 4 April - Johannesburg Virtual", "kuhlengaweDBN2022 - 4 April - Durban Physical - seat 1",
                "zimkhonzileDBN2022 - 4 April - Johannesburg Virtual", "hlelokuhlehDBN2022 - 4 April - Durban Physical - seat 3",
                "zizonkehDBN2022 - 4 April - Johannesburg Virtual", "sibusisohDBN2022 - 4 April - Durban Physical - seat 2",
                "kholekileDBN2022 - 4 April - Johannesburg Virtual", "vusiDBN2022 - 4 April - Durban Physical - seat 9",
                "kholelwahDBN2022 - 4 April - Johannesburg Virtual", "zuzumuzihDBN2022 - 4 April - Durban Physical - seat 10",
                "thembelahDBN2022 - 4 April - Johannesburg Virtual", "babazileDBN2022 - 4 April - Durban Physical - seat 11",
                "thembisileDBN2022 - 4 April - Johannesburg Virtual", "owenkosiDBN2022 - 4 April - Durban Physical - seat 8",
                "thembisiweDBN2022 - 4 April - Johannesburg Physical - seat 5", "nobuhleJHB2022 - 2 May - Cape Town physical",
                "thenjisiweDBN2022 - 4 April - Johannesburg Physical - seat 6", "nonkonzoJHB2022 - 2 May - Cape Town Physical",
                "thethelelileDBN2022 - 4 April - Johannesburg Physical - seat 7", "nombusoJHB2022 - 2 May - Cape Town Virtual",
                "thembiDBN2022 - 4 April - Johannesburg Physical - seat 4", 
                "nozizweJHB2022 - 2 May - Cape Town Virtual", "BusiJHB2022 - 2 May - Durban Virtual" };
    

            return students;
        }

        public List<string> Dbn_campus_students(List<string> students)
        {
            //from the list of students above, fill in this function to return a list of all
            //students in the Durban campus only.
           
            string campus = "Durban";

            List<string> dbn_students = Adding_students(students, campus);

            return dbn_students;
        }

        public List<string> Adding_students(List<string> students, string campus)
        {
            List<string> listOfStudents = new List<string>();
            foreach (string student in students)
            {
                if (student.Contains(campus))
                {
                    listOfStudents.Add(student);
                }
            }
            return listOfStudents;
        }

        public List<string> Jhb_campus_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
           //   students in the Johannesburg campus only.
          
            string campus = "Johannesburg";

            List<string> jhb_students = Adding_students(students, campus);
            
            return jhb_students;
        }

        public List<string> Cpt_campus_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
           
            string campus = "Cape Town";

            List<string> cpt_students = Adding_students(students, campus);

            return cpt_students;
        }

        public List<string> Nw_campus_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
            
            string campus = "Phokeng";

            List<string> nw_students = Adding_students(students, campus);

            return nw_students;
        }

        public List<string> Dbn_physical_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
            //students = studentList();
            string locType = "Physical";
            string campus = "Durban";

            List<string> dbn_students = new List<string>();

            foreach (string student in students)
            {
                if (student.Contains(locType))
                {
                    if (student.Contains(campus))
                    {
                        dbn_students.Add(student);
                    }
                }
            }
            return dbn_students;
        }

        public List<string> Jhb_physical_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
            
            string locType = "Physical";
            string campus = "Johannesburg";
            List<string> jhb_students = new List<string>();
            foreach (string student in students)
            {
                if (student.Contains(locType))
                {
                    if (student.Contains(campus))
                    {
                        jhb_students.Add(student);
                    }
                }
            }
            return jhb_students;
        }

        public List<string> Cpt_physical_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
           
            string locType = "Physical";
            string campus = "Cape Town";

            List<string> cpt_students = new List<string>();
            foreach (string student in students)
            {
                if (locType.Contains(student))
                {
                    if (student.Contains(campus))
                    {
                        cpt_students.Add(student);
                    }
                        
                }
            }
            return cpt_students;
        }

        public List<string> nw_physical_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students in the Cape Town campus only.
           
            string locType = "Physical";
            string campus = "Phokeng";

            List<string> nw_students = new List<string>();
            foreach (string student in students)
            {
                if (student.Contains(locType))
                {
                    if (student.Contains(campus))
                    {
                        nw_students.Add(student);
                    }
                }
            }
            return nw_students;
        }

        public List<string> Virtual_students(List<string> students)
        {
            //  from the list of students above, fill in this function to return a list of all
            //   students attending virtually only.
            
            string locType = "Virtual";

            List<string> virtual_students = new List<string>();
            foreach (string attendance in students)
            {
                if (attendance.Contains(locType))
                {
                    virtual_students.Add(attendance);
                }
            }
            return virtual_students;
        }

        public List<string> Adding_User_To_List()
        {
            UserName user = new UserName();
           
            string name = user.User_details();

            if (name != null)
            {
                studentList().Add(name);
            }
            return studentList();

        }
    }
}
