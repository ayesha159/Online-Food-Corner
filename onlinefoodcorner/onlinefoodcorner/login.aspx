<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="onlinefoodcorner.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<section class="section contact">
    <!-- container start -->
   <div class="login">
	<div class="container">
		<div class="login-grids">
			<div class="col-md-6 log">
					 <h3>LOGIN</h3>
					 <div class="strip"></div>
					 <p>Welcome, please enter the following to continue.</p>
					 
				   <div class="contact-form">
                    <!-- contact form start -->
       
                    <form action="#" class="row"  runat="server">
                        <!-- name -->
                             <div class="col-md-6">
                            <label>
                          User Type 
                            </label>
                          <asp:DropDownList ID="cboUtype" runat="server"  class="btn btn-secondary btn-lg dropdown-toggle">
                              <asp:ListItem Selected="True">Admin </asp:ListItem>
                                <asp:ListItem>User</asp:ListItem>
                              <asp:ListItem>Chef</asp:ListItem>
                              <asp:ListItem>DeliveryBoy</asp:ListItem>
                              </asp:DropDownList>
                        </div>    
                        <div class="col-md-6">
                            <label for="contact-name">
                                <h4>Email:</h4> <span>*</span>
                            </label>
                           <asp:TextBox ID="txtemail" runat="server"  class="form-control main"  required/>
                      
                            <label for="contact-name">
                                <h4>  Password</h4>
                                        <span>*</span>
                            </label>
                            <asp:TextBox ID="txtpwd" runat="server"  class="form-control main"  required TextMode="Password"/>
                        </div>

                        <div class="col-md-6">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                        <asp:Button ID="btnLogin" runat="server" class="btn btn-style-one"  Text="Log In" OnClick="btnLogin_Click" />
                        </div>

                        <div class="col-md-12 text-right">
                       
                        </div>
                        
                    </form>
                    <!-- contact form end -->
                </div>
					<a href="ForgotPwd.aspx">Forgot Password ?</a>
			</div>
			<div class="col-md-6 login-right">
					<h3>NEW REGISTRATION</h3>
					<div class="strip"></div>
					<p>By creating an account with our store, you will be able to move through the checkout process faster, store multiple shipping addresses, view and track your orders in your account and more.</p>
					<a href="register.aspx" class="hvr-shutter-in-horizontal button">CREATE AN ACCOUNT</a>
			</div>
			<div class="clearfix"></div>
		</div>
	</div>
</div>
    <!-- container end -->
</section>
</asp:Content>
