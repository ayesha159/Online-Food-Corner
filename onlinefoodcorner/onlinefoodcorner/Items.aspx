<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="onlinefoodcorner.Items" %>
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
                            <h1>Items </h1>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
            <div class="contact-form">
                       <form id = "form1" runat="server">

    
            <asp:hiddenfield ID = "Hiddenfield1" runat="server"></asp:hiddenfield>
    
        <br />
        <div class="col-md-6">
                            <label for="contact-name">Item Name 
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtname" runat="server"  class="form-control main"  required/>
                        </div>

                             
                        <div class="col-md-6">
                            <label for="contact-name">Price
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtPrice" runat="server"  class="form-control main"   required/>
                        </div>
        <div class="col-md-6">
                            <label for="contact-name">Quantity
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtQty" runat="server"  class="form-control main"  required/>
                        </div>
          <div class="col-md-6">
                     
                                       <asp:FileUpload ID = "fuImageFile" runat="server" Height="28px" Width="286px" style="margin-top: 25px" />
              </div>
     
                                   <asp:Button ID = "btnAdd" runat="server" class="btn-success" Height="50px" 
                                           onclick="BtnUpdate_Click" Text="ADD ITEMS" Width="199px" style="margin-left: 140px; margin-top: 18px" />
    
           

                           <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
           

    </form>
            </div>
 
       </div>
            </div>
        </div>
    <!-- container end -->
</section>
</asp:Content>
