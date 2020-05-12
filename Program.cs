using System;

namespace iterator_sample
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Group g1 = new Group() {Name = "GName1"};
          // g1[0] =
            g1.Add(new Student() {FirstName = "FN1", Surename = "SN1", Age = 20, AvgScore = 10.5});
          // g1[100] =
            g1.Add(new Student() {FirstName = "FN2", Surename = "SN2", Age = 21, AvgScore = 10.0});
          // g1[200] =
            g1.Add(new Student() {FirstName = "FN3", Surename = "SN3", Age = 19, AvgScore = 11.5});
          var studentsEnumerator = g1.GetEnumerator();
          while (studentsEnumerator.MoveNext())
          {
            Student currentStudent = (Student)studentsEnumerator.Current;
            if (currentStudent != null)
            {
              System.Console.WriteLine($"{currentStudent.FirstName} {currentStudent.Surename} ({currentStudent.AvgScore})");
            }
          }
          // System.Console.WriteLine(g1[200].FirstName);
          System.Console.WriteLine(g1[2].FirstName); */

          Group2 g2 = new Group2() {Name = "GName2"};
          g2[0] =
            new Student() {FirstName = "FN1", Surename = "SN1", Age = 20, AvgScore = 10.5};
          g2[100] =
            new Student() {FirstName = "FN2", Surename = "SN2", Age = 21, AvgScore = 10.0};
          g2[200] =
            new Student() {FirstName = "FN3", Surename = "SN3", Age = 19, AvgScore = 11.5};
          
          var studentsEnumerator = g2.GetEnumerator();
          while (studentsEnumerator.MoveNext())
          {
            Student currentStudent = (Student)studentsEnumerator.Current;
            System.Console.WriteLine($"{currentStudent.FirstName} {currentStudent.Surename} ({currentStudent.AvgScore})");
          }

          System.Console.WriteLine(g2[0].FirstName);
          System.Console.WriteLine(g2[100].FirstName);
          System.Console.WriteLine(g2[200].FirstName);

          foreach (Student currentStudent in g2)
          {
            System.Console.WriteLine($"{currentStudent.FirstName} {currentStudent.Surename} ({currentStudent.AvgScore})");
          }
        }
    }
}
