namespace _431_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calories = Console.ReadLine().Split();
            int[] caloriesNum = new int[calories.Length];
            for (int i = 0; i < calories.Length; i++)
            {
                caloriesNum[i] = int.Parse(calories[i]);
            }

            string numArr = Console.ReadLine();
            int totalCalories = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                //char calory = numArr[i];
                totalCalories += caloriesNum[int.Parse(numArr[i].ToString()) - 1];
            }
            Console.WriteLine(totalCalories);
        }
    }
}