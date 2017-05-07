using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Codes for register button
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["meTVConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //This creates a new user stored inside DB
            IdentityUser user = new IdentityUser();
            user.UserName = txtUserName.Text;

            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //This will create user object
                    //DB created and expand
                    IdentityResult result = manager.Create(user, txtPassword.Text);

                    if (result.Succeeded)
                    {
                        //This stores user in DB
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //This is to log in new user by cookie
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //This is to log in new user to redirect at homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Products.aspx");
                    }
                    else
                    {
                        LitStatus.Text = result.Errors.FirstOrDefault();
                    }


                }
                catch (Exception ex)
                {
                    LitStatus.Text = ex.ToString();
                }
            }


            else
            {
                LitStatus.Text = "Passwords Incorrect!";
            }


        }
    }
}