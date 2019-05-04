using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinefoodcorner
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();

            string _name = txtName.Text;        
            string _email = txtEmail.Text;
            string _contact = txtcontact.Text;
            string _addr = txtaddr.Text;
            string _utype = cboUtype.SelectedItem.ToString();
            string _pwd = txtPwd.Text;

            // Check if user already have an account. *email
            int trec = ajdbClass.TRec("select * from [User] where UEmail='" + txtEmail.Text.Trim() + "'");
            if (trec != 0) { lblmsg.Text = " Email already exists !"; txtEmail.Focus(); return; }
            else { lblmsg.Text = ""; }

            if (txtPwd.Text.Trim() != txtPwd2.Text.Trim())
            { lblmsg.Text = "Password MissMatched !"; txtPwd2.Focus(); return; }
            else
            { lblmsg.Text = ""; }
            string _DataFields = "UName,UAddress,UCellNo,UEmail, Utype,UPwd";
            string _Values = "'" + _name + "','" 
                    + _addr + "','" +  _contact + "','"

                    +  _email + "','" + _utype   + "','" + _pwd  + "'";



            string Result = ajdbClass.InsertIntoDatabase("[User]", _DataFields, _Values);
            lblmsg.Text = Result;
            if (Result == "Record(s) Added Successfully")
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtcontact.Text = "";
                txtaddr.Text = "";
                txtPwd.Text = "";
                
            }
        }
    }
}