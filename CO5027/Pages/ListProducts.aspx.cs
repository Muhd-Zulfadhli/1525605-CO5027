using CO5027.App_Code;
using CO5027.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace CO5027.Pages
{
    public partial class ListProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }



        public void FillPage()
        {
            //Get selected product data
            if (!string.IsNullOrWhiteSpace(Request.QueryString["Id"]))
            {
                int Id = Convert.ToInt32(Request.QueryString["Id"]);
                ProductModel model = new ProductModel();
                Product product = model.GetProduct(Id);

                //Fill page with data
                lblTitle.Text = product.Name;
                lblDescription.Text = product.Description;
                lblPrice.Text = "Price per unit:<br/>$ " + product.Price;
                imgProduct.ImageUrl = "~/Images/Products/" + product.Image;
                imgProduct.CssClass = "productImage3";
                lblItemNr.Text = product.Id.ToString();

                //Fill amount list with numbers 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();
            }

            else
            {

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientId = Context.User.Identity.GetUserId();

                if (clientId != null)
                {

                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                    Cart cart = new Cart
                    {
                        Amount = amount,
                        ClientID = clientId,
                        DatePurchased = DateTime.Now,
                        IsInCart = true,
                        ProductID = id
                    };

                    CartModel model = new CartModel();
                    lblResult.Text = model.InsertCart(cart);
                }
                else
                {
                    lblResult.Text = "Please, log in!";
                }
            }
        }


    }
}