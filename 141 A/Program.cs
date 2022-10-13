using System.Security.Cryptography;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _141_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestName = Console.ReadLine();
            string hostName = Console.ReadLine();
            string randomName = Console.ReadLine();
            bool flag= true;


            List<char> guestNameDistinctChars = distinctCharacters(guestName);
            List<char> hostNameDistinctChars = distinctCharacters(hostName);
            List<char> randomNameDistinctChars = distinctCharacters(randomName);
            List<char> commonDistinctChars = new List<char>();


            foreach (var item in guestNameDistinctChars)
            {
                commonDistinctChars.Add((char)item);
            }
            foreach (var item in hostNameDistinctChars)
            {
                if(!commonDistinctChars.Contains(item))
                {
                    commonDistinctChars.Add((char)item);
                }
            }

            bool isEqual = Enumerable.SequenceEqual(commonDistinctChars.OrderBy(e => e), guestNameDistinctChars.OrderBy(e => e));

           /* try
            {
                CollectionAssert.AreEquivalent(x, y);
                Console.WriteLine("Both Sequences have same elements");
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Both Sequences have different elements");
            }*/

            /*if (!isEqual)
            {
                flag = false;
            }
            else
            {*/
                foreach (var item in commonDistinctChars)
                {
                    int count = 0;
                    count += letterFrequency(guestName, (char)item);
                    count += letterFrequency(hostName, (char)item);

                    if(count!= letterFrequency(randomName, item))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        randomNameDistinctChars.Remove(item);
                        count = 0;
                    }
                }
            //}

            //Console.WriteLine(String.Join(" ", randomNameDistinctChars));

           if (flag && randomNameDistinctChars.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }

        static List<char> distinctCharacters(string name)
        {
            List<char> result = new List<char>();
            foreach (char c in name)
            {
                if(!result.Contains(c))
                {
                    result.Add(c);
                }
            }
            return result;
        }

        static int letterFrequency(string name, char ch)
        {
            int number = 0;
            foreach(char c in name)
            {
                if(c==ch)
                    number++;
            }
            return number;
        }
    }
}