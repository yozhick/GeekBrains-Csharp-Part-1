using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task5
{
    public class Converter
    {
        private List<Student> students;

        public void LoadFromXml(string fileName)
        {
            List<Student> list = new List<Student>();
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            students = list;
        }

        public void SaveToXml(string fileName)
        {
            if (students == null)
                throw new Exception("Не задан источник.");

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, students);
            fStream.Close();
        }

        public void LoadFromCsv(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            List<Student> list = new List<Student>();

            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                Student newStudent = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
                list.Add(newStudent);
            }

            sr.Close();
            students = list;
        }

        public void SaveToCsv(string fileName)
        {
            if (students == null)
                throw new Exception("Не задан источник.");
            //string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city

            StreamWriter sw = new StreamWriter(fileName, false);
            foreach(var student in students)
            {
                sw.WriteLine($"{student.FirstName};{student.LastName};{student.University};"+
                    $"{student.Faculty};{student.Department};{student.Course};"+
                    $"{student.Age};{student.Group};{student.City}");
            }

            sw.Close();
        }


    }


}
