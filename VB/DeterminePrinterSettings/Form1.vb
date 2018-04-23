Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
' ...

Namespace DeterminePrinterSettings
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			AddHandler report.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
			report.ShowPreviewDialog()
			RemoveHandler report.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
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