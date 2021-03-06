using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    [Serializable]
    public class Student
    {
        public string FullName { get; set; }

        public string ID { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }

        public string Password { get; set; }

    }
}
