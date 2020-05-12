using System.Collections;
using System.Collections.Generic;

namespace iterator_sample
{
  class Group : IEnumerable
  {
    private List<Student> students =
      new List<Student>();
    public string Name { get; set; }
    public double AvgScore { get; set; }

    public Student this[int index]
    {
        get { return students[index]; }
        /* set { 
          // students[index] = value;
          // students.Add(value);
          if (index > students.Count - 1)
          {
            students.AddRange(new Student[index - students.Count + 1]);
          }
          students.Insert(index, value);
        } */
    }
    public void Add(Student student){
      students.Add(student);
    }
    public IEnumerator GetEnumerator()
    {
      return students.GetEnumerator();
    }
  }
}