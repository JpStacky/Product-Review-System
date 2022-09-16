using System.Data;

namespace ProductReviewSystem
{
    public static class UC4ProductHandler
    {
        public static List<UC4ProductReview> productList = new List<UC4ProductReview>();
        public static List<UC4ProductReview> ListOfRecords()
        {
            productList.Add(new UC4ProductReview(1, 1, 5, "good", false));
            productList.Add(new UC4ProductReview(2, 2, 2, "good", false));
            productList.Add(new UC4ProductReview(7, 4, 3, "good", true));
            productList.Add(new UC4ProductReview(4, 2, 1, "bad", false));
            productList.Add(new UC4ProductReview(1, 1, 3.5, "good", true));
            productList.Add(new UC4ProductReview(2, 9, 3, "good", true));
            productList.Add(new UC4ProductReview(3, 7, 9.5, "good", true));
            productList.Add(new UC4ProductReview(7, 4, 4, "good", true));
            productList.Add(new UC4ProductReview(9, 0, 3, "good", true));
            return productList;
        }
        public static void GetCountOfRecordsByGroup()
        {
            var recordData = ListOfRecords()
                .GroupBy(user => user.ProductID).
                Select(user => new { ProductID = user.Key, Count = user.Count() });
            foreach (var reocrdCount in recordData)
            {
                Console.WriteLine(reocrdCount.ProductID + " ------- " + recordData.Count());
            }
        }
    }
}