<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="onlinefoodcorner.Purchase" %>
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
                            <h1>Items Purchase </h1>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
            <div class="contact-form">
                       <form id = "form1" runat="server">

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
                                   <asp:Button ID = "btnAdd" runat="server" class="btn-success" Height="45px" 
                                           onclick="BtnAdd_Click" Text="ADD Purchase Items" Width="219px" style="margin-left: 37px; margin-top: 11px;" />
    </div>
           

    </form>
            </div>
 
       </div>
            </div>
        </div>
    <!-- container end -->
</section>
</asp:Content>
