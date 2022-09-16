namespace ProductReviewSystem
{
    public class UC11Program
    {
        public static void Main()
        {
            UC11ProductHandler.CreateAndInsertToDatabase();
            UC11ProductHandler.GetRecordsReviewNice();
        }
    }
}
