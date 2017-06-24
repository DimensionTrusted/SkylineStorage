using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineStorageExampleApp
{
    public sealed class InformationHandler
    {
        public void GetWelcomeInformation()
        {
            Console.WriteLine(WelcomeMessage);
            Console.ReadKey();
        }

        private readonly string WelcomeMessage = "The Skyline Storage Matrix allows use matrix in DANCE-compressed format and recompres it in native view;";
    }
}
