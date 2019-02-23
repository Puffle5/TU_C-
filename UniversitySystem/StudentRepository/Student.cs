using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class Student
    {
        public String FirstName {get; set;}
        public String MiddleName {get; set;}
        public String LastName {get; set;}
        public String Faculty {get; set;}
        public String Specialty {get; set;}
        public String Degree {get; set;}
        public Status status {get; set;}
        public String FacultyNumber {get; set;}
        public int Course {get; set;}
        public int Flow {get; set;}
        public int Group { get; set; }

        public Student(String FirstName, String MiddleName, String LastName, String Faculty, String Specialty, String Degree, Status status, String FacultyNumber, int Course, int Flow, int Group) 
        {
            this.FirstName = FirstName; this.MiddleName = MiddleName; this.LastName = LastName;
            this.Faculty = Faculty; this.Specialty = Specialty; this.Degree = Degree;
            this.status = status; this.FacultyNumber = FacultyNumber;
            this.Course = Course; this.Flow = Flow; this.Group = Group;
        }       
        
    }
}
