using System;
using System.Collections.Generic;

using Students.Models;
using Students.Extensions;

namespace Students.Tests
{
    class StudentListTest
    {
        public static IList<Student> students = new List<Student>();

        public static void PopulateList()
        {
            students.Add(new Student("Pesho", "Goshov", 22, "1029502", "02717250", "pesho.goshov@gmail.com", new Group(2, "Logistics"), new List<int>() { 2, 3, 5, 2 }));
            students.Add(new Student("Gosho", "Peshov", 17, "1029503", "0888346250", "gosho.peshov@abv.bg", new Group(1, "Laziness"), new List<int>() { 6, 6, 6, 6, 6 }));
            students.Add(new Student("Peshka", "Goshova", 38, "1029504", "02762350", "peshka.goshova@abv.bg", new Group(4, "Logistics"), new List<int>() { 2, 2 }));
            students.Add(new Student("N'", "Gogo", 25, "1029505", "02123250", "n.gogo@dir.bg", new Group(2, "History of Zamunda"), new List<int>() { 6, 6 }));
            students.Add(new Student("Kobo", "Kobo", 24, "1029506", "0889456250", "kobo.kobo@yahoo.com", new Group(2, "History of Zamunda"), new List<int>() { 2, 2 }));
            students.Add(new Student("Kolio", "Karamfilov", 55, "1029507", "08881234550", "kolio@abv.bg", new Group(4, "Art"), new List<int>() { 6, 6 }));
            students.Add(new Student("Dedo", "Pop", 20, "1029508", "0888454550", "dedo.pop@abv.bg", new Group(2, "Theology"), new List<int>() { 2, 4, 2, 3 }));
            students.Add(new Student("Mr", "Been", 21, "1029509", "0888954050", "mr.been@mail.co.uk", new Group(3, "Art"), new List<int>() { 2, 2 }));
            students.Add(new Student("Otlichnik", "Pulen", 16, "1014103", "0888123321", "new.email@abv.bg", new Group(2, "Young"), new List<int>() { 6, 6 }));
        }

        public static void TestStudentList()
        {
            Console.WriteLine("Sort by Name (Lambda)");
            var testList = students.SortByNameLambda();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

            Console.WriteLine("Sort by name (LINQ)");
            testList = students.SortByNameLinq();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

            Console.WriteLine("Select By Group");
            testList = students.SelectByGroup();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

            Console.WriteLine("Select by Phone Code");
            testList = students.SelectByPhoneCode();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

            Console.WriteLine("Select by email domain");
            testList = students.SelectByEmailDomain();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

            Console.WriteLine("Select by mark");
            testList = students.SelectByMark();
            foreach (var student in testList)
            {
                System.Console.WriteLine(student);
            }

        }
    }
}
