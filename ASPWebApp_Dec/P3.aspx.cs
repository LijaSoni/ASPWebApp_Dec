﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApp_Dec
{
    public partial class P3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.Form["TextBox1"];
            Label2.Text = Request.Form["TextBox2"];
        }
    }
}