namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            //1
            Journal journal = new Journal("TechTimes", 10);
            journal += 5;
            Console.WriteLine($"Journal Employees: {journal.Count}");


            //2
            Shop shop = new Shop("SuperMart", 500);
            shop -= 100;
            Console.WriteLine($"Shop Area: {shop.Area}");

            
        }
    }

    //1
    class Journal
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Journal(string name, int employ)
        {
            Name = name;
            Count = employ;
        }

        public static Journal operator +(Journal j, int count) => new Journal(j.Name, j.Count + count);
        public static Journal operator -(Journal j, int count) => new Journal(j.Name, Math.Max(0, j.Count - count));
        public static bool operator ==(Journal j1, Journal j2) => j1.Count == j2.Count;
        public static bool operator !=(Journal j1, Journal j2) => !(j1 == j2);
        public static bool operator <(Journal j1, Journal j2) => j1.Count < j2.Count;
        public static bool operator >(Journal j1, Journal j2) => j1.Count > j2.Count;

        public override bool Equals(object obj) => obj is Journal j && this == j;
        public override int GetHashCode() => Count.GetHashCode();
    }


    //2
    class Shop
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shop(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public static Shop operator +(Shop s, double extraArea) => new Shop(s.Name, s.Area + extraArea);
        public static Shop operator -(Shop s, double reduceArea) => new Shop(s.Name, Math.Max(0, s.Area - reduceArea));
        public static bool operator ==(Shop s1, Shop s2) => s1.Area == s2.Area;
        public static bool operator !=(Shop s1, Shop s2) => !(s1 == s2);
        public static bool operator <(Shop s1, Shop s2) => s1.Area < s2.Area;
        public static bool operator >(Shop s1, Shop s2) => s1.Area > s2.Area;

        public override bool Equals(object obj) => obj is Shop s && this == s;
        public override int GetHashCode() => Area.GetHashCode();
    }


    //3
    class Listbook
    {
        private List<string> books = new List<string>();

        public void AddBook(string book) => books.Add(book);
        public void RemoveBook(string book) => books.Remove(book);
        public bool Contains(string book) => books.Contains(book);

        public string this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }

        public static Listbook operator +(Listbook list, string book)
        {
            list.AddBook(book);
            return list;
        }

        public static Listbook operator -(Listbook list, string book)
        {
            list.RemoveBook(book);
            return list;
        }
    }

}
