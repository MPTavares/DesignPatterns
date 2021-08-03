using ChainOfResponsability.Classes;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            //This a simple example of Chain of Responsability pattern.

            int[] requests = new int[] { 2, 20, 5, 10, 3, 30 };

            var initialAlert = new GreenAlertTreatment();
            var secondAlert = new YellowAlertTreatment();
            var thirdAlert = new RedAlertTreatment();

            initialAlert.SetSucessor(secondAlert);
            secondAlert.SetSucessor(thirdAlert);


            foreach (var request in requests)
            {
                initialAlert.ProcessErrorResponses(request);
            }

            Console.ReadLine();
        }
    }
}
