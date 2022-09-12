namespace _32_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string borzeCode = Console.ReadLine();
            List<char> decodedNum = new List<char>();
            for (int i = 0; i < borzeCode.Length;)
            {
                if(borzeCode[i] == '.')
                {
                    decodedNum.Add('0');
                    i++;
                }
                else
                {
                    if (borzeCode[i+1]=='.')
                    {
                        decodedNum.Add('1');

                    }
                    else
                    {
                        decodedNum.Add('2');
                    }
                    i = i + 2;
                }
            }

            string decodedFullNum = "";
            for (int i = 0; i < decodedNum.Count; i++)
            {
                decodedFullNum += decodedNum[i];
            }
            Console.WriteLine($"{decodedFullNum}");
        }
    }
}