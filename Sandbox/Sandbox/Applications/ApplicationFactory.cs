using System;
namespace Sandbox
{
    public class ApplicationFactory
    {
        public static Applications.IApplication getApplication(string Application)
        {
            return new Applications.RandomGuesser();
        }
    }
}
