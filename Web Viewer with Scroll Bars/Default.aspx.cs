﻿using Stimulsoft.Report;
using System;
using System.Data;

namespace Web_Viewer_with_Scroll_Bars
{
    public partial class Default : System.Web.UI.Page
    {
        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebViewer1_GetReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
        {
            string reportPath = Server.MapPath("Reports/SimpleList.mrt");
            e.Report = new StiReport();
            e.Report.Load(reportPath);

            string dataPath = Server.MapPath("Data/Demo.xml");
            DataSet data = new DataSet();
            data.ReadXml(dataPath);
            e.Report.RegData(data);
        }
    }
}