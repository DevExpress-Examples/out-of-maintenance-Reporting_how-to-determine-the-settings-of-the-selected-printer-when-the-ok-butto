<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DeterminePrinterSettings/Form1.cs) (VB: [Form1.vb](./VB/DeterminePrinterSettings/Form1.vb))
<!-- default file list end -->
# How to determine the settings of the selected printer when the OK button is pressed in the Printer dialog


<p>To perform this, you should subscribe to the <a href="http://www.devexpress.com/Help/Content.aspx?help=XtraData&document=DevExpressXtraPrintingPrintingSystemBase_StartPrinttopic.htm"><u>PrintingSystemBase.StartPrint</u></a> event of a report's <a href="http://www.devexpress.com/Help/Content.aspx?help=XtraReports&document=DevExpressXtraReportsUIXtraReport_PrintingSystemtopic.htm"><u>XtraReport.PrintingSystem</u></a>, catch the <i>PrintDocument</i> parameter passed to the event handler and finally subscribe to the <strong>PrintDocument</strong>'s <strong>BeforePrint</strong> event.  This event is triggered when the "OK" button is pressed and so you will be able to get the printer's properties.</p><p><strong>See Also:</strong><br />
- <a href="https://www.devexpress.com/Support/Center/p/A1912">How to hide the Printing status window</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1766">How to programmatically select a printer</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1768">How to programmatically print a specified range of report pages</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E332">How to dynamically select the paper source and set the printer resolution</a>.</p>

<br/>


