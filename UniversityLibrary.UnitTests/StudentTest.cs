using NUnit.Framework;
using System.Reflection;
using University;
namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void CompareToTest()
        {
            var masha = new FullTimeStudent("Маша", "Комарова", 2023001, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 250);
            var kostya = new FullTimeStudent("Костя", "Степаненко", 2023002, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 244);
            var nikita = new FullTimeStudent("Никита", "Смирнов", 2023006, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 252);
            var misha = new FullTimeStudent("Миша", "Хвостовалов", 2023004, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 260);
            var lena = new FullTimeStudent("Лена", "Хвостовалова", 2023003, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 240);

            Assert.That(masha.CompareTo(nikita), Is.LessThan(0));
            Assert.That(kostya.CompareTo(masha), Is.GreaterThan(0));
            Assert.That(misha.CompareTo(lena), Is.LessThan(0));
            Assert.That(lena.CompareTo(lena), Is.EqualTo(0));
        }
    }
}

