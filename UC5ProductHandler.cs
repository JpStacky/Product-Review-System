using System.Data;

namespace ProductReviewSystem
{
    public static class UC5ProductHandler
    {
        public static List<UC5ProductReview> productList = new List<UC5ProductReview>();
        public static List<UC5ProductReview> ListOfRecords()
        {
            productList.Add(new UC5ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC5ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC5ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC5ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC5ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC5ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC5ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC5ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC5ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void GetProductId()
        {
            var getProductId = ListOfRecords()
                .GroupBy(user => user.ProductID).
                Select(user => new { ProductID = user.Key, Count = user.Count() });
            foreach (var reocrdCount in getProductId)
            {
                Console.WriteLine(reocrdCount.ProductID + " ------- " + getProductId.Count());
            }
        }
    }
}