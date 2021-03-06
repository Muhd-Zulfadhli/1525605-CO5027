﻿using CO5027.App_Code;
using CO5027.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027
{
    public partial class Products : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        public void FillPage()
        {
            //This is to gets list of all products
            ProductModel productModel = new ProductModel();
            List<Product> products = productModel.GetAllProducts();

            if (products != null)
            {
                foreach (Product product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();
                  
                    //Info from database about products are places onto this page
                    //This includes product image, name and price
                    //All images from Google Images
                    imageButton.ImageUrl = "~/Images/Products/" + product.Image;

                    //Selected product image is clickable to an individual page
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/ListProducts.aspx?id=" + product.Id;

                    lblName.Text = product.Name;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "$" + product.Price;
                    lblPrice.CssClass = "productPrice";


                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);


                    pnlProducts.Controls.Add(productPanel);

                }


            }

            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });

            }











        }




    }
}