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
        public readonly int NumberExamList;
        public string NumberClass { get; set; }
        public string Institute { get; set; }
        public readonly StudentsMajor Major;
        public Student(string name, string surname, int numberExamList)
        {
            Name = name;
            Surname = surname;
            NumberExamList = numberExamList;
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

    public class FullTimeStudent : Student
    {
        public int ExamScore { get; set; }
        public FullTimeStudent(string name, string surname, int numberExamList, string NumberClass, string Institute, StudentsMajor Major, int examScore) : base(name, surname, numberExamList)
        {
            ExamScore = examScore;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            var studentInfo = base.GetInfo();

            info[0] = studentInfo[0];
            info[1] = studentInfo[1];
            info[2] = $"Студент очного обучения с баллом ЕГЭ: {ExamScore}";
            return info;
        }
    }

    public class Correspondence : Student
    {
        public string Job { get; set; }
        public string Position { get; set; }

        public Correspondence(string name, string surname, int numberExamList, string NumberClass, string Institute, StudentsMajor Major, string job, string position) : base(name, surname, numberExamList)
        {
            Job = job;
            Position = position;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            var studentInfo = base.GetInfo();

            info[0] = studentInfo[0];
            info[1] = studentInfo[1];
            info[2] = $"Студент заочного обучения - Место работы: {Job}; Должность: {Position}";
            return info;
        }
    }

    public class TargetedStudent : Student
    {
        public string Company { get; set; }

        public int Summ { get; set; }

        public TargetedStudent(string name, string surname, int numberExamList, string NumberClass, string Institute, StudentsMajor Major, string company, int sum) : base(name, surname, numberExamList)
        {
            Company = company;
            Summ = sum;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            var studentInfo = base.GetInfo();

            info[0] = studentInfo[0];
            info[1] = studentInfo[1];
            info[2] = $"Студент целевого обучения - Целевое предприятие: {Company}; Сумма обучения: {Summ}";
            return info;
        }
    }
}
