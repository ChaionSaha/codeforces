namespace _43_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> distinctTeams = new List<string>();
            List<string> allTeams = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string teamName = Console.ReadLine();
                allTeams.Add(teamName);
                if(!distinctTeams.Contains(teamName))
                    distinctTeams.Add(teamName);
            }

            int[] scores = new int[distinctTeams.Count];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = frequencyCheck(allTeams.ToArray(), distinctTeams[i]);
            }

            int index = Array.IndexOf(scores, scores.Max());
            Console.WriteLine(distinctTeams[index]);

        }

        static int frequencyCheck(string[] team, string checker)
        {
            int count = 0;

            for (int i = 0; i < team.Length; i++)
            {
                if (team[i] == checker)
                    count++;
            }

            return count;
        }
    }
}