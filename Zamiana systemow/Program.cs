namespace Zamiana_systemow
{
    internal class Program
    {
        static double convert(string number, int baseNumber)
        {
            double result = 0;

            for(int i = 0; i < number.Length; i++)
            {
                result += int.Parse(number[i].ToString()) * Math.Pow(baseNumber, number.Length - i - 1);
            }

            return result;
        }
        static void Main(string[] args)
        {
            double result = convert("1010", 2);
            double secondResult = convert("325", 10);

            Console.WriteLine(result);
            Console.WriteLine(secondResult);
        }
    }
}