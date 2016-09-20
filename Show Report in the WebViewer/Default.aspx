<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Show report in WebViewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
