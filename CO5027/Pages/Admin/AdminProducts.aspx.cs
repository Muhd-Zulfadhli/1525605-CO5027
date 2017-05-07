using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CO5027.App_Code.Models;
using CO5027.App_Code;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027.Pages.Admin
{
    public partial class AdminProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetImages();
        }

        public void GetImages()
        {
            try
            {
                //For filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products"));

                //Filenames and add to arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"/", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();

            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }


        }


        public Product CreateProduct()
        {
            //Details of products connects to database
            Product product = new Product();
            product.Name = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.TypeID = Convert.ToInt32(ddlType.SelectedValue);
            product.Description = txtDescription.Text;
            product.Image = ddlImage.SelectedValue;

            return product;


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Codes for submit button
            ProductModel productModel = new ProductModel();
            Product product = CreateProduct();

            lblResult.Text = productModel.InsertProduct(product);

        }
    }
}