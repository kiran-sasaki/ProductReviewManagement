namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserId= 1,Rating =5,Review="good",isLike=true},
                new ProductReview(){ProductID=2,UserId= 14,Rating =3,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =2,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 7,Rating =1,Review="nice",isLike=true},
                 new ProductReview(){ProductID=5,UserId= 3,Rating =5,Review="bad",isLike=false},
                 new ProductReview(){ProductID=6,UserId= 16,Rating =4,Review="good",isLike=false},
                new ProductReview(){ProductID=8,UserId= 9,Rating =4,Review="worst",isLike=true},
                 new ProductReview(){ProductID=8,UserId= 8,Rating =1,Review="good",isLike=true},
                  new ProductReview(){ProductID=9,UserId= 5,Rating =4,Review="good",isLike=false},
                 new ProductReview(){ProductID=10,UserId= 45,Rating =5,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =5,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =1,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =4,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =3,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 10,Rating =2,Review="good",isLike=true},
            };

            Mangement mangement = new Mangement();
            //UC2
            mangement.TopRecords(productReviewList);
            //UC3
            mangement.SelectRecords(productReviewList);
            //UC4
            mangement.RetriveCountOfRecords(productReviewList);
            //UC7
            mangement.RetrieveproductIdandreview(productReviewList);
            //UC6
            mangement.SkipReords(productReviewList);
            //UC9
            mangement.RetrieveRecordsUsingVariable(productReviewList);
            //UC11
            mangement.RetrieveRecordsUsingReview(productReviewList);
            //UC12
            mangement.RetrieveRecordsUsingUserId(productReviewList);
            //UC10
            mangement.AverageRating(productReviewList);
        }
    }
}
