using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void ButtonShowReport_Click(object sender, EventArgs e)
    {
        Session["lang"] = DropDownListLang.SelectedValue;
        Response.Redirect("Report.aspx");
    }
}