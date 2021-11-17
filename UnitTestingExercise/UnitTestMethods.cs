using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three; 
        }
        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend,  int subtrhend)
        {
            return minuend - subtrhend;
        }
        // Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            return one * two;
        }
        // Create a Divide method that passes 2 integers

        public static int Divide(int one, int two)
        {
            return one / two;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
       public string YourMethodName()
       {
            return "BNR";

       }

        public static string YourMethodName2()
        {
            return "BIG EYES";

        }

    }
}
