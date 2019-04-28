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
             //   ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
              ////  cboCities.DataSource = ds.Tables[0];
              //  cboCities.DataValueField = "ct_id";
              //  cboCities.DataTextField = "ctName";
              //  cboCities.DataBind();
            }

            }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();

            string _name = txtname.Text;
            string _price = txtPrice.Text;
            string _quantity = txtQty.Text;
          
            //  SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP34;Initial Catalog=yatendra;User ID=sa;Password=Password$2");
            if (fuImageFile.HasFile)
            {
                string picture = fuImageFile.FileName.ToString();
                fuImageFile.PostedFile.SaveAs(Server.MapPath("~/upload/") + picture);
                string _DataFields = "ICategoryID ,ItName  ,ItPrice ,ItPicture,ItQuantity";
                string _Values = "'" + _name + "','"
                        + _price + "','" + picture+ "','"

                        + _quantity + "'";



                string Result = ajdbClass.InsertIntoDatabase("[User]", _DataFields, _Values);
                Label1.Visible = true;
                Label1.Text = "Image Uploaded successfully";
                txtname.Text = "";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Plz upload the image!!!!";
            }
        }

        //Replace string function.
        public static String Replace(String oText, String oFind, String oReplace)
        {
            int iPos = oText.IndexOf(oFind);
            String strReturn = "";
            while (iPos != -1)
            {
                strReturn += oText.Substring(0, iPos) + oReplace;
                oText = oText.Substring(iPos + oFind.Length);
                iPos = oText.IndexOf(oFind);
            }
            if (oText.Length > 0)
                strReturn += oText;
            return strReturn;
        }

    }
}

//<form id = "form1" runat="server">
//    <div>
//<asp:hiddenfield ID = "Hiddenfield1" runat="server"></asp:hiddenfield>
    
//        <br />
//                                       <asp:FileUpload ID = "fuImageFile" runat="server" Height="24px" Width="250px" />
//                                   <asp:Button ID = "btnUpdate" runat="server" Height="22px" 
//                                           onclick="btnUpdate_Click" Text="Update" Width="60px" />
    
//        &nbsp;&nbsp; png image</div>
//    </form>

   







//public partial class Admin_Admin_Employee_image_upload : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {
//        this.Title = "Automated Institute Management System (AIMS) - Powered By Enterprise Development Network Solutions";
//        if (!IsPostBack)
//        {
//            if (Request.QueryString["i"] == null) Response.Redirect("close.aspx");
//            Hiddenfield1.Value = Request.QueryString["i"].ToString();
//        }
//    }
//    protected void btnUpdate_Click(object sender, EventArgs e)
//    {
//        if (fuImageFile.FileName.Length != 0)
//        {
//            //string fn = Replace(Hiddenfield1.Value, @"/", "##");
//            string fn = Hiddenfield1.Value;//.Replace(@"/", "-");

//            fuImageFile.SaveAs(Server.MapPath("../Images/Staff/emp_" + fn + ".png"));
//        }
//    }

//    //Replace string function.
//    public static String Replace(String oText, String oFind, String oReplace)
//    {
//        int iPos = oText.IndexOf(oFind);
//        String strReturn = "";
//        while (iPos != -1)
//        {
//            strReturn += oText.Substring(0, iPos) + oReplace;
//            oText = oText.Substring(iPos + oFind.Length);
//            iPos = oText.IndexOf(oFind);
//        }
//        if (oText.Length > 0)
//            strReturn += oText;
//        return strReturn;
//    }



//}