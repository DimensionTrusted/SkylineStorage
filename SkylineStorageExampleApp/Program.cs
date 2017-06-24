using System;

namespace SkylineStorageExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo.GetWelcomeInformation();
            Generator.GenerateDanceMatrix();
            Console.ReadKey();
        }

        private readonly static InformationHandler GetInfo = new InformationHandler();
        private readonly static MatrixGenerator Generator = new MatrixGenerator();
    }
}
