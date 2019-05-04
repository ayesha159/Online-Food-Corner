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
          
             AJ_DataClass ajdbClass = new AJ_DataClass();

            if (Request.QueryString["id"].ToString() != null) { _UserID = Request.QueryString["id"].ToString(); }

            bool chef = true;
            string s = ajdbClass.UpdateDatabase("update [Order] set OdFwdFoodCheff='" + chef  + "' where OdId='" + _UserID + "'");


            lblmsg.Text = s + " Order has been sent to chef ";
       }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }
    }
}