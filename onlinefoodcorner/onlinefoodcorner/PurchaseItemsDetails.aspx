<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PurchaseItemsDetails.aspx.cs" Inherits="onlinefoodcorner.PurchaseItemsDetails" %>
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
                            <h3>PURCHASE DETAILS</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                
              
                <asp:GridView ID="GridView1" runat="server" style="font-family: Verdana;  
                font-size: 12pt; background-color: gainsboro; text-align:center;
                font-weight: normal;  
                color: black;"  EnableModelValidation="True"  DataKeyNames="PrId, PrName,PrPrice,PrQty"
                    AutoGenerateColumns="false"  OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="674px">  
                    <Columns>  
                        <asp:BoundField DataField="PrId" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            
                        <asp:BoundField DataField="PrName" HeaderText="Name" />  
                        <asp:BoundField DataField="PrPrice" HeaderText="Price" />  
                        <asp:BoundField DataField="PrQty" HeaderText="Quantity" />  
                        <asp:CommandField ShowEditButton="true" HeaderText="Edit" />  
                        <asp:CommandField ShowDeleteButton="true"   HeaderText="Delete"/> </Columns>  
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
