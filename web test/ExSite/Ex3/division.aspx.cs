using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ex3_division : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            float divsor = float.Parse(txtDivsor.Text);
            float divident = float.Parse(txtDivident.Text);
            Response.Write("商为:" + divsor / divident);
        }
        catch (Exception ee)
        {
            Response.Write("请输入正确的数字！");
        }

    }
}
