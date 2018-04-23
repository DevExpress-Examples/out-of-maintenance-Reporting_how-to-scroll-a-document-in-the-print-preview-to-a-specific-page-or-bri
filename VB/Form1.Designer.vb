Imports Microsoft.VisualBasic
Imports System
Namespace PrintGoToPage
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.compositeLink1 = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.compositeLink1})
			' 
			' compositeLink1
			' 
			' 
			' 
			' 
			Me.compositeLink1.ImageCollection.ImageStream = (CType(resources.GetObject("compositeLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.compositeLink1.PrintingSystem = Me.printingSystem1
			Me.compositeLink1.PrintingSystemBase = Me.printingSystem1
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(55, 12)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(96, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Show preview"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Enabled = False
			Me.button2.Location = New System.Drawing.Point(55, 41)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(96, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Go to page 3"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Enabled = False
			Me.button3.Location = New System.Drawing.Point(34, 70)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(139, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Go to brick 5 on page 4"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(206, 107)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private compositeLink1 As DevExpress.XtraPrintingLinks.CompositeLink
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

