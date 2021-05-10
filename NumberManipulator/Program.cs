using System;

namespace NumberManipulator
{
  class Program
  {
    static void Main(string[] args)
    {
      var myInt = 12;
      Console.WriteLine(myInt);
      myInt = (myInt * myInt) + 14 - 3;
      Console.WriteLine(myInt);
    }
  }
}
