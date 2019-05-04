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
            string qry = "select * from [User]";
            AJ_DataClass myDataClass = new AJ_DataClass();

            myDataClass.GetRecords("[User]", qry);
           

            if (Session["CurrentUser_ID"] != null)
            {
                _id = Session["CurrentUser_ID"].ToString();
              
                string CurrentUser = "";
                string UserRole = "";
                myDataClass.GetUserInfo(_id, ref CurrentUser, ref UserRole);
                lblUser.Text = CurrentUser;
                lblUserRole.Text = UserRole;
                lblUserRole.Visible = true;
                mnuLogin.Visible = false;
                mnuRegister.Visible = false;
                mnuLogOut.Visible = true;
              //  mnuOrder.Visible = true;
                // mnuOdetails.Visible = true;
                mnuMenu.Visible = true;
            }
                //string _id = null;
                //if (Session["CurrentUser_ID"] != null)
                //{
                //    _id = Session["CurrentUser_ID"].ToString();
                //    AJ_DataClass myDataClass = new AJ_DataClass();
                //    string CurrentUser = "";
                //    string UserRole = "";
                //    myDataClass.GetUserInfo(_id, ref CurrentUser, ref UserRole);
                //    lblUser.Text = CurrentUser;
                //    lblUserRole.Text = UserRole;
                //    mnuLogin.Visible = false;
                //    mnuRegister.Visible = false;

                //    mnuOrder.Visible = true;
                //    mnuLogOut.Visible = true;
                //    // mnuOdetails.Visible = true;
                //    mnuMenu.Visible = true;
                //    if (Convert.ToBoolean(UserRole.Contains("Chef")) == true)

                //    { mnuCfO.Visible = true; mnuLogOut.Visible = true; }
                //    else if (Convert.ToBoolean(UserRole.Contains("DeliveryBoy")) == true)
                //    { mnuDbo.Visible = true; mnuLogOut.Visible = true; }
                //    else
                //    {
                //        mnuLogin.Visible = false;
                //        mnuItems.Visible = true;
                //        mnuIdetails.Visible = true;
                //        mnuPurchase.Visible = true;
                //        mnuPdetails.Visible = true;
                //        mnuLogOut.Visible = true;
                //        mnuChckOrder.Visible = true;
                //    }

                //    //string _id = null;
                //    //if (Session["CurrentUser_ID"] != null)
                //    //{
                //    //    _id = Session["CurrentUser_ID"].ToString();
                //    //    AJ_DataClass myDataClass = new AJ_DataClass();
                //    //    string CurrentUser = "";
                //    //    string UserRole = "";
                //    //    myDataClass.GetUserInfo(_id, ref CurrentUser, ref UserRole);
                //    //    lblUser.Text = CurrentUser;
                //    //    lblUserRole.Text = UserRole;
                //    //    lblUserRole.Visible = true;
                //    //    mnuLogin.Visible = false;
                //    //    mnuRegister.Visible = false;
                //    //    mnuLogOut.Visible = true;
                //    //    mnuOrder.Visible = true;
                //    //    mnuOdetails.Visible = true;
                //    //    mnuMenu.Visible = true;

                //    //    if (Convert.ToBoolean(UserRole.Contains("Chef")) == true)

                //    //    {

                //    //        mnuLogin.Visible = false;
                //    //        mnuItems.Visible = true;
                //    //        mnuIdetails.Visible = true;
                //    //        mnuPurchase.Visible = true;
                //    //        mnuPdetails.Visible = true;
                //    //        mnuLogOut.Visible = true;
                //    //        mnuChckOrder.Visible = true;


                //    //    }


                //    //}
                //}
            }

    }
}
//SqlConnection con = new SqlConnection(strConnString);

//con.Open();

//            str = "Select * from Login";

//            com = new SqlCommand(str);

//sqlda = new SqlDataAdapter(com.CommandText, con);

//dt = new DataTable();

//sqlda.Fill(dt);

//            RowCount = dt.Rows.Count;

//            for (int i = 0; i<RowCount; i++)

//            {

//                UserName = dt.Rows[i]["UserName"].ToString();

//Password = dt.Rows[i]["Password"].ToString();

//                if (UserName == TextBox_user_name.Text && Password == TextBox_password.Text)

//                {

//                    Session["UserName"] = UserName;

//                    if (dt.Rows[i]["Role"].ToString() == "Admin")

//                        Response.Redirect("~/Admin/Admin.aspx");

//                    else if (dt.Rows[i]["Role"].ToString() == "FreeUser")

//                        Response.Redirect("~/FreeUser/FreeUser.aspx");

//                    else if (dt.Rows[i]["Role"].ToString() == "PaidUser")

//                        Response.Redirect("~/PaidUser/PaidUser.aspx");

//                }

//                else

//                {

//                    lb1.Text = "Invalid User Name or Password! Please try again!";

//                }

//            }

       

//        }

//    }

//}
