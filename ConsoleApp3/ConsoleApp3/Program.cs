namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 2, 3, 4, 6, 6, 7 };
            Array arr = new Array(values);

            Console.WriteLine(arr.Less(4));
            Console.WriteLine(arr.Greater(4));

            arr.ShowEven();
            arr.ShowOdd();

            Console.WriteLine(arr.CountDistinct());
            Console.WriteLine(arr.EqualToValue(2));
        }
    }

    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    class Array : ICalc, IOutput2, ICalc2
    {
        private int[] dat;

        public Array(int[] values)
        {
            dat = values;
        } 
        public int Less(int valueToCompare)
        {
            return dat.Count(x => x < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return dat.Count(x => x > valueToCompare);
        }
        public void ShowEven()
        {
            Console.WriteLine("Четные значения: " + string.Join(", ", dat.Where(x => x % 2 == 0)));
        }

        public void ShowOdd()
        {
            Console.WriteLine("Нечетные значения: " + string.Join(", ", dat.Where(x => x % 2 != 0)));
        }

        public int CountDistinct()
        {
            return dat.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return dat.Count(x => x == valueToCompare);
        }
    }
}

