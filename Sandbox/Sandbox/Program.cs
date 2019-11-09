using System;
using Sandbox;

namespace Sandbox
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Applications.IApplication app = ApplicationFactory.getApplication("");
            app.Start();

        }


    }

    
}
