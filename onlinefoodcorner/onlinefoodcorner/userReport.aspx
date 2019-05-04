<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userReport.aspx.cs" Inherits="onlinefoodcorner.userReport" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

   <form id="form1" runat="server" >

<table cellpadding="0" cellspacing="0" width="100%">

    <tr>

   <td>

       <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true"
     BestFitPage="False" ToolPanelView="None" />

   </td>

    </tr>

                </table>

</form>

</body>


</html>
