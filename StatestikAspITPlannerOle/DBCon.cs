using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StatestikAspITPlannerOle
{
    class DBCon
    {

        public static List<Student> GetStudents()
            //calls db and fetch all students and return a list with the student
        {
            //Student[] returnstu = new Student[2];
            List<Student> returnstu = new List<Student>();


            returnstu.Add(new Student(1, "ole", 1));
            returnstu.Add(new Student(2, "peter", 1));
            
           
            return returnstu;

        }






    }
}
