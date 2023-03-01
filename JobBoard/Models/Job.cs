using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    public string Description { get; set; }
    private static List<Job> _instances = new List<Job> { };

    public Job(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}