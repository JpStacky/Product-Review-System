namespace ProductReviewSystem
{
    public class UC5ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Ratings { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
        public UC5ProductReview(int ProductID, int UserID, double Ratings, string Review, bool IsLike)
        {
            this.ProductID = ProductID;
            this.UserID = UserID;
            this.Ratings = Ratings;
            this.Review = Review;
            this.IsLike = IsLike;
        }

    }
}
