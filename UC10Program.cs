namespace ProductReviewSystem
{
    public class UC10Program
    {
        public static void Main()
        {
            UC10ProductHandler.CreateAndInsertToDatabase();
            UC10ProductHandler.GetAverageRating();
        }
    }
}
