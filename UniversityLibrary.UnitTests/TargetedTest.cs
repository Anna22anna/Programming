using University;

namespace UniversityLibrary.UnitTests
{

    [TestFixture]
    public class TargetedTest
    {
        [Test]
        public void ConstructorTest()
        {
            var targstudent = GetTestTargStudent();

            Assert.That(targstudent.Company, Is.EqualTo("СКБ Контур"));
            Assert.That(targstudent.Summ, Is.EqualTo(250000));
        }

        [Test]

        public void GetInfo_TargStudent()
        {
            var targstudent = GetTestTargStudent();
            var lines = new[]
            {
                "Никита Смирнов УГИ-235109",
                "Номер зачётной книжки: 2023006 Институт: Гуманитарный Направление обучения: Бакалавр",
                "Студент целевого обучения - Целевое предприятие: СКБ Контур; Сумма обучения: 250000"
            };

            var info = targstudent.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private TargetedStudent GetTestTargStudent()
        {
            var targ = new TargetedStudent("Никита", "Смирнов", 2023006, "УГИ-235109", "Гуманитарный", StudentsMajor.Bachelor, "СКБ Контур", 250000);
            targ.NumberClass = "УГИ-235109";
            targ.Institute = "Гуманитарный";
            return targ;
        }
    }
}
