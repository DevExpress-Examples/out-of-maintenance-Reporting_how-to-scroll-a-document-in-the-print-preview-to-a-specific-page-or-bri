Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace PrintGoToPage
	Partial Public Class Form1
		Inherits Form
		Public Delegate Sub ActivateFormDelegate()

		Public Sub ActivateFormMethod()
			Me.Activate()
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			For i As Integer = 0 To 499
				Dim link As New SimpleLink("Simple Text " & i.ToString())
				compositeLink1.Links.Add(link)
			Next i

			compositeLink1.ShowPreview()
			button2.Enabled = True
			button3.Enabled = True

			Me.BeginInvoke(New ActivateFormDelegate(AddressOf ActivateFormMethod))
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			printingSystem1.PreviewFormEx.PrintControl.SelectedPageIndex = 2
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim page As DevExpress.XtraPrinting.Page = printingSystem1.Document.Pages(3)
			Dim brickEnumerator As DevExpress.XtraPrinting.BrickEnumerator = page.GetEnumerator()
			Dim brick As DevExpress.XtraPrinting.Brick = Nothing

			For i As Integer = 0 To 4
				brickEnumerator.MoveNext()
				brick = brickEnumerator.CurrentBrick
			Next i

			printingSystem1.PreviewFormEx.PrintControl.ShowBrick(brick, page)
			printingSystem1.MarkBrick(brick, page)
		End Sub

	End Class
End Namespace