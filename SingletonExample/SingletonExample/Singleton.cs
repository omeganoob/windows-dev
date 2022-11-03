namespace SingletonExample
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private Singleton() {}

        public static Singleton Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        Console.WriteLine("No instance exists, Create new one");
                        instance = new Singleton();
                    }
                    Console.WriteLine("An instance already existed");
                    return instance;
                }
            }
        }
    }
}
