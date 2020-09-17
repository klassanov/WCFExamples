using System;
using System.ServiceModel;
using WcfServiceTestLibrary;

namespace MathClientChannelFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://localhost:8080/Service1.svc");
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>();// binding, endpoint);
            IService1 service = factory.CreateChannel();
            string ans = service.GetData(3);
            factory.Close();
            Console.WriteLine($"Answer:{ans}");

        }
    }
}
