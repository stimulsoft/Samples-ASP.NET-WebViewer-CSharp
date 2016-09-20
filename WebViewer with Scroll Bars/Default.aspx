<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>WebViewer with Scroll Bars</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" 
            Width="800px" Height="500px" ScrollbarsMode="true"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
