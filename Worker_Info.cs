using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    public class Worker
    {
        public static List<Worker> workers_list = new List<Worker>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Last_Name { get; set; }
        public string Date_of_Birth { get; set; }
        public char Gender { get; set; }        // М, Ж или -
        public Worker(int id, string name, string surname, string last_name, string birthday, char gender)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Last_Name = last_name;
            Date_of_Birth = birthday;
            Gender = gender;
        }
    }
}
