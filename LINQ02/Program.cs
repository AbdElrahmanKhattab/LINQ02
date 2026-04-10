namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Sample Data

            List<Product> products = new List<Product>
            {
                new Product{ Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product{ Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product{ Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product{ Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product{ Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product{ Id=6, Name="Coffee", Category="Food", Price=15, Stock=80 },
                new Product{ Id=7, Name="Book", Category="Books", Price=45, Stock=30 },
                new Product{ Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product{ Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                new Product{ Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };


            List<Customer> customers = new List<Customer>
            {
                new Customer{ Name="Ahmed", Country="Egypt", OrderValue=500 },
                new Customer{ Name="Sara", Country="Germany", OrderValue=300 },
                new Customer{ Name="Ali", Country="Egypt", OrderValue=700 },
                new Customer{ Name="Mona", Country="France", OrderValue=200 }
            };



            #endregion




            #region 1 Top 3 Expensive

            //var top3 = products.OrderByDescending(p => p.Price).Take(3);

            #endregion


            #region 2 Page 2 (Skip + Take)

            //var page2 = products.Skip(5).Take(5);

            #endregion



            #region 3 TakeWhile

            //var cheapUntil25 = products.OrderBy(p => p.Price)
            //                           .TakeWhile(p => p.Price < 25);

            #endregion


            #region 4 All Seafood In Stock

            //var seafoodCheck = products
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.Stock > 0);

            #endregion

            #region 5 Contains

            //int[] ids = { 3, 9, 13, 18 };
            //bool contains9 = ids.Contains(9);

            #endregion

            #region 6 Group + Count

            //var group1 = products.GroupBy(p => p.Category);

            //foreach (var g in group1)
            //{
            //    Console.WriteLine($"{g.Key} Count: {g.Count()}");
            //}

            #endregion


            #region 7 Group Names Only

            //var groupNames = products.GroupBy(p => p.Category)
            //                         .Select(g => new
            //                         {
            //                             Category = g.Key,
            //                             Names = g.Select(p => p.Name)
            //                         });

            #endregion


            #region 8 Categories > 3 Products

            //var bigCategories = products.GroupBy(p => p.Category)
            //                            .Where(g => g.Count() > 3)
            //                            .Select(g => g.Key);

            #endregion

            #region 9 Query Syntax Group Customers

            //var query =
            //    from c in customers
            //    group c by c.Country into g
            //    select new
            //    {
            //        Country = g.Key,
            //        Count = g.Count(),
            //        TotalOrderValue = g.Sum(x => x.OrderValue)
            //    };

            #endregion


            #region 10 Total Stock

            //int totalStock = products.Sum(p => p.Stock);

            #endregion

            #region 11 Min / Max Price

            //double min = products.Min(p => p.Price);
            //double max = products.Max(p => p.Price);

            #endregion

            #region 12 Distinct Categories

            //var categories = products.Select(p => p.Category).Distinct();

            #endregion

            #region 13 Except (Set Difference)

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var diff = setA.Except(setB);

            #endregion

            #region 14 Case-insensitive Except

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region 15 ToDictionary

            //var dict = products.ToDictionary(p => p.Id);

            //Console.WriteLine(dict[1].Name);

            #endregion


            #region 16 First > 50

            //var first50 = products.First(p => p.Price > 50);

            #endregion


            #region 17 FirstOrDefault

            //var first500 = products.FirstOrDefault(p => p.Price > 500);

            #endregion



            #region 18 Multiplication Table

            //var table = Enumerable.Range(1, 10)
            //                      .Select(x => 7 * x);

            #endregion


            #region 19 Even Numbers

            //var evens = Enumerable.Range(1, 30)
            //                      .Where(x => x % 2 == 0);

            #endregion



            #region 20 Concat

            //var combined = products.Take(3).Select(p => p.Name)
            //    .Concat(customers.Take(3).Select(c => c.Name));

            #endregion


            #region 21 Zip

            var zipped = products.Zip(customers,
                (p, c) => $"{p.Name} sold to {c.Name}");

            foreach (var z in zipped)
                Console.WriteLine(z);

            #endregion
        }
    }

    class Product
    {
        public int Id;
        public string Name;
        public string Category;
        public double Price;
        public int Stock;
    }

    class Customer
    {
        public string Name;
        public string Country;
        public double OrderValue;
    }
}
