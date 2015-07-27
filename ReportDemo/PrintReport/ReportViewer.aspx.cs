using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace ReportDemo.PrintReport
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                loadTaskReport();             

            }
        }

        private void loadTaskReport()
        {

            ReportData tr = new ReportData();
            tr.loadReportData();


          

            if (this.ReportViewer1.LocalReport.DataSources.Count > 0)
            {
                this.ReportViewer1.LocalReport.DataSources.RemoveAt(0);
            }
            ReportViewer1.LocalReport.ReportPath = "PrintReport\\RDLCReport\\StudentReport.rdlc";


            this.ReportViewer1.LocalReport.DisplayName = "Student Report";

            ReportParameter p1 = new ReportParameter("TotalStudent", tr.TotalStudent.ToString());
            ReportParameter p2 = new ReportParameter("Date", DateTime.Now.ToShortDateString());
          


            this.ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2});

            this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentListDS", tr.StudentList));
           

            //Warning[] warnings;
            //string[] streamids;
            //string mimeType;
            //string encoding;
            //string extension;
            //byte[] bytes = this.ReportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
            //MemoryStream s = new MemoryStream(bytes);
            //s.Seek(0, SeekOrigin.Begin);

            //DMS.Core.EmailHelper.sendMail("apathak@bjsindia.org", "ssangle@bjsindia.org", "Task Report", "This is test task report", s);

        }
    }
}