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
        private string phoneNumber;
        private string email;
        private int groupNumber;
        private Group courseGroup;
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
                return this.age;
            }
            set
            {
                this.age = value;
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

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public Group CourseGroup
        {
            get
            {
                return this.courseGroup;
            }
            set
            {
                this.courseGroup = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
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
        public Student(string firstName,
                       string lastName,
                       int age,
                       string facultyNumber,
                       string phoneNumber,
                       string email,
                       Group courseGroup,
                       IEnumerable<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = courseGroup.GroupNumber;
            this.CourseGroup = courseGroup;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{this.FullName} {this.Age} {this.FacultyNumber} {this.PhoneNumber} {this.Email} {this.CourseGroup} { this.Marks }";
        }
        #endregion
    }
}
