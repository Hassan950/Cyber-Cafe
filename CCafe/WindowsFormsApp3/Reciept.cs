using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCafe
{
    public partial class Reciept : Form
    {
        Receipt_details r;
        public Reciept(Receipt_details rdetails)
        {
            InitializeComponent();
            r = rdetails;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("EmployeeID",r.employeeid),
                new Microsoft.Reporting.WinForms.ReportParameter("CustomerID",r.customerid),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",r.date),
                new Microsoft.Reporting.WinForms.ReportParameter("StartTime",r.starttime),
                new Microsoft.Reporting.WinForms.ReportParameter("EndTime",r.endtime),
                new Microsoft.Reporting.WinForms.ReportParameter("RoomNumber",r.room_no),
                new Microsoft.Reporting.WinForms.ReportParameter("GameName",r.gamename),
                new Microsoft.Reporting.WinForms.ReportParameter("TimeSpent",r.TimeSpent),
                new Microsoft.Reporting.WinForms.ReportParameter("MoneyPerHour",r.MoneyPerHour),
                new Microsoft.Reporting.WinForms.ReportParameter("Tax",r.Tax),
                new Microsoft.Reporting.WinForms.ReportParameter("Discount",r.Discount),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalMoney",r.TotalMoney),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
