using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace print_directy_report_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("teste", "TENTANDO"));           
            var dtStudents = GetDataStudents();
            var dtUsers = GetDataUsers();
            LocalReport localReport = new LocalReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + "\\Report1.rdlc";
            localReport.ReportPath = fullPath;
            localReport.SetParameters(rpc);
            //localReport.ReportPath = Application.StartupPath + "\\Report1.rdlc";
          
            localReport.DataSources.Add(new ReportDataSource("dtStudents", dtStudents));
            localReport.DataSources.Add(new ReportDataSource("dataUsers", dtUsers));
            //int printQty = Convert.ToInt32(txtPrintQty.Text);

            //for (int i = 0; i < printQty; i++)
            //{
                localReport.PrintToPrinter();
            //}
        }

        private DataTable GetDataStudents(string sql = "select id, name, cpf, birth from students")
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=dbGymControl;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(table);
            }

            return table;
        }
        
        private DataTable GetDataUsers(string sql = "select id, name, name_user, email from users")
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=dbGymControl;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(table);
            }

            return table;
        }
    }
}
