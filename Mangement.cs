using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Mangement
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              orderby productReview.Rating descending
                              select productReview).Take(3);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductID = " +list.ProductID+" UserId= "+list.UserId+" Rating= "+list.Rating+" Review = "+list.Review);
            }
        }

        public void SelectRecords(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              where (productReview.ProductID == 1 && productReview.Rating > 3) || (productReview.ProductID == 4 && productReview.Rating > 3) || (productReview.ProductID == 9 && productReview.Rating > 3)
                              select productReview);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID = " + list.ProductID + " UserId= " + list.UserId + " Rating= " + list.Rating + " Review = " + list.Review);
            }
        }

        public void RetriveCountOfRecords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var record in recordedData)
            {
                Console.WriteLine("ProductID ="+ record.ProductID+" Count= "+record.Count);
            }
        }
        public void RetrieveproductIdandreview(List<ProductReview> review)
        {
            var recordedData = review.Select(x => new { x.ProductID, x.Review }).ToList();
            foreach (var record in recordedData)
            {
                Console.WriteLine("ProductID =" + record.ProductID + " Review = " +record.Review);
            }
        }

        public void SkipReords(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              select productReview).Skip(5);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID = " + list.ProductID + " UserId= " + list.UserId + " Rating= " + list.Rating + " Review = " + list.Review);
            }
        }

        public void RetrieveRecordsUsingVariable(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              where(productReview.isLike = true)
                              select productReview).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID = " + list.ProductID + " UserId= " + list.UserId + " Rating= " + list.Rating + " Review = " + list.Review+" islike= "+list.isLike);
            }
        }

        public void AverageRating(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, AverageData = x.Average(productReview => productReview.Rating) });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId= " + list.ProductID + " AverageRatings=" + list.AverageData);
            }


        }

        public void RetrieveRecordsUsingReview(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              where (productReview.Review == "nice")
                              select productReview).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID = " + list.ProductID + " UserId= " + list.UserId + " Rating= " + list.Rating + " Review = " + list.Review + " islike= " + list.isLike);
            }
        }

        public void RetrieveRecordsUsingUserId(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              where productReview.UserId ==10
                              orderby productReview.Rating descending
                              select productReview);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID = " + list.ProductID + " UserId= " + list.UserId + " Rating= " + list.Rating + " Review = " + list.Review);
            }
        }
    }

}

