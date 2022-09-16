using System.Data;

namespace ProductReviewSystem
{
    public static class UC3ProductHandler
    {
        public static List<UC3ProductReview> productList = new List<UC3ProductReview>();
        public static List<UC3ProductReview> ListOfRecords()
        {
            productList.Add(new UC3ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC3ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC3ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC3ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC3ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC3ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC3ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC3ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC3ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void GetRecordBasedOnRating()
        {
            var selectedRecords = from ProductReview in ListOfRecords()
                                  where (ProductReview.ProductID == 1 && ProductReview.Ratings > 3) ||
                                    (ProductReview.ProductID == 4 && ProductReview.Ratings > 3) ||
                                    (ProductReview.ProductID == 9 && ProductReview.Ratings > 3)
                                  select ProductReview;
            foreach (UC3ProductReview records in selectedRecords)
            {
                Console.WriteLine("Product: {0},{1},{2},{3},{4}", records.ProductID, records.UserID, records.Ratings, records.Review, records.IsLike);
            }
        }
    }
}