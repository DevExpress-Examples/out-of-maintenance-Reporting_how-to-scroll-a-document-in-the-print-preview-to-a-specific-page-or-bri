Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.IO

Namespace PrintGoToPage
	Friend Class SimpleLink
		Inherits Link

'INSTANT VB NOTE: The field text was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private text_Conflict As String

		Public Property Text() As String
			Get
				Return text_Conflict
			End Get
			Set(ByVal value As String)
				text_Conflict = value
			End Set
		End Property

		Public Sub New()
			Me.New("")

		End Sub

		Public Sub New(ByVal text As String)
			Me.text_Conflict = text
		End Sub

		Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
			MyBase.CreateDetail(graph)

			Dim textSize As SizeF = graph.MeasureString(Text, CInt(graph.ClientPageSize.Width))

			Dim rect As New RectangleF(0, 0, textSize.Width, textSize.Height)

			graph.BorderWidth = 0
			graph.DrawString(text_Conflict, rect)
		End Sub
	End Class
End Namespace
