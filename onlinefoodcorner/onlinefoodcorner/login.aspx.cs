using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace onlinefoodcorner
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int RowCount;

            AJ_DataClass myClass = new AJ_DataClass();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string _email = txtemail.Text.Trim();
            string _pwd = txtpwd.Text.Trim();
            string _utype = cboUtype.SelectedItem.ToString();
            string qry = "select * from [User] where UEmail='" + _email + "' and UPwd='" + _pwd + "' and Utype='" + _utype + "'";
            ds = myClass.GetRecords("[User]", qry);
          //  lblmsg.Text = "user successfully login!";
            RowCount = dt.Rows.Count;

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