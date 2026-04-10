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

            var bigCategories = products.GroupBy(p => p.Category)
                                        .Where(g => g.Count() > 3)
                                        .Select(g => g.Key);

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
}
