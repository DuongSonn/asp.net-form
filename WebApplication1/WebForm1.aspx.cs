using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Name: " + TextBox1.Text;
            Label2.Text = "Gender: " + RadioButtonList1.Text;
            Label3.Text = "City: " + DropDownList1.SelectedItem.Text;
            Label4.Text = "Email: " + TextBox2.Text;
        }
    }
}