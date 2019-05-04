using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinefoodcorner
{
    public partial class SentToDeliveryBoy : System.Web.UI.Page
    {
        string _UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ChkMade.Checked == true)
            {
                AJ_DataClass ajdbClass = new AJ_DataClass();

                if (Request.QueryString["id"].ToString() != null) { _UserID = Request.QueryString["id"].ToString(); }

                bool chef = true;
                bool deliver = true;
             //   string s = ajdbClass.UpdateDatabase("update clo set name='" + _name + "',dateupdated='" + _dateupdated + "' where id='" + _id + "'");


                string s = ajdbClass.UpdateDatabase("update [Order] set OdFwdFoodCheff='" + chef  + "',OdDelivered='" + deliver  + "' where OdId='" + _UserID + "'");


                lblmsg.Text = s + " Order has been delivered !!! ";
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();

            if (Request.QueryString["id"].ToString() != null) { _UserID = Request.QueryString["id"].ToString(); }

            bool chef = true;
            bool deliver = true;
            //   string s = ajdbClass.UpdateDatabase("update clo set name='" + _name + "',dateupdated='" + _dateupdated + "' where id='" + _id + "'");


            string s = ajdbClass.UpdateDatabase("update [Order] set OdFwdFoodCheff='" + chef + "',OdDelivered='" + deliver + "' where OdId='" + _UserID + "'");


            lblmsg.Text = s + " Order has been delivered !!! ";
        }
    }
}