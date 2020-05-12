using System.Collections;

namespace iterator_sample
{
  internal class StudentsEnumerator : IEnumerator
  {
    private Group2 group2;
    private int currentIndex = -1;

    public StudentsEnumerator(Group2 group2)
    {
      this.group2 = group2;
    }

    public object Current {
      get {
        while (group2[currentIndex] == null)
        {
            if (!MoveNext())
            {
                break;
            }
        }
        return group2[currentIndex];
      }
    }

    public bool MoveNext()
    {
      if(currentIndex < group2.Count - 1)
      {
        currentIndex++;
        return true;
      }
      return false;
    }

    public void Reset()
    {
      currentIndex = -1;
    }
  }
}