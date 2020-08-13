using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    public class Student : IComparable
    {
        //Fields
        private readonly uint zid;
        private string firstName;
        private string lastName;
        private string major;
        public enum academicYear { Freshman, Sophomore, Junior, Senior, PostBacc }
        private academicYear year;
        private float? gpa;
        private ushort? currentCreditHours;

        //Properties
        public uint Zid
        {
            get
            {
                return zid;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public academicYear Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public float? Gpa
        {
            get
            {
                return gpa;
            }
            set
            {
                if(value < 0.00 || value > 4.00)
                {
                    throw new ArgumentOutOfRangeException("Error: GPA must be between 0.00 and 4.00");
                }
                else
                {
                    gpa = value;
                }
            }
        }
        public ushort? CurrentCreditHours
        {
            get
            {
                return currentCreditHours;
            }
            set
            {
                if(value < 0 || value > 18)
                {
                    throw new ArgumentOutOfRangeException("Error: Credit hours must be between 0 and 18");
                }
            }
        }

        //Constructors
        public Student()
        {
            this.FirstName = null;
            this.LastName = null;
            this.Major = null;
            this.Gpa = null;
            this.CurrentCreditHours = null;

        }
        public Student(uint newZid, string newFirstName, string newLastName, string newMajor, academicYear newYear, float newGpa)
        {
            if (newZid < 1000000)
            {
                throw new ArgumentOutOfRangeException("Error: Zids must be at least 8 characters long");
            }
            else
            {
                zid = newZid;
            }
            FirstName = newFirstName;
            LastName = newLastName;
            Major = newMajor;
            Year = newYear;
            Gpa = newGpa;
        }

        //Methods
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            if(this.Zid < otherStudent.Zid)
            {
                return -1;
            }
            else if(this.Zid == otherStudent.Zid)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int Enroll(Course newCourse)
        {

        }
        public int Drop(Course newCourse)
        {
            if (newCourse.Enrolled.Contains(Convert.ToInt32(this.zid)))
            {
                newCourse.Enrolled.Remove(Convert.ToInt32(this.zid));
                return 0;
            }
            else
            {
                throw new Exception("Error code 20: Student is not in course");
            }
        }
        public override string ToString()
        {
            return String.Format("Z{0} -- {1}, {2} [{3}] ({4}) |{5}|", this.Zid, this.LastName, this.FirstName, this.year, this.Major, this.Gpa);
        }
        public string ToString(string type)
        {

        }
    }
}
