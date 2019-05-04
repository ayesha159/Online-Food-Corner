using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace onlinefoodcorner
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.Title = "Online Food Corner";
            AJ_DataClass ajdbClass = new AJ_DataClass();

            DataSet ds = new DataSet();

            if (!IsPostBack)
            {
               ds = ajdbClass.GetRecords("Catagory", "select * from Catagory");
                cboCatgory.DataSource = ds.Tables[0];
                cboCatgory.DataValueField = "CatID";
                cboCatgory.DataTextField = "CatName";
               cboCatgory.DataBind();
            }

            }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();
            string _catgory = cboCatgory.SelectedValue;
            string _name = txtname.Text;
            string _price = txtPrice.Text;
            string _quantity = txtQty.Text;


            if (fuImageFile.HasFile)
            {
                string picture = fuImageFile.FileName.ToString();
                fuImageFile.PostedFile.SaveAs(Server.MapPath("upload/") + picture);

            

                string _DataFields = "ICategoryID ,ItName  ,ItPrice ,ItPicture,ItQuantity";
                string _Values = "'" + _catgory + "','" + _name + "','"
                        + _price + "','" + picture+ "','"
                        + _quantity + "'";

                string Result = ajdbClass.InsertIntoDatabase("Items", _DataFields, _Values);
                Label1.Visible = true;
                Label1.Text = "Items inserted successfully";
                txtname.Text = "";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Plz upload the image!!!!";
            }
        }
                

    }
}
