using DependencyInjection.BL.NoTouch;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseNoTouch _baseNoTouch;
            string[] clientsToProcess = new string[] { "UHC", "Anthem", "Aetna", "BCBSNJ" };
            foreach (string client in clientsToProcess)
            {
                Console.WriteLine(client+"-----");
                switch (client)
                {
                    case "Anthem":
                        _baseNoTouch = new AnthemNoTouch();
                        break;

                    default:
                        _baseNoTouch = new BaseNoTouch();
                        break;
                }
                _baseNoTouch.GetConceptClaims();
                _baseNoTouch.LoadNoTouchClaims();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
