using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
/// <summary>
/// Summary description for AJ_DataClass
/// </summary>
public class AJ_DataClass
{
    string strcon = @"Data Source=localhost;Initial Catalog=FoodCorner;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
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
        SqlCommand com = new SqlCommand("Select * from [User] where Uid = '" + _id + "'", con);
        int i = com.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = com;
        da.TableMappings.Add("Table", "_Table");
        if (con.State == ConnectionState.Open)
            con.Close();
        da.Fill(ds);

       

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
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            { con.Close(); }
            return "Record(s) Added Successfully";
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
            return "Delete Record(s) Successfully";
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
            return "Update Record(s) Successfully";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

}

