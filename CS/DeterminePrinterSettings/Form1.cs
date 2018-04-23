using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace DeterminePrinterSettings {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);

            ((XtraReport1)printTool.Report).PrintingSystem.StartPrint +=
                new PrintDocumentEventHandler(PrintingSystem_StartPrint);

            printTool.ShowPreviewDialog();

            ((XtraReport1)printTool.Report).PrintingSystem.StartPrint -= PrintingSystem_StartPrint;
        }

        private void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
            e.PrintDocument.BeginPrint +=
                new PrintEventHandler(PrintDocument_BeginPrint);
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e) {
            PrintDocument doc = sender as PrintDocument;
            string printerName = doc.PrinterSettings.PrinterName;
            // ... your code
        }

    }
}