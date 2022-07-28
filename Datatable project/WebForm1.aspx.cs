using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Datatable_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var nam = UserName.Text;
            nam = nam.Trim();
            nam = nam.ToLower();
            var pass = Password.Text;
            pass = pass.ToLower();

            if (nam == "admin" && pass == "ad0987")
            {
                Session["UserName"] = nam;
                Session["Password"] = pass;
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                Label1.Text = "invalid credentials";
            }
        }
    }
}