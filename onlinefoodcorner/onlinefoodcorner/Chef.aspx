﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chef.aspx.cs" Inherits="onlinefoodcorner.Chef" %>
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
                             <h3>My Menu Order</h3>
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

                 

        <h3>Order Sent to chef !!!</h3>
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
