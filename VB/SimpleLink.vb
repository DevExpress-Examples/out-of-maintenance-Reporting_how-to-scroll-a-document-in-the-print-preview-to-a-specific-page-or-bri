Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.IO

Namespace PrintGoToPage
	Friend Class SimpleLink
		Inherits Link
		Private text_Renamed As String

		Public Property Text() As String
			Get
				Return text_Renamed
			End Get
			Set(ByVal value As String)
				text_Renamed = value
			End Set
		End Property

		Public Sub New()
			Me.New("")

		End Sub

		Public Sub New(ByVal text As String)
			Me.text_Renamed = text
		End Sub

		Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
			MyBase.CreateDetail(graph)

			Dim textSize As SizeF = graph.MeasureString(Text, CInt(Fix(graph.ClientPageSize.Width)))

			Dim rect As New RectangleF(0, 0, textSize.Width, textSize.Height)

			graph.BorderWidth = 0
			graph.DrawString(text_Renamed, rect)
		End Sub
	End Class
End Namespace
