using System;
namespace Sandbox.Lib
{
    public class Validator
    {

        public Boolean Check(int value) 
        {
            RandomGenerator _generator = RandomGenerator.GetInstance();
            if (value < _generator.RandomNumber)
            {
                Console.WriteLine("Go Higher......");
                return false;
            }
            else if (value > _generator.RandomNumber)
            {
                Console.WriteLine("Go Lower.......");
                return false;
            }
            Console.WriteLine("You Got It......");
            return true;
        }

        public static Boolean ValidateUserInput(String text)
        {
            Int32 Number;
            return Int32.TryParse(text, out Number);
           
        }

    }
}
