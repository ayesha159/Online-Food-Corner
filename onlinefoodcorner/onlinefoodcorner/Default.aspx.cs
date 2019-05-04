using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinefoodcorner
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string _menu = "";
            _menu ="<li><a class='active' href='index.html'>HOME</a></li>" +
                                        "<li><a href = 'about.aspx' > ABOUT </a></li>" +

                                        "<li><a href='Items.aspx'>OUR MENU</a></li>" +

                                        "<li><a href = 'contact.aspx' > CONTACT </a ></li>" +

                                           "<li><a href= 'login.aspx' > Login </a>  </li>" +

                                           "<li><a href= 'register.aspx' > Register </a> </li>";

            litmymenu.Text = _menu;
        }
    }
}