<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597670/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2386)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [SimpleLink.cs](./CS/SimpleLink.cs) (VB: [SimpleLink.vb](./VB/SimpleLink.vb))
<!-- default file list end -->
# How to scroll a document in the print preview to a specific page or brick


<p>Basically, this example demonstrates how to scroll a document in the print preview to a specific page. To accomplish this task it's enough to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingControlPrintControl_SelectedPageIndextopic">PrintControl.SelectedPageIndex Property </a> value to the desired page index. Note that you can even scroll to a specific brick within a document page. For this, use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingControlPrintControl_ShowBricktopic">PrintControl.ShowBrick Method </a> and, optionally, <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPrintingSystemBase_MarkBricktopic">PrintingSystemBase.MarkBrick Method </a>.</p>

<br/>


