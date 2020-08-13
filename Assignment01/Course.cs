using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    public class Course : IComparable, IEnumerable
    {
        //Fields
        private string departmentCode;
        private uint? courseNumber;
        private string sectionNumber;
        private ushort? creditHours;
        private List<int> enrolled;
        private ushort? numberOfStudentsEnrolled;
        private ushort? maxStudentsEnrolled;

        //Properties
        public string DepartmentCode
        {
            get
            {
                return departmentCode;
            }
            set
            {
                if(value.Length > 4)
                {
                    throw new ArgumentOutOfRangeException("Error: Department code must be less than 5 characters");
                }
                else
                {
                    departmentCode = value.ToUpper();
                }
            }
        }
        public uint? CourseNumber
        {
            get
            {
                return courseNumber;
            }
            set
            {
                if(value < 100 || value > 499)
                {
                    throw new ArgumentOutOfRangeException("Error: Course number must be between 100 and 499");
                }
            }
        }
        public string SectionNumber
        {
            get
            {
                return sectionNumber;
            }
            set
            {
                if(value.Length != 4)
                {
                    throw new ArgumentOutOfRangeException("Error: Section number must be exactly 4 characters");
                }
                else
                {
                    sectionNumber = value;
                }
            }
        }
        public ushort? CreditHours
        {
            get
            {
                return creditHours;
            }
            set
            {
                if(value < 0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Error: Credit hours must be between 0 and 6");
                }
                else
                {
                    creditHours = value;
                }
            }
        }
        public List<int> Enrolled
        {
            get
            {
                return enrolled;
            }
            set
            {
                enrolled = value;
            }
        }
        public ushort? NumberOfStudentsEnrolled
        {
            get
            {
                return numberOfStudentsEnrolled;
            }
            set
            {
                numberOfStudentsEnrolled = value;
            }
        }
        public ushort? MaxStudentsEnrolled
        {
            get
            {
                return maxStudentsEnrolled;
            }
            set
            {
                maxStudentsEnrolled = value;
            }
        }

        //Constructors
        public Course()
        {
            departmentCode = null;
            courseNumber = null;
            sectionNumber = null;
            creditHours = null;
            enrolled = null;
            numberOfStudentsEnrolled = null;
            maxStudentsEnrolled = null;
        }
        public Course(string newDepartmentCode, uint newCourseNumber, string newSectionNumber, ushort newCreditHours, List<int> newEnrolled, ushort newNumberofStudentsEnrolled, ushort newMaxStudentsEnrolled)
        {
            departmentCode = newDepartmentCode;
            courseNumber = newCourseNumber;
            sectionNumber = newSectionNumber;
            creditHours = newCreditHours;
            enrolled = newEnrolled;
            numberOfStudentsEnrolled = newNumberofStudentsEnrolled;
            maxStudentsEnrolled = newMaxStudentsEnrolled;
        }

        //Methods
        public int CompareTo(object obj)
        {
            Course otherCourse = obj as Course;


        }
        public Courses(List<int> courseList)
        {
            _courses = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }


        }
        public override string ToString()
        {
            int? temp = numberOfStudentsEnrolled / maxStudentsEnrolled;
            return String.Format("{0} {1}-{2} ({3})", departmentCode, courseNumber, sectionNumber, temp);
        }
    }
