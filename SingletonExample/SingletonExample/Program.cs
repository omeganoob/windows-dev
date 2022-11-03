namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.Instance;

            Singleton anotherSingleton = Singleton.Instance;

            Console.ReadLine();
        }
    }
}