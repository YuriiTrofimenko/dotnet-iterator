using System.Collections;
using System.Collections.Generic;

namespace iterator_sample
{
  class Group2 : IEnumerable
  {
    private List<Student> students =
      new List<Student>();
    public string Name { get; set; }
    public double AvgScore { get; set; }

    public Student this[int index]
    {
        get { return students[index]; }
        set {
          if (index == 0 && students.Count == 0)
          {
              students.Add(value);
          } else {
            if (index > students.Count - 1)
            {
              students.AddRange(new Student[index - students.Count]);
            }
            students.Insert(index, value);
          }
        }
    }
    public IEnumerator GetEnumerator()
    {
      return new StudentsEnumerator(this);
    }
    public int Count => students.Count;
  }
}