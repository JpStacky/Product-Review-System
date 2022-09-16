using System.Data;

namespace ProductReviewSystem
{
    public static class UC7ProductHandler
    {
        public static List<UC7ProductReview> productList = new List<UC7ProductReview>();
        public static List<UC7ProductReview> ListOfRecords()
        {
            productList.Add(new UC7ProductReview(1, 1, 5, "bad", false));
            productList.Add(new UC7ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC7ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC7ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC7ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC7ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC7ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC7ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC7ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void GetProductIdAndReview()
        {
            var products = ListOfRecords().Select(user => new
            {
                ProductId = user.ProductID,
                Review = user.Review
            });
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId + "" + product.Review);
            }
        }
    }
}