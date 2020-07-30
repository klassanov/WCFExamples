using System;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceClient.MathServiceReference.MathServiceClient client = new MathServiceClient.MathServiceReference.MathServiceClient();
            MathServiceClient.MathServiceReference.MathAnswer answer = client.Add(4, 5);
            Console.WriteLine(answer.Answer);

        }
    }
}
