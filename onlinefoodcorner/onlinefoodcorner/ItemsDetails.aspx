<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemsDetails.aspx.cs" Inherits="onlinefoodcorner.ItemsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
     <section class="section contact">
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
                            <h3>ITEM DETAILS</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                
              
                <asp:GridView ID="GridView1" runat="server" style="font-family: Verdana;  
                font-size: 12pt; background-color: lightgray; text-align:center;
                font-weight: normal;
                color: black;"  EnableModelValidation="True"  DataKeyNames="ItId, ItName,ItPrice,ItQuantity"
                    AutoGenerateColumns="false"  OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="674px">  
                    <Columns >  
                        <asp:BoundField DataField="ItId" HeaderText="ID" ReadOnly="True" SortExpression="ID" AccessibleHeaderText="center" />
                        <asp:BoundField DataField="ItName" HeaderText="Name"  HeaderStyle-BorderStyle="Solid" />  
                        <asp:BoundField DataField="ItPrice" HeaderText="Price"  HeaderStyle-BorderStyle="Solid" />  
                        <asp:BoundField DataField="ItQuantity" HeaderText="Quantity"  HeaderStyle-BorderStyle="Solid"/>  
                        <asp:CommandField ShowEditButton="true" HeaderText="Edit"  HeaderStyle-BorderStyle="Solid"/>  
                        <asp:CommandField ShowDeleteButton="true"   HeaderText="Delete"  HeaderStyle-BorderStyle="Solid"/> </Columns>  
                </asp:GridView>  
            </div>  
            <div>  
                <asp:Label ID="lblresult" runat="server"></asp:Label>  
            </div>  
 
        </div>
    </div>
    <!-- container end -->
</section>
     </form>
</asp:Content>
