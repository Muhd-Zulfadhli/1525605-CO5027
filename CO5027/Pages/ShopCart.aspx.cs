using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using CO5027.App_Code.Models;
using CO5027.App_Code;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027.Pages
{
    public partial class ShopCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is to get the Id of logged in users and display products in cart
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);



        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            //This is to generate an HTML for each element in purchaseList
            List<Cart> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            //This is to add the total to page
            double vat = subTotal * 0.10;
            double totalAmount = subTotal + vat + 5;

            //This is to display values on page
            litTotal.Text = "$" + subTotal;
            litVat.Text = "$" + vat;
            litTotalAmount.Text = "$ " + totalAmount;
        }

        private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
        {
            subTotal = new double();
            ProductModel model = new ProductModel();

            foreach(Cart cart in purchaseList)
            {
                Product product = model.GetProduct(cart.ProductID);

                //This is to create an image button
                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Images/Products/{0}", product.Image),
                    CssClass = "productImage",
                PostBackUrl = string.Format("~/Products.aspx?id={0}", product.Id)
                };

                //This is to create a delete link
                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShopCart.aspx?productId={0}", cart.ID),
                    Text = "Delete Product",
                    ID = "del" + cart.ID
                };

                //This is to add an OnClick Event
                lnkDelete.Click += Delete_Product;

                //This is to create a quantity dropdownlist
                //List numbers from 1 to 20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.ID.ToString()
                };

                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Amount.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                //This is to create an HTML table with 2 rows
                Table table = new Table { CssClass = "cartTable" };
                TableRow a = new TableRow();
                TableRow b = new TableRow();

                //This is to create 6 cells in row a
                TableCell a1 = new TableCell { RowSpan = 2, Width = 55 };
                TableCell a2 = new TableCell { Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock",
                    product.Name, "Product No: " + product.Id ),
                HorizontalAlign = HorizontalAlign.Left, Width=355};
                TableCell a3 = new TableCell { Text = "Unit Price<hr/>"};
                TableCell a4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell a5 = new TableCell { Text = "Product Total<hr/>" };
                TableCell a6 = new TableCell { };

                //This is to create 6 cells in row b
                TableCell b1 = new TableCell { };
                TableCell b2 = new TableCell { Text = "$ " + product.Price};
                TableCell b3 = new TableCell { };
                TableCell b4 = new TableCell { Text = "$ " + Math.Round((cart.Amount * (double)product.Price), 2)};
                TableCell b5 = new TableCell { };
                TableCell b6 = new TableCell { };

                //This is to set special controls
                a1.Controls.Add(btnImage);
                a6.Controls.Add(lnkDelete);
                b3.Controls.Add(ddlAmount);

                //This is to add cells in rows
                a.Cells.Add(a1);
                a.Cells.Add(a2);
                a.Cells.Add(a3);
                a.Cells.Add(a4);
                a.Cells.Add(a5);
                a.Cells.Add(a6);

                b.Cells.Add(b1);
                b.Cells.Add(b2);
                b.Cells.Add(b3);
                b.Cells.Add(b4);
                b.Cells.Add(b5);
                b.Cells.Add(b6);

                //This is to add rows in table
                table.Rows.Add(a);
                table.Rows.Add(b);

                //This is to add table in pnlShoppingCart
                pnlShoppingCart.Controls.Add(table);

                //This is to add total amount of products in cart to subtotal
                subTotal += (cart.Amount * (double)product.Price);
            }

            //This is to add current user's shopping cart
            Session[User.Identity.GetUserId()] = purchaseList;
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codes for DropDownList
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int cartId = Convert.ToInt32(selectedList.ID);

            CartModel model = new CartModel();
            model.UpdateQuantity(cartId, quantity);

            Response.Redirect("~/Pages/ShopCart.aspx");
        }

        private void Delete_Product(object sender, EventArgs e)
        {
            //Codes for delete button
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteCart(cartId);

            Response.Redirect("~/Pages/ShopCart.aspx");
        }



    }
}