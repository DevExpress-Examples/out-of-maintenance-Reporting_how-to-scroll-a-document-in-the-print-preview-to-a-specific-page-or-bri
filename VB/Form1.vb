Imports DevExpress.XtraPrinting
Imports System
Imports System.Linq
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
			If Not Me.button1.IsHandleCreated Then Return

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
			If Not Me.button2.IsHandleCreated Then Return

			printingSystem1.PreviewFormEx.PrintControl.SelectedPageIndex = 2
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If Not Me.button3.IsHandleCreated Then Return

			Dim page As Page = printingSystem1.Document.Pages(3)
			Dim brick = BrickSelector.GetBricks(page).Skip(4).FirstOrDefault()

			If brick IsNot Nothing Then
				printingSystem1.PreviewFormEx.PrintControl.ShowBrick(brick, page)
				printingSystem1.MarkBrick(brick, page)
			End If
		End Sub

	End Class
End Namespace