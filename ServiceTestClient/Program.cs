namespace ServiceTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string ans = client.GetData(5);

        }
    }
}
