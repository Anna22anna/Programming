using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string NumberExamList;
        public string NumberClass { get; set; }
        public string Institute { get; set; }
        public readonly StudentsMajor Major;
        public Student(string name, string surname, string numberExamList, string numberClass, string institute, StudentsMajor major)
        {
            Name = name;
            Surname = surname;
            NumberExamList = numberExamList;
            NumberClass = numberClass;
            Institute = institute;
            Major = major;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"{Name} {Surname} {NumberClass}";

            string major;
            if (Major == StudentsMajor.Bachelor)
                major = "Бакалавр";
            else if (Major == StudentsMajor.Specialty)
                major = "Специалитет";
            else
                major = "Магистр";

            info[1] = $"Номер зачётной книжки: {NumberExamList} Институт: {Institute} Направление обучения: {major}";
            return info;
            
        }
    }
}
