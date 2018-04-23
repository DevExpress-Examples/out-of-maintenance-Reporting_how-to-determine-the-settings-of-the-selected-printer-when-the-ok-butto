using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
// ...

namespace DeterminePrinterSettings {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.PrintingSystem.StartPrint += 
                new PrintDocumentEventHandler(PrintingSystem_StartPrint);
            report.ShowPreviewDialog();
            report.PrintingSystem.StartPrint -= PrintingSystem_StartPrint;
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