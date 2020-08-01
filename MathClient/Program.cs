using MathClient.ServiceReference1;
using System;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceClient client = new MathServiceClient();
            var answer = client.Add(5, 6);
            Console.WriteLine($"Answer: {answer.Answer}");

            //answer = client.Divde(5, 0);
        }
    }
}
