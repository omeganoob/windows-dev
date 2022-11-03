namespace EventExample
{
    public class Publisher
    {
        public delegate void Notify(object data);

        public Notify event_news;

        public void Send()
        {
            event_news?.Invoke("New Notification!");
        }
    }
}
