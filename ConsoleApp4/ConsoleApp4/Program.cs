namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        //1
        public static int GenerateChot(int start)
        {
            return (start % 2 == 0) ? start : start + 1;
        }
        public static int GenerateNotChot(int start)
        {
            return (start % 2 != 0) ? start : start + 1;
        }


        //2
        public static bool Generator(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }


        //3
        public static int Fibonachi(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
