using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data;

namespace onlinefoodcorner
{
    public partial class ForgotPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                AJ_DataClass myClass = new AJ_DataClass();
                DataSet ds = new DataSet();
                string _email = txtemail.Text.Trim();
                // string _pwd = txtpwd.Text.Trim();
                string qry = "select * from [User] where UEmail='" + _email + "'";
                ds = myClass.GetRecords("[User]", qry);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress(txtemail.Text);
                    // Recipient e-mail address.
                    Msg.To.Add(txtemail.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Dear " + ds.Tables[0].Rows[0]["UName"].ToString().Trim() + ", <br/>Please check your Login Details<br/><br/>User Name: " + ds.Tables[0].Rows[0]["UEmail"].ToString().Trim() + "<br/><br/>Password: " + ds.Tables[0].Rows[0]["UPwd"] + "<br/><br/>";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";


                    //smtp.Port = 465;  Remove this line....


                    smtp.Credentials = new System.Net.NetworkCredential("ayeshajabbar36@gmail.com", "mymomismylife123");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);


                    //Msg = null;
                    lblmsg.Text = "Your Password Details Sent to your mail";
                    // Clear the textbox valuess
                    txtemail.Text = "";
                }
                else
                {
                    lblmsg.Text = "The Email you entered does not exists.";
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message.ToString() + "<br>" + ex.StackTrace.ToString();
                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}