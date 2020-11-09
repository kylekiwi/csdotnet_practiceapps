namespace DiPractice
{
  public class MyLogger : IMyLogger
  {
  
    public void log()
    {
      System.Console.WriteLine("Hey I am logger!");
    }
  }
}