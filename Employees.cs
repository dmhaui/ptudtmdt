using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace masterpage2
{
    public class Employees
    {
        public int empid { get; set;  }
        public string name { get; set;  }
        public string gender { get; set;  }
        public string address { get; set;  }
        public string email { get; set;  }
        public int titleid { get; set;  }
        public Employees()
        {

        }

        public Employees(int empid, string name, string gender, string address, string email, int titleid)
        {
            this.empid = empid;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.titleid = titleid;

        }
    }
}