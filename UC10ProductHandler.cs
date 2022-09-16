using System.Data;

namespace ProductReviewSystem
{
    public static class UC10ProductHandler
    {
        public static DataTable dataTable = new DataTable();
        public static void CreateAndInsertToDatabase()
        {
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike");
            dataTable.Rows.Add(1, 1, 5, "bad", false);
            dataTable.Rows.Add(2, 2, 5, "good", true);
            dataTable.Rows.Add(3, 3, 4, "better", true);
            dataTable.Rows.Add(4, 4, 3, "good", false);
            dataTable.Rows.Add(5, 5, 5, "best", true);
            dataTable.Rows.Add(6, 6, 4, "good", true);
            dataTable.Rows.Add(7, 7, 3, "good", true);
            dataTable.Rows.Add(8, 8, 4, "good", true);
            dataTable.Rows.Add(9, 9, 1, "worst", true);
            dataTable.Rows.Add(10, 10, 5, "best", true);
            dataTable.Rows.Add(11, 11, 4, "bad", true);
            dataTable.Rows.Add(12, 12, 4, "better", true);
            dataTable.Rows.Add(13, 13, 2, "bad", false);
            dataTable.Rows.Add(14, 14, 1, "bad", false);
            dataTable.Rows.Add(15, 15, 5, "best", false);
            dataTable.Rows.Add(16, 16, 5, "best", true);
            dataTable.Rows.Add(17, 17, 4, "good", true);
            dataTable.Rows.Add(18, 18, 4, "good", true);
            dataTable.Rows.Add(19, 19, 3, "best", true);
            dataTable.Rows.Add(20, 20, 3, "bad", true);
            dataTable.Rows.Add(21, 21, 2, "good", true);
            dataTable.Rows.Add(22, 22, 5, "best", true);
            dataTable.Rows.Add(23, 23, 4, "bad", true);
            dataTable.Rows.Add(24, 24, 3, "good", true);
            dataTable.Rows.Add(25, 25, 2, "better", true);
        }
        public static string GetAverageRating()
        {
            string result = "";
            var res = from product in dataTable.AsEnumerable() group product by product.Field<int>("ProductId") into temp select new { ProductId = temp.Key, Average = Math.Round(temp.Average(x => x.Field<int>("Rating")), 1) };
            foreach (var ratings in res)
            {
                Console.WriteLine("Product id: {0} Average Rating: {1}", ratings.ProductId, ratings.Average);
                result += ratings.Average + " ";
            }
            return result;
        }
    }
}