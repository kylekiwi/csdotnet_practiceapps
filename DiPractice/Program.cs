using System;

namespace DiPractice
{
  public interface text 
  {
    void print();
  }
  class format : text
  {
    public void print()
    {
      System.Console.WriteLine(" here is text format");
    }
  }

  public class constructorinjection
  {
    text _text;
    public constructorinjection(text t1)
    {
      this._text = t1;
    }
    public void print()
    {
      _text.print();
    }
  }
  
  class Program
  {
    static void Main(string[] args)
    {
      constructorinjection cs = new constructorinjection(new format());
      cs.print();
      Console.ReadKey();
    }
  }
}
