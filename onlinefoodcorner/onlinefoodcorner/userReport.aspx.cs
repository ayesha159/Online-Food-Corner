using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;

using System.Data.SqlClient;


namespace onlinefoodcorner
{
    public partial class userReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(Server.MapPath("UserDetails.rpt"));
            user dsCustomers = GetData("select * from [User]");
            crystalReport.SetDataSource(dsCustomers);
            CrystalReportViewer1.ReportSource = crystalReport;

            var stream = crystalReport.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            //   CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat);
            var pdfbyteArray = new byte[stream.Length];
          //  new byte[bufferByte.Length];

            stream.Position = 0;
            stream.Read(pdfbyteArray, 1, Convert.ToInt32(stream.Length));
            Context.Response.ClearContent();
            Context.Response.ClearHeaders();
            Context.Response.AddHeader("content-disposition", "filename=Report.pdf");
            Context.Response.ContentType = "application/pdf";
            Context.Response.AddHeader("content-length", pdfbyteArray.Length.ToString());
            Context.Response.BinaryWrite(pdfbyteArray);

        }
        private user GetData(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (user dsCustomers = new user())
                    {
                        sda.Fill(dsCustomers, "DataTable1");
                        return dsCustomers;
                    }
                }
            }
        }
    }
}