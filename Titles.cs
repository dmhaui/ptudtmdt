using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace masterpage2
{
    public class Titles
    {
        public int titleid { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public Titles()
        {

        }
        public Titles(int titleid, string name, int salary)
        {
            this.titleid = titleid;
            this.name = name;
            this.salary = salary;

        }
    }
}