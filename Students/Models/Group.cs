namespace Students.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        #region Fields
        private string groupNumber;
        private IEnumerable<Student> students;
        private double averageMark;
        #endregion

        #region Properties
        public string GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                this.groupNumber = value;
            }
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
        public double AverageMark
        {
            get
            {
                return this.averageMark;
            }
            set
            {
                this.averageMark = value;
            }
        }
        #endregion

        #region Constructors
        public Group(string groupNumber, IEnumerable<Student> students, double averageMark)
        {
            this.GroupNumber = groupNumber;
            this.Students = students;
            this.AverageMark = averageMark;
        }
        #endregion


    }
}
