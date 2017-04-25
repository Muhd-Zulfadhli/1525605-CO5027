using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CO5027.App_Code.Models
{


    public class ProductModel {
        public string InsertProduct(Product product)
        {
            try
            {
                meTVEntities db = new meTVEntities();
                db.Products.Add(product);
                db.SaveChanges();

                return product.Name + " was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;

            }


        }


        public string UpdateProduct(int id, Product product)

        {
            try
            {
                meTVEntities db = new meTVEntities();

                //This fetches from database
                Product p = db.Products.Find(id);

                p.Name = product.Name;
                p.Price = product.Price;
                p.TypeID = product.TypeID;
                p.Description = product.Description;
                p.Image = product.Image;


                db.SaveChanges();
                return product.Name + " was successfully updated";


            }
            catch (Exception e)
            {
                return "Error:" + e;

            }
        }


        public string DeleteProduct(int id)

        {
            try
            {
                meTVEntities db = new meTVEntities();
                Product product = db.Products.Find(id);

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.Name + " was successfully deleted";

            }
            catch (Exception e)
            {
                return "Error:" + e;

            }

        }


        public Product GetProduct(int id)
        {

            try
            {
                using (meTVEntities db = new meTVEntities())
                {
                    Product product = db.Products.Find(id);
                    return product;
                }
            }

            catch (Exception)
            {
                return null;
            }
        }


        public List<Product> GetAllProducts()
        {
            try
            {
                using (meTVEntities db = new meTVEntities())
                {
                    List<Product> products = (from x in db.Products
                                              select x).ToList();

                    return products;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<Product> GetProductsByType(int typeId)
        {
            try
            {
                using (meTVEntities db = new meTVEntities())
                {
                    List<Product> products = (from x in db.Products
                                              where x.TypeID == typeId
                                              select x).ToList();

                    return products;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }



}
}