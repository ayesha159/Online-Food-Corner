<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemsDetails.aspx.cs" Inherits="onlinefoodcorner.ItemsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <html xmlns="http://www.w3.org/1999/xhtml">  
     <head id="Head1" >  
        <title>Untitled Page</title>  
        <style type="text/css">  
            .Gridview {  
                font-family: Verdana;  
                font-size: 10pt;  
                font-weight: normal;  
                color: black;  
            }  
        </style>  
        <script type="text/javascript">  
        </script>  
    </head>  
    <body>
       <section class="section contact" runat ="server">
    <!-- container start -->
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <!-- address start -->
                <div class="address-block">
                    <!-- Location -->
                    <div class="media">
                        <i class="fa fa-map-o"></i>
                        <div class="media-body">
                            <h1>Items Purchase </h1>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
            <div class="contact-form">
                       <form id="form1" runat="server">  
            <div>  
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" DataKeyNames="id">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="S.No." />  
                        <asp:BoundField DataField="name" HeaderText="Name" />  
                        <asp:BoundField DataField="price" HeaderText="address" />  
                        <asp:BoundField DataField="quantity" HeaderText="Country" />  
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
                </asp:GridView>  
            </div>  
            <div>  
                <asp:Label ID="lblresult" runat="server"></asp:Label>  
            </div>  
        </form> 
            </div>
 
       </div>
            </div>
        </div>
    <!-- container end -->
</section>
        </body>
</asp:Content>
