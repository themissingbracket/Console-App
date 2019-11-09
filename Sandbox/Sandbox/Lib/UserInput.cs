using System;
namespace Sandbox.Lib
{
    public class UserInput
    {
        public static int GetUserInput()
        {
            const string Message = "Please Enter a Number Between 1 and 100";
            Console.WriteLine(Message);
            var userInput = Console.ReadLine();
            bool isValid = Validator.ValidateUserInput(userInput);
            while (!isValid)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine(Message);
                userInput = Console.ReadLine();
                isValid = Validator.ValidateUserInput(userInput);
            }

            return Int32.Parse(userInput);
        }
    }
}
