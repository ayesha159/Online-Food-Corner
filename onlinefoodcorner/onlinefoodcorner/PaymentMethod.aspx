<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentMethod.aspx.cs" Inherits="onlinefoodcorner.PaymentMethod" %>
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
                            <h3>Payment </h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
	<div class="paymentCont">
											<form runat ="server">
												<div class="clearfix"></div>

												<h4 class="paymenthead"><span class="payment"></span>Payment Details</h4>
												<div class="clearfix"></div>

                                                <div class="col-md-12">
                                                <asp:DropDownList ID="ddlCardType" runat="server">
 <asp:ListItem>Visa</asp:ListItem>
 <asp:ListItem>Mastercard</asp:ListItem>
 <asp:ListItem>American Express</asp:ListItem>
 </asp:DropDownList>

											</div>
										    <div class="col-md-6">
                            <label for="contact-name">Card Number
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtcNo" runat="server"  class="form-control main"  required/>
                        </div>
                        
                        <div class="col-md-6">
                            <label for="contact-name">Name On Card
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtname" runat="server"  class="form-control main"  required/>
                        </div>

                             
                        <div class="col-md-6">
                            <label for="contact-name">Expiration Date
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtCellNo" runat="server"  class="form-control main"   required/>
                        </div>
                        
                             
                        <div class="col-md-6">
                            <label for="contact-name">Address
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtAddress" runat="server"  class="form-control main" ErrorMessage="Street address is required!"
ControlToValidate="tbStreetAddress" required/>
                        </div>
                        
									       
                        <div class="col-md-6">
                            <label for="contact-name">zip/postal code
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="TextBox1" runat="server"  class="form-control main"  ErrorMessage="ZIP/Postal Code is required!"
                             ControlToValidate="tbPostCode"  required/>
                        </div>
                          <div class="col-md-6">
									<button type="submit" class="btn btn-success"  CausesValidation="True">Process order</button>
								</div>
                              </form>
							</div>
 </div>
        </div>
    </div>
    <!-- container end -->
</section>


</asp:Content>
