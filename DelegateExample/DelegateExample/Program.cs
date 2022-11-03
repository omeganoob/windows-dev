namespace DelegateExample
{
    internal class Program
    {
        public delegate void ShowLog(string message);
        static void Main(string[] args)
        {
            ShowLog sl = null;
            sl = Info;
            sl("This is some Info");

            sl = Warning;
            sl("This is a Warning");

            sl = Error;
            sl("This is an Error");

            sl = null;
            sl += Info;
            sl += Warning;
            sl += Error;
            sl("This is delegate with multiple method");
            Console.ReadLine();
        }

        public static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Info: {s}");
            Console.ResetColor();
        }

        public static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Warning: {s}");
            Console.ResetColor();
        }

        public static void Error(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {s}");
            Console.ResetColor();
        }
    }
}