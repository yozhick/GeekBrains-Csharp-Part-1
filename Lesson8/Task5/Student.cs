using System;

namespace Task5
{
    [Serializable]
    public class Student
    {
        private string lastName;
        private string firstName;
        private string university;
        private string faculty;
        private int course;
        private string department;
        private int group;
        private string city;
        private int age;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string University { get => university; set => university = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }
        public string Department { get => department; set => department = value; }
        public int Group { get => group; set => group = value; }
        public string City { get => city; set => city = value; }
        public int Age { get => age; set => age = value; }

        private Student()
        {

        }

        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }

    }
}
