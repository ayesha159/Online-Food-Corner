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

namespace onlinefoodcorner
{
    public partial class userReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ReportDocument rpt = new ReportDocument();

            rpt.Load(Server.MapPath("UserDetails.rpt"));
            
      //   report.SetDatabaseLogon("username", "pwd", @"server", "database");
      //   report.SetDatabaseLogon("username", "pwd", @"server", "database");
            
       //  rptviewer.ReportSource = report;

            // EmployeeList rpt = new EmployeeList();
            // crystalReportViewer1.ReportSource = rpt;
          //  UserDetails rpt = new UserDetails();
           // ReportDocument cryRpt = new ReportDocument();
           // cryRpt.Load(Server.MapPath("UserDetails.rpt"));
            CrystalReportViewer1.ReportSource = rpt;
        }
    }
}