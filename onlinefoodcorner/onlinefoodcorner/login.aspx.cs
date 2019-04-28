using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; //this namespace is for sqlclient server  
using System.Configuration;

namespace onlinefoodcorner
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection();
            //    try
            //    {
            //        string  _email  = txtemail.Text.Trim();
            //        string _pwd = txtpwd.Text.Trim();
            //        con.Open();
            //        string qry = "select * from [User] where UEmail='" + _email + "' and UPwd='" + _pwd + "'";
            //        SqlCommand cmd = new SqlCommand(qry, con);
            //        SqlDataReader sdr = cmd.ExecuteReader();
            //        if (sdr.Read())
            //        {
            //            lblmsg.Text = "Login Sucess......!!";
            //        }
            //        else
            //        {
            //            lblmsg.Text = "UserId & Password Is not correct Try again..!!";

            //        }
            //        con.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write(ex.Message);
            //    }

            AJ_DataClass myClass = new AJ_DataClass();
            DataSet ds = new DataSet();
            string _email = txtemail.Text.Trim();
            string _pwd = txtpwd.Text.Trim();
            string qry = "select * from [User] where UEmail='" + _email + "' and UPwd='" + _pwd + "'";
            ds = myClass.GetRecords("[User]", qry);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmsg.Text = "Invalid User";
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    {
                        Session["CurrentUser_ID"] = dr["Uid"];
                        Response.Redirect("Menu.aspx");
                    }
                }
            }
        }
    }
}