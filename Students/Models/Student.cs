namespace Students.Models
{
    using System.Collections.Generic;

    public class Student
    {
        #region Fields
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private IEnumerable<int> marks;
        #endregion

        #region Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }

        public int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                this.Age = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public IEnumerable<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
            set
            {
                this.marks = value;
            }
        }
        #endregion

        #region Constructors
        public Student(string firstName, string lastName, int age, string facultyNumber, IEnumerable<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Marks = marks;
        }
        #endregion
    }
}
