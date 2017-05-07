using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CO5027.App_Code.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is for user name visible
            var user = Context.User.Identity;

            if (user.IsAuthenticated)
            {
                

                lnkLogin.Visible = false;
                lnkRegister.Visible = false;

                btnLogout.Visible = true;
                litStatus.Visible = true;

                CartModel model = new CartModel();
                string userId = HttpContext.Current.User.Identity.GetUserId();
                litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                    model.GetAmountOfOrders(userId));

            }
            else
            {
                lnkLogin.Visible = true;
                lnkRegister.Visible = true;

                btnLogout.Visible = false;
                litStatus.Visible = false;
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            //Codes for log out button
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();

            Response.Redirect("~/Products.aspx");
        }
    }
}