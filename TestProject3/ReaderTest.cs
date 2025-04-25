using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Library;

namespace Library
{
    [TestFixture]
    public class ReaderTest
    {
        [Test]
        public void ConstructorTest()
        {
            var first = CreateTestReader();
            Assert.That(first.Name, Is.EqualTo("Джон"));
            Assert.That(first.Surname, Is.EqualTo("Сина"));
            Assert.That(first.LibraryCardId, Is.EqualTo(235109));
            Assert.That(first.BorrowedLiterature, Is.EqualTo("100 анекдотов для великих"));
            Assert.That(first.IssueDate.ToString("dd.MM.yyyy"), Is.EqualTo("15.03.2023"));
            Assert.That(first.TermDate, Is.EqualTo(7));
            Assert.That(first.ReturnDate.Date, Is.EqualTo(first.IssueDate.AddDays(7).Date));
            Assert.That(first.Deposit, Is.EqualTo(100));
        }
        [Test]
        public void TestGetInfo()
        {
            var reader = CreateTestReader();
            var info = reader.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Джон Сина Номер читательского билета: 235109"));
            Assert.That(info[1], Is.EqualTo("Список взятой литературы: 100 анекдотов для великих, Дата выдачи: 15.03.2023, Срок выдачи: 7 дней, Дата планируемого возвращения: 22.03.2023, Сумма залога: 100 руб."));
        }
        private Reader CreateTestReader()
        {
            return new Reader("Джон", "Сина", 235109)
            {
                BorrowedLiterature = "100 анекдотов для великих",
                IssueDate = new DateTime(2023, 3, 15),
                TermDate = 7,
                Deposit = 100
            };
        }
    }
}