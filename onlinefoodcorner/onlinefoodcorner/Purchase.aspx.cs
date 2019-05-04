using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace onlinefoodcorner
{
    public partial class Purchase : System.Web.UI.Page
    {
        string _id = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            AJ_DataClass ajdbClass = new AJ_DataClass();
            DataSet ds = new DataSet();


        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Session["CurrentUser_ID"] != null)
            {
                _id = Session["CurrentUser_ID"].ToString();
                AJ_DataClass ajdbClass = new AJ_DataClass();

                string _name = txtname.Text;
                string _price = txtPrice.Text;
                string _quantity = txtQty.Text;

                string _DataFields = "PrAdminId,PrName,PrPrice ,PrQty";
                string _Values = "'" + _id + "','" + _name + "','" + _price + "','" + _quantity + "'";



                string Result = ajdbClass.InsertIntoDatabase("Purchase", _DataFields, _Values);
                lblmsg.Text = Result;
                if (Result == "Record(s) Added Successfully")
                {
                    txtname.Text = "";
                    txtPrice.Text = "";
                    txtQty.Text = "";

                }
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
    }