using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class StudentData
    {
        private static List<Student> testStudents;
        public static List<Student> TestStudents 
        
        {get {return testStudents;}

            private set {testStudents = value;}
        }
        static StudentData() 
        {
            testStudents = new List<Student>();
            testStudents.Add(new Student("Crocky", "Stoyanova", "Ivanova", "FCST", "CSI", "Bachelor", Status.CERTIFIED, "121216156", 3, 1, 45, DateTime.Now, DateTime.Now));
            testStudents.Add(new Student("Bodil40", "Petrov", "Mersikov", "FCST", "ITI", "Bachelor", Status.DROPPED, "121216000", 4, 8, 57, DateTime.Now, DateTime.Now));
            testStudents.Add(new Student("Costa", "Caesar", "Rica", "FTC", "Telecommunications", "Master", Status.GRADUATED, "121216404", 5, 5, 48, DateTime.Now, DateTime.Now));
        
        }
        public static Student IsThereStudent(String facultyNumber) 
        { 
        Student result = (from currentStudent in TestStudents where currentStudent.FacultyNumber == facultyNumber select currentStudent).First();
        return result;
        } 

    }
}
