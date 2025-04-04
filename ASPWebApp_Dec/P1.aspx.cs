using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApp_Dec
{
    public partial class P1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //"+ +"
            //Response.Write("haiiii");
            //Response.Redirect("P2.aspx");
            Response.Redirect("P2.aspx?na="+TextBox1.Text+"&ag="+TextBox2.Text+"");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("P3.aspx");
        }
    }
}