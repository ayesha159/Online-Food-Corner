<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="onlinefoodcorner.Order" %>
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
                            <h3>Order</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
       
                    <form id="form1" runat="server">
                             
                        <div class="col-md-6">
                            <label for="contact-name">Name
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtName" runat="server"  class="form-control main"  required/>
                        </div>
                        
                        <div class="col-md-6">
                            <label for="contact-name">Email
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtemail" runat="server"  class="form-control main"  required/>
                        </div>

                             
                        <div class="col-md-6">
                            <label for="contact-name">Cell No
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtCellNo" runat="server"  class="form-control main"  required/>
                        </div>
                        
                             
                        <div class="col-md-6">
                            <label for="contact-name">Address
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtAddress" runat="server"  class="form-control main"  required/>
                        </div>
                        
                             
                        <div class="col-md-6">
                            <label for="contact-name">Order 
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtOrder" runat="server"  class="form-control main"  required/>
                        </div>
                        
                             
                        <div class="col-md-6">
                            <label for="contact-name">Price
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtPrice" runat="server"  class="form-control main"  required/>
                        </div>
                        
                             
                        <div class="col-md-6">
                            <label for="contact-name">Qunatity
                                        <span>*</span>
                           
                            </label>
                           <asp:TextBox ID="txtQuantity" runat="server"  class="form-control main"  required/>
                        </div>
                        
                  
                             
                
                        

                        <div class="col-md-12">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <div class="col-md-12">
                            <asp:Button ID="btnSend" runat="server" class="btn btn-style-one"  Text="Send"  />
                        </div>
                        


                         </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    </div>
    <!-- container end -->
</section>
</asp:Content>
