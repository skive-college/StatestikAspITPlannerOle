using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatestikAspITPlannerOle
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int aktiv { get; set; }

        public Student(int id, string name, int aktiv)
        {
            this.id = id;
            this.name = name;
            this.aktiv = aktiv;
        }
        public override string ToString()
        {
            return this.name;
        }

    }
}
