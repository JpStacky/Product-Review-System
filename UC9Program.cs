namespace ProductReviewSystem
{
    public class UC9Program
    {
        public static void Main()
        {
            UC9ProductHandler.CreateAndInsertToDatabase();
            UC9ProductHandler.GetRecordsValueIsLike();
        }
    }
}
