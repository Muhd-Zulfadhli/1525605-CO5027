using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CO5027.App_Code.Models
{
    public class ProductTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                meTVEntities db = new meTVEntities();
                db.ProductTypes.Add(productType);
                db.SaveChanges();

                return productType.Name + " was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }

        }


        public string UpdateProductType(int id, ProductType productType)

        {
            try
            {
                meTVEntities db = new meTVEntities();

                //This fetches from database
                Product p = db.Products.Find(id);

                p.Name = productType.Name;
                


                db.SaveChanges();
                return productType.Name + " was successfully updated";


            }
            catch (Exception e)
            {
                return "Error:" + e;

            }
        }


        public string DeleteProductType(int id)

        {
            try
            {
                meTVEntities db = new meTVEntities();
                ProductType productType = db.ProductTypes.Find(id);

                db.ProductTypes.Attach(productType);
                db.ProductTypes.Remove(productType);
                db.SaveChanges();

                return productType.Name + " was successfully deleted";

            }
            catch (Exception e)
            {
                return "Error:" + e;

            }

        }








    }
}