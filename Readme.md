<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597670/20.2.8%2B)
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


This example demonstrates the following ways:

* **How to scroll a document in the print preview to a specific page.**

To accomplish this task, it's enough to set the [PrintControl.SelectedPageIndex Property](http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingControlPrintControl_SelectedPageIndextopic) property value to the required page index.

* **How to scroll to a specific brick and mark it.**

First, you need to use our [BrickSelector](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.BrickSelector) to get the required [Brick](https://docs.devexpress.com/WindowsForms/88/controls-and-libraries/printing-exporting/concepts/basic-terms/bricks).
Then, you can use the [PrintControl.ShowBrick](http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingControlPrintControl_ShowBricktopic) method and, optionally, the [PrintingSystemBase.MarkBrick](http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPrintingSystemBase_MarkBricktopic) method.


