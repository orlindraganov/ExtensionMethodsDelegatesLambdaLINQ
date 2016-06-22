namespace Students.Models
{
    public class Group
    {
        #region Fields
        private int groupNumber;
        private string departmentName;
        #endregion

        #region Properties
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

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                this.departmentName = value;
            }
        }
        #endregion

        #region Constructors
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{this.GroupNumber} {this.DepartmentName}";
        }

        #endregion
    }
}
