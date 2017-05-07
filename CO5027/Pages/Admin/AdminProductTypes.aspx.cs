using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027.Pages.Admin
{
    public partial class AdminProductTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Codes for submit button
            App_Code.Models.ProductTypeModel model = new App_Code.Models.ProductTypeModel();
            App_Code.ProductType pt = createProductType();

            lblResult.Text = model.InsertProductType(pt);

        }

        private App_Code.ProductType createProductType()
        {
            //Codes for product type
            App_Code.ProductType p = new App_Code.ProductType();
            p.Name = txtName.Text;

            return p;

        }
    }
    
}