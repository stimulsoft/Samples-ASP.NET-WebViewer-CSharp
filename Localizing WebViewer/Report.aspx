<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<%@ Register Assembly="Stimulsoft.Report.Web" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Localizing Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" />
    </div>
    </form>
</body>
</html>
