using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace onlinefoodcorner
{
    public partial class Order : System.Web.UI.Page
    {
        string _UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUser_ID"] != null)
            {
                _UserID = Session["CurrentUser_ID"].ToString();
            }
            else
            { Response.Redirect("login.aspx"); }

            AJ_DataClass ajdbClass = new AJ_DataClass();
            DataSet ds = new DataSet();
           
            string qry = "SELECT        Catagory.CatID, Catagory.CatName, Items.ItId, Items.ItName, Items.ItPrice, Items.itDesc " +
              " FROM Catagory INNER JOIN " +  "Items ON Catagory.CatID = Items.ICategoryID";

            ds = ajdbClass.GetRecords("tbl", qry);
            DataTable dtMyTable_Adr;
            if (Session["sesOrderTable"] != null)
            {
                dtMyTable_Adr = (DataTable)Session["sesOrderTable"];
            }
            else return;

            string _litVal = "";
            foreach (DataRow dr in dtMyTable_Adr.Rows)
            {
                               
                if (dr["itqty"].ToString().Trim() != "0")
                {
                    _litVal = _litVal + "<tr>" +


                            " <td style = 'text-align: center;' >" + dr["catName"].ToString().Trim() + "</td> " +

                             " <td style = 'text-align: center;' >" + dr["itName"].ToString().Trim() + "</td> " +
                             " <td style = 'text-align: center;' >" + dr["itdesc"].ToString().Trim() + "</td> " +

                              " <td style = 'text-align: center;' >" + dr["itprice"].ToString().Trim() + "</td> " +
                              "<td style = 'text-align: center;' >" + dr["itqty"].ToString().Trim() + "</td> " +
                              "<td style = 'text-align: center;' >" + dr["ittotal"].ToString().Trim() + "</td> " +
                              " <td style = 'text-align: center;' >" + "<img  style='width:100px;height:70px;'  src = 'upload/" + dr["itid"].ToString().Trim() + ".jpg' />" + "</td> " +
                              " <td style = 'text-align: center;' >" +
                              "<a href = 'FoodMenuItemAdd.aspx?catname=" + dr["catname"].ToString().Trim() + "&id=" + dr["itid"].ToString().Trim() + "&qty=1&retf=2'> +1 </a>&nbsp;/&nbsp;" +
                              "<a href = 'FoodMenuItemAdd.aspx?catname=" + dr["catname"].ToString().Trim() + "&id=" + dr["itid"].ToString().Trim() + "&qty=-1&retf=2'> -1 </a>" +
                              "</td> " +
                             " </tr>";
                }

            }
            string _heaed = "<table style='border:black; width:100%; height:100%; background-color:white' cellpadding = '1' cellspacing = '1' >" +


                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Category</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Items</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Desc</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Price</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>QTy</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Total</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Food</td>" +

                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>&nbsp;Add +1&nbsp;</td>" +
             "</tr>";



            litDnr.Text = _heaed + _litVal + "</table> ";
            if (Session["sestitmes"] != null) lbltitmes.Text = Session["sestitmes"].ToString();
            if (Session["sesgtotal"] != null) lblgtotal.Text = Session["sesgtotal"].ToString();
        }

        protected void btnFoodMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();
            bool chef = false;
            bool delivr = false;
            string delivrtime = DateTime.Now.ToShortDateString() ;
            bool payRec = false;
            string _DataFields = "OdUserId,OdDate,OdGtotal ,OdFwdFoodCheff,OdDelivered ,OdDeliveredTime  ,OdPaymentRecieved";
            string _Values = "'" + _UserID + "','" + DateTime.Now.ToShortDateString() + "','" + lblgtotal.Text + "','" + 
                chef + "','" + delivr+ "','" + delivrtime + "','" + payRec  +       "'";
            string Result = ajdbClass.InsertIntoDatabase("[Order]", _DataFields, _Values);



            //"OddOdid" = "OdId";
            //string _itid = "Items.ItId";
            //string _price = "itprice";
            //string _quantity = "itqty";
            //string _total = "ittotal";

            //string _DataField1 = "[OddOdid] ,[Odditid] ,[OddPrice] ,[OddQuantity],[OddTotal]";
            //string _Values1 = "'" + _odid + "','" + _itid + "','" + _price + "','" +
            //    _quantity + "','" + _total  + "'";
            //string Result1 = ajdbClass.InsertIntoDatabase("[OrderDetails]", _DataField1, _Values1);

            lblmsg.Text = Result + " Your order has been sent ";

        }
    }
}