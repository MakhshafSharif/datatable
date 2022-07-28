using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Datatable_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EMPGRIDDATA1.DataSource = new Accountant().GetAccountantList();
            EMPGRIDDATA1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Session["Password"] = null;
            //Response.Redirect("WebForm3.aspx");
        }
        public class Accountant
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public List<Accountant> GetAccountantList()
            {
                List<Accountant> Acc = new List<Accountant>();

                Accountant objAccountant = new Accountant();

                objAccountant.Name = "Ahsan";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);


                objAccountant = new Accountant();
                objAccountant.Name = "Awais";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Burhan";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Ali";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Umair";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Zain";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Gohar";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Amina";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Bilal";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                objAccountant = new Accountant();
                objAccountant.Name = "Danish";
                objAccountant.Address = "DHA, Lahore";
                Acc.Add(objAccountant);

                return Acc;
            }
        }
    }
}