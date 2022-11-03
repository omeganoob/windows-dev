namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                              from r in Ranks()
                              select new { Suit = s, Rank = r };
            //var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            Console.WriteLine("After shuffle");

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }

            var times = 0;
            shuffle = startingDeck;
            do
            {
                //shuffle = shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));
                //Optimizations
                shuffle = shuffle.Skip(26)
                .LogQuery("Bottom Half")
                .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
                .LogQuery("Shuffle")
                .ToArray();
                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;
            } while(!startingDeck.SequenceEqual(shuffle));

            Console.WriteLine(times);
        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
   
}