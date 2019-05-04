<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="onlinefoodcorner.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu">
	<div class="container">
		<div class="menu-info">
			<h3>CHECK OUT OUR MENU HERE</h3>
			<div class="strip-line"></div>
		</div>
		 <section class="section contact">
    <!-- container start -->
   
       
                     <form action="#" class="row" runat="server">
                       <div id="bodyCenter">

<div id="Round">

<a name="#city"></a>



		<div style="padding:10px;">

	<h3>Food Menu</h3>

     
            Total itmes <asp:Label ID="lbltitmes" runat="server" />
            <br />
            G.Total <asp:Label ID="lblgtotal" runat="server" />
    <br>
         <asp:Button ID="btnMyorders" runat="server" Text="My Order" OnClick="btnMyorders_Click" Height="48px" Width="171px" class="btn-success" />
         <br />
             <div  class="active">
                  <asp:Literal ID="litDnr" runat="server" />
             </div>
           
        
    <br><br><br>        

        </div>


        </div>
                           </div>
                         </form>
                    <!-- contact form end -->
              
    <!-- container end -->
</section>
	</div>
</div>
</asp:Content>
