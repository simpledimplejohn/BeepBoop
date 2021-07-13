using System; //give us access to the Console object and its methods
using System.Collections.Generic;
using BeepBoop.Calculating;


namespace BeepBoop
{
  class Program 
  {
    static void Main() //automatically run, an entry point method
    {
      Console.WriteLine("enter a number: ");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);

      int[] numberArray = new int[number];  

      for(int i = 0; i < number; i++)
      {
        numberArray[i] = i;
      }
      Console.WriteLine(numberArray);
      

    }
  }
}