using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly int LibraryCardId;

        public string BorrowedLiterature;
        public DateTime IssueDate;
        public double TermDate;
        public DateTime ReturnDate => IssueDate.AddDays(TermDate);
        public int Deposit;

        public Reader(string name, string surname, int libraryCardId)
        {
            Name = name;
            Surname = surname;
            LibraryCardId = libraryCardId;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Name} {Surname} Номер читательского билета: {LibraryCardId}";

            info[1] = $"Список взятой литературы: {BorrowedLiterature}, Дата выдачи: {IssueDate.ToString("dd.MM.yyyy")}, Срок выдачи: {TermDate} дней, Дата планируемого возвращения: {ReturnDate.ToString("dd.MM.yyyy")}, Сумма залога: {Deposit} руб.";
            return info;
        }
    }
}
