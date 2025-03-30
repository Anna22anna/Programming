using University;

namespace UniversityLibrary.UnitTests
{

    [TestFixture]
    public class FullTimeStudentTest
    {
        [Test]
        public void ConstructorTest()
        {
            var fullstudent = GetTestFullStudent();

            Assert.That(fullstudent.ExamScore, Is.EqualTo(252));
        }

        [Test]
        public void GetInfo_FullStudent()
        {
            var fullstudent = GetTestFullStudent();
            var lines = new[]
            {
                "Никита Смирнов УГИ-235109",
                "Номер зачётной книжки: 2023006 Институт: Гуманитарный Направление обучения: Бакалавр",
                "Студент очного обучения с баллом ЕГЭ: 252"
            };

            var info = fullstudent.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));

            for (var i=0; i<info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private FullTimeStudent GetTestFullStudent()
        {
            var full = new FullTimeStudent("Никита", "Смирнов", 2023006, "УГИ-235109", "Гуманитарный", StudentsMajor.Bachelor, 252);
            full.NumberClass = "УГИ-235109";
            full.Institute = "Гуманитарный";
            full.ExamScore = 252;
            return full;
        }
    }
}
