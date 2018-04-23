Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace DeterminePrinterSettings
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			Dim printTool As New ReportPrintTool(report)

			AddHandler (CType(printTool.Report, XtraReport1)).PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint

			printTool.ShowPreviewDialog()

			RemoveHandler (CType(printTool.Report, XtraReport1)).PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
		End Sub

		Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			AddHandler e.PrintDocument.BeginPrint, AddressOf PrintDocument_BeginPrint
		End Sub

		Private Sub PrintDocument_BeginPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			Dim doc As PrintDocument = TryCast(sender, PrintDocument)
			Dim printerName As String = doc.PrinterSettings.PrinterName
			' ... your code
		End Sub

	End Class
End Namespace