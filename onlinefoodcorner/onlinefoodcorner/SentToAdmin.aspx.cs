using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinefoodcorner
{
    public partial class SentToAdmin : System.Web.UI.Page
    {
        string _UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ChkDelivr.Checked == true && ChkRec.Checked== true && ChkRecPay.Checked == true)
            {
                AJ_DataClass ajdbClass = new AJ_DataClass();

                if (Request.QueryString["id"].ToString() != null) { _UserID = Request.QueryString["id"].ToString(); }

                bool chef = true;
                bool deliver = true;
                bool pay = true;

                string s = ajdbClass.UpdateDatabase("update [Order] set OdFwdFoodCheff='" + chef + "',OdDelivered='" +
                 deliver + "',OdDeliveredTime='" + DateTime.Now + "',OdPaymentRecieved='" + pay + "' where OdId='" + _UserID + "'");


                lblmsg.Text = s + " I deliver order and recieve payment !!! ";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();

            if (Request.QueryString["id"].ToString() != null) { _UserID = Request.QueryString["id"].ToString(); }

            bool chef = true;
            bool deliver = true;
            bool pay = true;
           
           string s = ajdbClass.UpdateDatabase("update [Order] set OdFwdFoodCheff='" + chef + "',OdDelivered='" +
            deliver + "',OdDeliveredTime='" + DateTime.Now + "',OdPaymentRecieved='" + pay + "' where OdId='" + _UserID + "'");


            lblmsg.Text = s + "  I deliver order and recieve payment !!!";
        }
    }
}