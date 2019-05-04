<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SentToAdmin.aspx.cs" Inherits="onlinefoodcorner.SentToAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                             <h3>DELIVERY BOY</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form" runat="server">
                    <!-- contact form start -->
         <form action="#" class="row" runat="server">
                       <div id="bodyCenter">

<div id="Round">

<a name="#city"></a>



		<div style="padding:10px;">

                 
            I recieve order !!!
            <asp:CheckBox ID="ChkRec" runat="server" />
    <br><br><br>    
             I deliver order !!!
            <asp:CheckBox ID="ChkDelivr" runat="server" />
    <br><br><br>    
             I recieve payment !!!
            <asp:CheckBox ID="ChkRecPay" runat="server" />
    <br><br><br>    
            <asp:Button ID="Button1" runat="server" Text="Sent to Admin" OnClick="Button1_Click" Height="54px" />

         <br><br><br>      

        
         <asp:Label ID="lblmsg" runat="server" />
        </div>
    </div>
                           </div>
             </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    
    <!-- container end -->
</section>
</asp:Content>
