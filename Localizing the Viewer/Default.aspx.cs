using System;

namespace Localizing_the_Viewer
{
    public partial class Default : System.Web.UI.Page
    {
        public Default()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void ButtonShowReport_Click(object sender, EventArgs e)
        {
            Session["lang"] = DropDownListLang.SelectedValue;
            Response.Redirect("Report.aspx");
        }
    }
}