using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibrarySuccess;

namespace MathServiceHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "aBc";
            string ABC = "AbC";
            bool areEqual = abc.Equals(ABC);




            Uri baseAddress = new Uri("http://localhost:8081/MathService/");
            ServiceHost selfHost = new ServiceHost(typeof(MathService), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IMathService), new WSHttpBinding(), "MathService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The service is ready");

                Console.WriteLine("Press <Enter> to stop the service");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("An exception occurred: {0}", ex.Message);
                selfHost.Abort();
            }
        }
    }
}
