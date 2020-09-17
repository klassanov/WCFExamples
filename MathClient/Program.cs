namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathServiceClient client = new MathServiceClient();
            //var answer = client.Add(5, 6);
            //Console.WriteLine($"Answer: {answer.Answer}");


            //TestServiceReference.Service1Client client1 = new TestServiceReference.Service1Client();
            //string a = client1.GetData(3);
            //answer = client.Divde(5, 0);


            Service1Client client = new Service1Client();
            string data = client.GetData(34);
        }
    }
}
