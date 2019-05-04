using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace onlinefoodcorner
{
    public partial class FoodMenuItemAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["sesOrderTable"] = null;

            //    Session["sesOrderTable"] = null;
            string _id = "0";
            string _qty = "0";
            string _cat = "Fast Food";
            string _retf = "";

            if (Request.QueryString["catname"].ToString() != null) { _id = Request.QueryString["catname"].ToString(); }
            if (Request.QueryString["id"].ToString() != null) { _id = Request.QueryString["id"].ToString(); }
            if (Request.QueryString["qty"].ToString() != null) { _qty = Request.QueryString["qty"].ToString(); }
            if (Request.QueryString["retf"].ToString() != null) { _retf = Request.QueryString["retf"].ToString(); }



            if (Session["sesOrderTable"] == null)
            {
                DataTable dtMyTable_Adr = new DataTable();
                dtMyTable_Adr = createTbl_for_LoginUser();
                Session["sesOrderTable"] = dtMyTable_Adr;
            }


            if (Session["sesOrderTable"] != null)
            {
                DataTable dtMyTable_Adr = (DataTable)Session["sesOrderTable"];


                if (checkifitemAlradyExists(_id) == false)
                {
                    dtMyTable_Adr = AddItemIntoTable(dtMyTable_Adr, _id, _qty, _cat, _retf);
                }
                else
                {
                    dtMyTable_Adr = UpdateItemIntoTable(dtMyTable_Adr, _id, _qty, _cat, _retf);
                }

                //dtMyTable_Adr.Add(dtMyTable_Adr);
                Session["sesOrderTable"] = dtMyTable_Adr;

                gv.DataSource = dtMyTable_Adr;
                gv.DataBind();
                calc(dtMyTable_Adr);
                if (Session["sestitmes"] != null) lbltitmes.Text = Session["sestitmes"].ToString();
                if (Session["sesgtotal"] != null) lblgtotal.Text = Session["sesgtotal"].ToString();
                if (_retf == "1") Response.Redirect("Menu.aspx");
                if (_retf == "2") Response.Redirect("Order.aspx");
            }
        }

        public void calc(DataTable dt)
        {
            int qty = 0;
            decimal gtotal = 0;
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    string x = dr["itqty"].ToString();
                    if (dr["itqty"].ToString().Length == 0) dr["itqty"] = "0";
                    qty = qty + Convert.ToInt16(dr["itqty"].ToString());

                    if (dr["ittotal"].ToString().Length == 0) dr["ittotal"] = "0";
                    gtotal = gtotal + Convert.ToDecimal(dr["ittotal"].ToString());
                }
                catch (Exception ex) { }
            }
            Session["sestitmes"] = qty;
            Session["sesgtotal"] = gtotal;

        }

        public DataTable AddItemIntoTable(DataTable dtMyTable_Adr, string itid, string qty, string catname, string _retf)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();
            string price = "0";
            string desc = ".";
            string name = "";
            DataSet dsx = new DataSet();
            dsx = ajdbClass.GetRecords("tbl", "select * from items where itid='" + itid + "'");


            foreach (DataRow dr in dsx.Tables[0].Rows)
            {
                if (dr["itid"].ToString().Trim() == itid)
                {
                    price = dr["itprice"].ToString().Trim();
                    desc = dr["itdesc"].ToString().Trim();
                    name = dr["itname"].ToString().Trim();

                    decimal total = Convert.ToDecimal(price) * 1;
                    DataRow myNewRow_Adr = dtMyTable_Adr.NewRow();
                    myNewRow_Adr["catname"] = catname;
                    myNewRow_Adr["itid"] = itid;
                    myNewRow_Adr["itname"] = name;
                    myNewRow_Adr["itdesc"] = desc;
                    myNewRow_Adr["itprice"] = price;

                    myNewRow_Adr["itqty"] = qty;
                    myNewRow_Adr["ittotal"] = total;

                    dtMyTable_Adr.Rows.Add(myNewRow_Adr);
                    dtMyTable_Adr.AcceptChanges();
                }

            }
            return dtMyTable_Adr;

        }

        public DataTable UpdateItemIntoTable(DataTable dtMyTable_Adr, string itid, string qty, string catname, string _retf)
        {
            AJ_DataClass ajdbClass = new AJ_DataClass();


            foreach (DataRow dr in dtMyTable_Adr.Rows)
            {
                if (dr["itid"].ToString().Trim() == itid)
                {


                    string price = "0";
                    string desc = ".";
                    string name = "";
                    string thisQty = dr["itqty"].ToString();

                    DataSet dsx = new DataSet();
                    dsx = ajdbClass.GetRecords("tbl", "select * from items where itid='" + itid + "'");

                    foreach (DataRow drx in dsx.Tables[0].Rows)
                    {
                        price = drx["itprice"].ToString().Trim();
                        desc = drx["itdesc"].ToString().Trim();
                        name = drx["itname"].ToString().Trim();
                    }
                    if (qty == "1") qty = (Convert.ToInt16(thisQty) + 1).ToString();
                    if (qty == "-1")
                    {
                        if (thisQty != "0") qty = (Convert.ToInt16(thisQty) - 1).ToString();
                    }

                    decimal total = 0;
                    if (thisQty != "0") total = Convert.ToDecimal(price) * Convert.ToDecimal(qty);
                    dr.SetField("itprice", price);
                    dr.SetField("itqty", qty);
                    dr.SetField("ittotal", total);

                    //DataRow myNewRow_Adr = dtMyTable_Adr.NewRow();
                    //myNewRow_Adr["catname"] = catname;
                    //myNewRow_Adr["itid"] = itid;
                    //myNewRow_Adr["itname"] = name;
                    //myNewRow_Adr["itdesc"] = desc;
                    //myNewRow_Adr["itprice"] = price;

                    //myNewRow_Adr["itqty"] = qty;
                    //myNewRow_Adr["ittotal"] = total;

                    //dtMyTable_Adr.Rows.Add(myNewRow_Adr);
                    //dtMyTable_Adr.AcceptChanges();
                }

            }
            return dtMyTable_Adr;
        }

        public bool checkifitemAlradyExists(string itid)
        {
            bool _exist = false;
            DataTable dtMyTable_Adr = (DataTable)Session["sesOrderTable"];
            foreach (DataRow dr in dtMyTable_Adr.Rows)
            {
                if (itid == dr["itid"].ToString().Trim()) { _exist = true; }
            }

            return _exist;
        }


        DataTable sesTableLogin;
        private DataTable createTbl_for_LoginUser()
        {
            sesTableLogin = new DataTable("sesOrderTable");

            DataColumn myCol0 = new DataColumn("catname"); myCol0.DataType = System.Type.GetType("System.String"); myCol0.MaxLength = 100;
            DataColumn myCol1 = new DataColumn("itid"); myCol1.DataType = System.Type.GetType("System.String"); myCol1.MaxLength = 50;
            DataColumn myCol2 = new DataColumn("itname"); myCol2.DataType = System.Type.GetType("System.String"); myCol2.MaxLength = 200;
            DataColumn myCol3 = new DataColumn("itdesc"); myCol3.DataType = System.Type.GetType("System.String"); myCol3.MaxLength = 1000;
            DataColumn myCol4 = new DataColumn("itprice"); myCol4.DataType = System.Type.GetType("System.String"); myCol4.MaxLength = 200;
            DataColumn myCol5 = new DataColumn("itqty"); myCol5.DataType = System.Type.GetType("System.String"); myCol5.MaxLength = 50;
            DataColumn myCol6 = new DataColumn("ittotal"); myCol6.DataType = System.Type.GetType("System.String"); myCol6.MaxLength = 50;

            sesTableLogin.Columns.Add(myCol0); sesTableLogin.Columns.Add(myCol1); sesTableLogin.Columns.Add(myCol2); sesTableLogin.Columns.Add(myCol3);
            sesTableLogin.Columns.Add(myCol4);
            sesTableLogin.Columns.Add(myCol5);
            sesTableLogin.Columns.Add(myCol6);
            sesTableLogin.AcceptChanges();

            // Create Dataset for returning to cart Ended
            return sesTableLogin;
        }

    }
}
