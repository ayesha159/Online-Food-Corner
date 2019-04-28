using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web;
/// <summary>
/// Summary description for AJ_DataClass
/// </summary>
public class AJ_DataClass
{
    string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    public AJ_DataClass()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void GetUserInfo(string _id, ref string _Name, ref string _RoleType)
    {
        string myConnectionString = strcon;
        string tTable = string.Empty;
        SqlConnection con = new SqlConnection(myConnectionString);
        DataSet ds = new DataSet();

        if (con.State == ConnectionState.Closed) con.Open();
        SqlCommand com = new SqlCommand("Select * from tblRegister where r_id ='" + _id + "'", con);
        int i = com.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.TableMappings.Add("Table", "_Table");
        if (con.State == ConnectionState.Open)
            con.Close();
        da.Fill(ds);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            _Name = dr["RName"].ToString().Trim();
            string _RT = "";
            if (dr["r_id"].ToString().Trim() == "1")
            {
                _RoleType = "Admin";
            }
            else
            {

                if (dr["RisAcceptor"].ToString().Trim().Length  != 0)
                {
                    bool _a = Convert.ToBoolean(dr["RisAcceptor"]);
                    if (_a == true) _RoleType = "Acceptor";
                }

                if (dr["RisDonor"].ToString().Trim().Length != 0)
                {
                    bool _a = Convert.ToBoolean(dr["RisDonor"]);
                    if (_a == true) _RoleType = _RoleType + ".Donor";
                }

            }

        }
    }
        



        public DataSet GetRecords(string _Table, string Qry)
    {
        string myConnectionString = strcon;
        string tTable = string.Empty;
        SqlConnection con = new SqlConnection(myConnectionString);
        DataSet ds = new DataSet();

        if (con.State == ConnectionState.Closed) con.Open();
        SqlCommand com = new SqlCommand(Qry, con);
        int i = com.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.TableMappings.Add("Table", _Table);
        if (con.State == ConnectionState.Open)
            con.Close();
        da.Fill(ds);
        return ds;
    }

    public int TRec(string Qry)
    {
        string myConnectionString = strcon;
        string tTable = string.Empty;
        SqlConnection con = new SqlConnection(myConnectionString);
        DataSet ds = new DataSet();

        if (con.State == ConnectionState.Closed) con.Open();
        SqlCommand com = new SqlCommand(Qry, con);
        int i = com.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.TableMappings.Add("Table", "_Table");
        if (con.State == ConnectionState.Open)
            con.Close();
        da.Fill(ds);
        return ds.Tables[0].Rows.Count;

    }

    public string InsertIntoDatabase(string _Table, string _Fields, string _Values)
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO " + _Table + " (" + _Fields + ") VALUES (" + _Values + ")";
            cmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
                con.Close();
            return "Record(s) Added Succfully";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

    public string DeleteFromDatabase(string Qry)
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Qry;
            cmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
                con.Close();
            return "Delete Record(s) Succfully";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

    public string UpdateDatabase(string Qry)
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Qry;
            cmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
                con.Close();
            return "Update Record(s) Succfully";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

}

