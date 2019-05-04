using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace onlinefoodcorner
{
    public partial class DeliveryBoyOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();
            DataSet ds = new DataSet();
      //      ,[OdDelivered]
      //,[OdDeliveredTime]
      //,[OdPaymentRecieved]

        string qry = " SELECT[User].UId, [User].UName, [User].UAddress, [User].UCellNo,[Order].OdId, [Order].OdGtotal, " +
                "[Order].OdFwdFoodCheff, [Order].OdDelivered ,[Order].OdPaymentRecieved FROM[User] INNER JOIN [Order] " +
                "ON[User].UId = [Order].OdUserId where OdFwdFoodCheff = 1 and OdDelivered =1";

            ds = ajdbClass.GetRecords("tbl", qry);


            string _litVal = "";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                               
                if (dr["OdId"].ToString().Trim() != "0")
                {
                    _litVal = _litVal + "<tr>" +

                   " <td style = 'text-align: center;' >" + dr["OdId"].ToString().Trim() + "</td> " +

                   " <td style = 'text-align: center;' >" + dr["UName"].ToString().Trim() + "</td> " +

                   " <td style = 'text-align: center;' >" + dr["UCellNo"].ToString().Trim() + "</td> " +
                   " <td style = 'text-align: center;' >" + dr["OdGtotal"].ToString().Trim() + "</td> " +

                   " <td style = 'text-align: center;' >" + dr["OdPaymentRecieved"].ToString().Trim() + "</td> " +
                   " <td style = 'text-align: center;' ><a href = 'SentToAdmin.aspx?id=" + dr["OdId"].ToString().Trim() + "'> SentToAdmin </a></td> " +

                                " </tr>";
                }

            }
            string _heaed = "<table style='border:black; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>ID. </td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>UserName</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>CellNo</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>Price</td>" +
                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>PaymentRecieve</td>" +

                 "<td style = 'color: #C0C0C0; background-color:#FF5050' class='text-center'>&nbsp;Sent &nbsp;</td>" +
             "</tr>";



            litDnr.Text = _heaed + _litVal + "</table> ";
        }
    }
}