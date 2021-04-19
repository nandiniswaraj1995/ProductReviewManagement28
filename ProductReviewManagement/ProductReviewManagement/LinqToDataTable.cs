using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{
    class LinqToDataTable
    {
        public void AddToDataTableDemo()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProducID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");


            table.Rows.Add(1, 1,3,"Good",true);
            table.Rows.Add(2, 2,4,"best",true);
            table.Rows.Add(3, 3,2,"bad",false);
            table.Rows.Add(4, 4, 3, "Good", true);
            table.Rows.Add(5, 4, 4, "best", true);
            table.Rows.Add(5, 6, 2, "bad", false);
            table.Rows.Add(1, 1, 3, "Good", true);
            table.Rows.Add(2, 2, 4, "best", true);
            table.Rows.Add(3, 3, 2, "bad", false);
            table.Rows.Add(1, 1, 3, "Good", true);
            table.Rows.Add(2, 2, 4, "best", true);
            table.Rows.Add(3, 3, 2, "bad", false);

            DisplayProductsFromTable(table);
        }

        public void DisplayProductsFromTable(DataTable table)
        {
            var dataRow = (from products in table.AsEnumerable()
                           select products);
           
            Console.WriteLine("Product Names: ");
            foreach (DataRow row in dataRow)
            {
                Console.WriteLine("ProducID:{0}, UserID:{1}, Rating:{2}, Review:{3}, isLike:{4}", row["ProducID"], row["UserID"], row["Rating"], row["Review"], row["isLike"]);
            }
        }


    }
}
