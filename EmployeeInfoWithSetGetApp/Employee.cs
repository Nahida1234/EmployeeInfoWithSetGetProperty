using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfoWithSetGetApp
{
    class Employee
    {
        private string id;
        private string name;
        private double salary;

        public string _id
        {
            set { id = value; }

            get
            {
                return id;
            }
    }

        public string _name
        {
            set { name = value; }
            get { return name; }
        }

        public double _salary
        {
            set { salary = value; }
            get { return salary; }
        }
    }
}
