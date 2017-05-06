using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CO5027.App_Code.Models
{
    public class CartModel
    {
        public string InsertCart(Cart cart)
        {
            try
            {
                meTVEntities db = new meTVEntities();
                db.Carts.Add(cart);
                db.SaveChanges();

                return "Order was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }





        public string InsertProductType(Cart cart)
        {
            try
            {
                meTVEntities db = new meTVEntities();
                db.Carts.Add(cart);
                db.SaveChanges();

                return cart.DatePurchased + " was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }

        }


        public string UpdateCart(int id, Cart cart)

        {
            try
            {
                meTVEntities db = new meTVEntities();

                //This fetches from database
                Cart p = db.Carts.Find(id);

                p.DatePurchased = cart.DatePurchased;
                p.ClientID = cart.ClientID;
                p.Amount = cart.Amount;
                p.IsInCart = cart.IsInCart;
                p.ProductID = cart.ProductID;

                db.SaveChanges();
                return cart.DatePurchased + " was successfully updated";


            }
            catch (Exception e)
            {
                return "Error:" + e;

            }
        }


        public string DeleteCart(int id)

        {
            try
            {
                meTVEntities db = new meTVEntities();
                Cart cart = db.Carts.Find(id);

                db.Carts.Attach(cart);
                db.Carts.Remove(cart);
                db.SaveChanges();

                return cart.DatePurchased + " was successfully deleted";

            }
            catch (Exception e)
            {
                return "Error:" + e;

            }

        }

        public List<Cart> GetOrdersInCart(string userId)
        {
            meTVEntities db = new meTVEntities();
            List<Cart> orders = (from x in db.Carts
                                 where x.ClientID == userId && x.IsInCart
                                 orderby x.DatePurchased
                                 select x).ToList();

            return orders;

        }
        
        public int GetAmountOfOrders(string userId)
        {
            try
            {
                meTVEntities db = new meTVEntities();
                int amount = (from x in db.Carts
                              where x.ClientID == userId && x.IsInCart
                              select x.Amount).Sum();

                return amount;
            }
            catch
            {
                return 0;
            }
    
        }


        public void UpdateQuantity(int id, int quantity)
        {
            meTVEntities db = new meTVEntities();
            Cart cart = db.Carts.Find(id);
            cart.Amount = quantity;

            db.SaveChanges();
        }

        public void MarkOrdersAsPaid(List<Cart> carts)
        {
            meTVEntities db = new meTVEntities();

            if(carts != null)
            {
                foreach(Cart cart in carts)
                {
                    Cart oldCart = db.Carts.Find(cart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;
                }

                db.SaveChanges();

            }
        }

    }
}