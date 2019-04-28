
 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="onlinefoodcorner.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<section class="section contact">
    <div class="registration-form">
	<div class="container">
		<h3>Registration</h3>
		<div class="strip"></div>
		<div class="registration-grids">
			<div class="reg-form">
				<div class="reg">
					 <p>Welcome, please enter the following details to continue.</p>
				       
                       <div class="contact-form">
                    <!-- contact form start -->
                    <form action="#" class="row" runat="server">
                        
                        <div class="col-md-6">
                            <label> <h4> Name</h4><span>*</span></label>
                           <asp:TextBox ID="txtName" runat="server"  class="form-control" required/>
                        </div>
                        
                                              
                        <div class="col-md-12">
                            <label>
                                <h4>Email</h4>
                                <span>*</span></label>
                           <asp:TextBox ID="txtEmail" runat="server"  class="form-control" required/>
                        </div>
                                         
                        
                
                        <div class="col-md-12">
                           <label>
                               <h4>Cell NO</h4></label>
                            <asp:TextBox ID="txtcontact" runat="server"  class="form-control main"  required/>
                        </div>

                        <div class="col-md-12">
                           <label>
                               <h4>Address</h4></label>
                            <asp:TextBox ID="txtaddr" runat="server"  class="form-control main"  required/>
                        </div>

                   
                        <div class="col-md-12">
                           <label>
                               <h4>Password</h4></label>
                            <asp:TextBox ID="txtPwd" runat="server"  class="form-control main"  required TextMode="Password"/>
                        </div>

                        <div class="col-md-12">
                           <label>
                               <h4>Re-Type Password</h4></label>
                            <asp:TextBox ID="txtPwd2" runat="server"  class="form-control main"  required  TextMode="Password"/>
                        </div>

                        <div class="col-md-12">
                          <asp:Label ID="lblmsg" runat="server"  />
                        </div>


                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                          <asp:Button ID="btnRegister" runat="server"  class="btn btn-style-one"  Text="Register" OnClick="btnRegister_Click" />
                        </div>
                    </form>
                    <!-- contact form end -->
                </div>
					
				 </div>
			</div>
			<div class="reg-right">
				 <h3>Completely Free Account</h3>
				 <div class="strip"></div>
				 <p>Create your Online Ordering System and Delivery Apps with real-time tracking.
                    Most powerful On-Demand Ordering Platform to increase your business sales from Online Ordering Software to Delivery System.
                    Perfect for Restaurants, Developers, Startups, Franchises or Enterprises. </p>	</div>
			<div class="clearfix"></div>
		</div>
	</div>
</div>
    </section>
</asp:Content>
