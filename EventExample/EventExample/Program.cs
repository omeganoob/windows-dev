namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            SubcriberA subcriberA = new SubcriberA();
            SubcriberB subcriberB = new SubcriberB();

            subcriberA.Sub(pub);
            subcriberB.Sub(pub);

            pub.Send();
        }
    }

    public class SubcriberA
    {
        public void Sub(Publisher pub)
        {
            pub.event_news += ReceivedFromPublisher;
        }

        void ReceivedFromPublisher(object data)
        {
            Console.WriteLine($"SubcriberA: {data.ToString()}");
        }
    }

    public class SubcriberB
    {
        public void Sub(Publisher pub)
        {
            pub.event_news += ReceivedFromPublisher;
        }

        void ReceivedFromPublisher(object data)
        {
            Console.WriteLine($"SubcriberB: {data.ToString()}");
        }
    }
}