private void btnPrint_Click(object sender, EventArgs e)
{
    LocalReport localReport = new LocalReport();
    localReport.ReportPath = Application.StartupPath + "\\Report1.rdlc";
    localReport.PrintToPrinter();
}