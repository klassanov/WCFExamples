﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceTestLibrary;

namespace ServiceTestHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Service1.svc");
            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), "Service1");

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
