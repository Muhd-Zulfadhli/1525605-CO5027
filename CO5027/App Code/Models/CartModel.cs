﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CO5027.App_Code.Models
{
    public class CartModel
    {
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




    }
}