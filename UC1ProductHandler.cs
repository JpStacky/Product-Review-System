using System.Data;

namespace ProductReviewSystem
{
    public static class UC1ProductHandler
    {
        public static List<UC1ProductReview> productList = new List<UC1ProductReview>();
        public static List<UC1ProductReview> ListOfRecords()
        {
            productList.Add(new UC1ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC1ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC1ProductReview(3, 4, 3, "good", true));
            productList.Add(new UC1ProductReview(4, 5, 1, "bad", false));
            productList.Add(new UC1ProductReview(6, 1, 3.5, "good", true));
            productList.Add(new UC1ProductReview(2, 4, 3, "good", true));
            productList.Add(new UC1ProductReview(7, 7, 4.5, "good", true));
            productList.Add(new UC1ProductReview(1, 4, 4, "good", true));
            productList.Add(new UC1ProductReview(9, 8, 3, "good", true));
            productList.Add(new UC1ProductReview(7, 3, 1, "bad", false));
            productList.Add(new UC1ProductReview(11, 1, 5, "good", true));
            productList.Add(new UC1ProductReview(3, 10, 3, "good", false));
            return productList;
        }
    }
}