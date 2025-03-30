using University;

namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class StudentUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var mark = CreateTestPerson();
            Assert.That(mark.Name, Is.EqualTo("Никита"));
            Assert.That(mark.Surname, Is.EqualTo("Смирнов"));
            Assert.That(mark.NumberExamList, Is.EqualTo(2023006));
            Assert.That(mark.NumberClass, Is.EqualTo("УГИ-235109"));
            Assert.That(mark.Institute, Is.EqualTo("Гуманитарный"));
            Assert.That(mark.Major, Is.EqualTo(StudentsMajor.Bachelor));
        }

        [Test]
        public void GetInfoTest()
        {
            var mark = CreateTestPerson();
            var info = mark.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Никита Смирнов УГИ-235109"));
            Assert.That(info[1], Is.EqualTo($"Номер зачётной книжки: 2023006 Институт: Гуманитарный Направление обучения: Бакалавр"));
        }
        private Student CreateTestPerson()
        {
            return new Student("Никита", "Смирнов", 2023006)
            {
                NumberClass = "УГИ-235109",
                Institute = "Гуманитарный",
            };
        }
    }
}