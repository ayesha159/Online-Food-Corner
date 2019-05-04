using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace onlinefoodcorner
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUser_ID"] == null ) Response.Redirect("login.aspx");
            AJ_DataClass ajdbClass = new AJ_DataClass();
            DataSet ds = new DataSet();
            string qry = "SELECT        Catagory.CatID, Catagory.CatName, Items.ItId, Items.ItName, Items.ItPrice, Items.itDesc " +
              " FROM Catagory INNER JOIN " +
                "Items ON Catagory.CatID = Items.ICategoryID";

            ds = ajdbClass.GetRecords("tbl", qry);

            string _litVal = "";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                _litVal = _litVal + "<tr>" +
                        "<td style = 'text-align: center;' >" + dr["itid"].ToString().Trim() + "</td> " +

                        " <td style = 'text-align: center;' >" + dr["catName"].ToString().Trim() + "</td> " +

                         " <td style = 'text-align: center;' >" + dr["itName"].ToString().Trim() + "</td> " +
                         " <td style = 'text-align: center;' >" + dr["itdesc"].ToString().Trim() + "</td> " +

                          " <td style = 'text-align: center;' >" + dr["itprice"].ToString().Trim() + "</td> " +
                          " <td style = 'text-align: center;' >" + "<img  style='width:150px;height:100px;'  src = 'upload/" + dr["itid"].ToString().Trim() + ".jpg' />" + "</td> " +

                          " <td style = 'text-align: center;' ><a href = 'FoodMenuItemAdd.aspx?catname=" + dr["catname"].ToString().Trim() + "&id=" + dr["itid"].ToString().Trim() + "&qty=1&retf=1'> Add </a></td> " +


                            " </tr>";
            }
            string _heaed = "<table style='border:thin black; width:100% ; height:75px;background-color:white' cellpadding = '2' cellspacing = '2' >" +

                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>ID</td>" +
                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>Category</td>" +
                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>Items</td>" +
                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>Desc</td>" +
                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>Price</td>" +
                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>Food</td>" +

                 "<td style = 'color: #C0C0C0; background-color: #FF5050' class='text-center'>&nbsp;Add +1&nbsp;</td>" +
             "</tr>";



            litDnr.Text = _heaed + _litVal + "</table> ";
            if (Session["sestitmes"] != null) lbltitmes.Text = Session["sestitmes"].ToString();
            if (Session["sesgtotal"] != null) lblgtotal.Text = Session["sesgtotal"].ToString();
        }

        protected void btnMyorders_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }
    }
}