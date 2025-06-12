using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class AcademicGroup : IEnumerable<Student>
    {
        public string Title { get; set; }

        List<Student> studentt;

        public int Count { get =>  studentt.Count; }

        public AcademicGroup(string title, IEnumerable<Student> students)
        {
            Title = title;
            studentt = new List<Student>();
            foreach (var student in students)
                if (!studentt.Contains(student))
                    studentt.Add(student);
        }
        public IEnumerator<Student> GetEnumerator() => studentt.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
