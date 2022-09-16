using System.Data;

namespace ProductReviewSystem
{
    public static class UC12ProductHandler
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
            dataTable.Rows.Add(10, 11, 4, "bad", true);
            dataTable.Rows.Add(10, 12, 4, "better", true);
            dataTable.Rows.Add(10, 13, 2, "bad", false);
            dataTable.Rows.Add(10, 14, 1, "bad", false);
            dataTable.Rows.Add(10, 15, 5, "best", false);
            dataTable.Rows.Add(10, 16, 5, "best", true);
            dataTable.Rows.Add(10, 17, 4, "good", true);
            dataTable.Rows.Add(10, 18, 4, "good", true);
            dataTable.Rows.Add(10, 19, 3, "best", true);
            dataTable.Rows.Add(10, 20, 3, "bad", true);
            dataTable.Rows.Add(21, 21, 2, "good", true);
            dataTable.Rows.Add(22, 22, 5, "best", true);
            dataTable.Rows.Add(23, 23, 4, "bad", true);
            dataTable.Rows.Add(24, 24, 3, "good", true);
            dataTable.Rows.Add(25, 25, 2, "better", true);
        }
        public static void RetrieveAllWIthUserIdOrderRating()
        {
            string productsList = "";
            var res = (from product in dataTable.AsEnumerable() where product.Field<Int32>("UserId") == 10 orderby product.Field<int>("Rating") select product).ToList();
            foreach (var products in res)
            {
                Console.WriteLine("{0} ; {1} ; {2} ; {3} ; {4} ", products["ProductId"], products["UserId"], products["Rating"], products["Review"], products["IsLike"]);
                productsList += products["Rating"] + " ";
            }
        }
    }
}