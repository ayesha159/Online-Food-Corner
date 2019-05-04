using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinefoodcorner
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _id = null;
            if (Session["CurrentUser_ID"] != null)
            {
                _id = Session["CurrentUser_ID"].ToString();
                AJ_DataClass myDataClass = new AJ_DataClass();
                string CurrentUser = "";
                string UserRole = "";
                myDataClass.GetUserInfo(_id, ref CurrentUser, ref UserRole);
                lblUser.Text = CurrentUser;
                lblUserRole.Text = UserRole;
                lblUserRole.Visible = true;
                mnuLogin.Visible = false;
                mnuRegister.Visible = false;
                mnuLogOut.Visible = true;
                mnuOrder.Visible = true;
                mnuOdetails.Visible = true;
                mnuMenu.Visible = true;
                mnuLogin.Visible = false;
                mnuItems.Visible = true;
                mnuIdetails.Visible = true;
                mnuPurchase.Visible = true;
                mnuPdetails.Visible = true;
                mnuLogOut.Visible = true;
                mnuChckOrder.Visible = true;


                if (Convert.ToBoolean(UserRole.Contains("Admin")) == true)

                {

                    mnuLogin.Visible = false;
                    mnuItems.Visible = true;
                    mnuIdetails.Visible = true;
                    mnuPurchase.Visible = true;
                    mnuPdetails.Visible = true;
                    mnuLogOut.Visible = true;
                    mnuChckOrder.Visible = true;


                }
              

            }
        }
    }
}