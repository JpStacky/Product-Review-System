namespace ProductReviewSystem
{
    public class UC12Program
    {
        public static void Main()
        {
            UC12ProductHandler.CreateAndInsertToDatabase();
            UC12ProductHandler.GetRecordsReviewNice();
        }
    }
}
