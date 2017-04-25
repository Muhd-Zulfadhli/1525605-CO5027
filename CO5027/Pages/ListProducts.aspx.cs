using CO5027.App_Code;
using CO5027.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}