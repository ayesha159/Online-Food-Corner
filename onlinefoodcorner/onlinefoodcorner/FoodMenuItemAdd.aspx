<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodMenuItemAdd.aspx.cs" Inherits="onlinefoodcorner.FoodMenuItemAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv" runat="server" />
            <br />
            Total itmes <asp:Label ID="lbltitmes" runat="server" />
            <br />
            G.Total <asp:Label ID="lblgtotal" runat="server" />
        </div>
    </form>


</asp:Content>
