using NUnit.Framework;
using System.Reflection;
using University;
namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class AcademicGroupTest
    {
        AcademicGroup group;
        FullTimeStudent[] students;

        [SetUp]
        public void SetUp()
        {
            var masha = new FullTimeStudent("Маша", "Комарова", 2023001, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 250);
            var kostya = new FullTimeStudent("Костя", "Степаненко", 2023002, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 244);
            var nikita = new FullTimeStudent("Никита", "Смирнов", 2023006, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 252);
            var misha = new FullTimeStudent("Миша", "Хвостовалов", 2023004, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 260);
            var lena = new FullTimeStudent("Лена", "Хвостовалова", 2023003, "УГИ - 235109", "Гуманитарный", StudentsMajor.Bachelor, 240);

            students = new FullTimeStudent[] { masha, kostya, nikita, misha, lena };

            group = new AcademicGroup("Интеллектуальные системы в гуманитарной сфере", students);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(group.Title, Is.EqualTo("Интеллектуальные системы в гуманитарной сфере"));

            foreach (var student in students)
                Assert.That(group.Count(s => s.Equals(student)), Is.EqualTo(1));
        }

        [Test]
        public void CountTest()
        {
            Assert.That(group.Count, Is.EqualTo(5));
        }

        [Test]
        public void IEnumerableTest()
        {
            var i = 0;
            foreach (var student in group)
                Assert.That(student, Is.SameAs(students[i++]));
        }
    }
}


