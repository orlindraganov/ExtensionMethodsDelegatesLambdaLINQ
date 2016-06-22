using System.Collections.Generic;
using System.Linq;

using Students.Models;

namespace Students.Extensions
{
    internal static class Extensions
    {
        #region IEnumerable<Student> extensions
        internal static IEnumerable<Student> FindFirstNameBeforeLastName(this IEnumerable<Student> students)
        {
            var result =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return result;
        }

        internal static IEnumerable<Student> FindAgeRange(this IEnumerable<Student> students)
        {
            var result =
                from student in students
                where 18 <= student.Age && student.Age <= 24
                select student;

            return result;
        }

        internal static IEnumerable<Student> SortByNameLambda(this IEnumerable<Student> students)
        {
            return students
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);
        }

        internal static IEnumerable<Student> SortByNameLinq(this IEnumerable<Student> students)
        {
            var result = from student in students
                         orderby student.FirstName,
                                 student.LastName
                         select student;

            return result;
        }

        public static IEnumerable<Student> SelectByGroup(this IEnumerable<Student> students, int targetGroup = 2)
        {
            var result = from student in students
                         where student.GroupNumber == targetGroup
                         orderby student.FirstName,
                                 student.LastName
                         select student;

            return result;
        }

        public static IEnumerable<Student> SelectByEmailDomain(this IEnumerable<Student> students, string domain = "@abv.bg")
        {
            var result = from student in students
                         where student.Email.Contains(domain)
                         select student;
            return result;
        }

        public static IEnumerable<Student> SelectByPhoneCode(this IEnumerable<Student> students, string phoneCode="02")
        {
            var result = from student in students
                         where student.PhoneNumber.StartsWith(phoneCode)
                         select student;
            return result;
        }

        public static IEnumerable<Student> SelectByMark(this IEnumerable<Student> students, int mark = 6)
        {
            var result = from student in students
                         where student.Marks.Contains(mark)
                         select student;
            return result;
        }

        
        #endregion
    }
}
