using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBuy_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < chklsPet1.Items.Count; i++)
        {
            if (chklsPet1.Items[i].Selected)
            {
                Session["cart"] += chklsPet1.Items[i].Text + ",";
            }
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewCart.aspx");
    }
}