namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
                { "Zelda", "Super Mario Bros.", "Kirby", "Just Dance", "Minecraft", "Donkey Kong" };

            var orderedVideoGames = videoGames.OrderBy(x => x.Length).ThenBy(x=>x).ToList();
            //ordered by length then alphabetized

            orderedVideoGames.ForEach(Console.WriteLine);
        }
    }
}
