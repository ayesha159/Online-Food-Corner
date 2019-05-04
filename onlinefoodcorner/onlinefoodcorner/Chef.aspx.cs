using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace onlinefoodcorner
{
    public partial class Chef : System.Web.UI.Page
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
          
            bool chef = true;
            bool delivr = false;
            string delivrtime = DateTime.Now.ToShortDateString();
            bool payRec = false;
            string _DataFields = "OdUserId,OdDate,OdGtotal ,OdFwdFoodCheff,OdDelivered ,OdDeliveredTime  ,OdPaymentRecieved";
            string _Values = "'" + _UserID + "','" + DateTime.Now.ToShortDateString() + "','" + lblgtotal.Text + "','" +
            chef + "','" + delivr + "','" + delivrtime + "','" + payRec + "'";
            string Result = ajdbClass.InsertIntoDatabase("[Order]", _DataFields, _Values);
            lblmsg.Text = Result + " Order has been sent to chef ";
            if (Session["sestitmes"] != null) lbltitmes.Text = Session["sestitmes"].ToString();
            if (Session["sesgtotal"] != null) lblgtotal.Text = Session["sesgtotal"].ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }
    }
}