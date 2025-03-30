using University;

namespace UniversityLibrary.UnitTests
{

    [TestFixture]
    public class CorrespondenceTest
    {
        [Test]
        public void ConstructorTest()
        {
            var corstudent = GetTestCorStudent();

            Assert.That(corstudent.Job, Is.EqualTo("Кафе Рандеву"));
            Assert.That(corstudent.Position, Is.EqualTo("Официант"));
        }

        [Test]
        public void GetInfo_CorStudent()
        {
            var corstudent = GetTestCorStudent();
            var lines = new[]
            {
                "Никита Смирнов УГИ-235109",
                "Номер зачётной книжки: 2023006 Институт: Гуманитарный Направление обучения: Бакалавр",
                "Студент заочного обучения - Место работы: Кафе Рандеву; Должность: Официант"
            };

            var info = corstudent.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private Correspondence GetTestCorStudent()
        {
            var full = new Correspondence("Никита", "Смирнов", 2023006, "УГИ-235109", "Гуманитарный", StudentsMajor.Bachelor, "Кафе Рандеву", "Официант");
            full.NumberClass = "УГИ-235109";
            full.Institute = "Гуманитарный";
            return full;
        }
    }
}
