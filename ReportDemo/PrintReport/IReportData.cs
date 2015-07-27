using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDemo.PrintReport
{
    interface IReportData
    {
        List<student> StudentList { get; set; }
        int TotalStudent { get; set; }
        void loadReportData();
    }
}
