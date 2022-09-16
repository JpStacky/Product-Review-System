using System.Data;

namespace ProductReviewSystem
{
    public class UC2ProductHandler
    {
        public static List<UC2ProductReview> productList = new List<UC2ProductReview>();
        public static List<UC2ProductReview> ListOfRecords()
        {
            productList.Add(new UC2ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC2ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC2ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC2ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC2ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC2ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC2ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC2ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC2ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void TopRecords()
        {
            var topRecords = (from ProductReview in ListOfRecords()
                              orderby ProductReview.Ratings descending
                              select ProductReview
                            ).Take(3);
            foreach (UC2ProductReview review in topRecords)
            {
                Console.WriteLine("Product: {0},{1},{2},{3},{4}", 
                                review.ProductID, review.UserID, review.Ratings, review.Review, review.IsLike);
            }
        }
    }
}