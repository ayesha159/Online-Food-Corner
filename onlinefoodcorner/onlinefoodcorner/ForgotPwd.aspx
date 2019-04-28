<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPwd.aspx.cs" Inherits="onlinefoodcorner.ForgotPwd" %>
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
                            <h3>Forgot Password Page</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
       
                    <form action="#" class="row" runat ="server">
                        
                        
                        <div class="col-md-6">
                            <label for="contact-name">Email
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtemail" runat="server"  class="form-control main"  required/>
                        </div>
                        
                  

                        <div class="col-md-12">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <div class="col-md-12">
                            <asp:Button ID="btnSend" runat="server" class="btn btn-style-one"  Text="Send" OnClick="btnSend_Click" />
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
