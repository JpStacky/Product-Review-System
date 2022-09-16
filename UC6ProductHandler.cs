using System.Data;

namespace ProductReviewSystem
{
    public static class UC6ProductHandler
    {
        public static List<UC6ProductReview> productList = new List<UC6ProductReview>();
        public static List<UC6ProductReview> ListOfRecords()
        {
            productList.Add(new UC6ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC6ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC6ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC6ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC6ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC6ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC6ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC6ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC6ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void SkipTopFiveRecords()
        {
            var skipRecord = ListOfRecords().Skip(5).ToList();
            foreach (UC6ProductReview records in skipRecord)
            {
                Console.WriteLine("Product: {0},{1},{2},{3},{4}", records.ProductID, records.UserID, records.Ratings, records.Review, records.IsLike);
            }
        }
    }
}