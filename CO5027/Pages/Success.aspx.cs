﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using CO5027.App_Code;
using CO5027.App_Code.Models;

//Website created using tools and techniques taught in the module CO5027

namespace CO5027.Pages
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is for shopping cart is empty after user checkout
            List<Cart> carts = (List<Cart>)Session[User.Identity.GetUserId()];

            CartModel model = new CartModel();
            model.MarkOrdersAsPaid(carts);

            Session[User.Identity.GetUserId()] = null;
        }
    }
}