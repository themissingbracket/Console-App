using System;
namespace Sandbox.Applications
{
    public class RandomGuesser:IApplication
    {
        

        public void Start()
        {
            Lib.RandomGenerator.GetInstance().Generate();
            Lib.Validator validator = new Lib.Validator();
            Boolean isCorrect = false;
            while (!isCorrect)
            {

                isCorrect = validator.Check( Lib.UserInput.GetUserInput());


            }

            Console.WriteLine("Exiting.....");
        }
    }
}
