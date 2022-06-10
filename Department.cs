using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    internal class Department
    {
        public string Name { get; set; }
        public static Dictionary<string, Department> Departments_List = new Dictionary<string, Department>();
        public Department(string name)
        {
            Name = name;
        }
        
    }
}
