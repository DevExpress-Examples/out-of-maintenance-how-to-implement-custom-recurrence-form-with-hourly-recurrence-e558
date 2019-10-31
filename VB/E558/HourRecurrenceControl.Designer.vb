Namespace E558
	Partial Public Class HourRecurrenceControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(48, 32)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(59, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Re&cur every"
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(120, 25)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 23, 0, 0, 0})
			Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEdit1.Size = New System.Drawing.Size(48, 20)
			Me.spinEdit1.TabIndex = 1
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(176, 32)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(23, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "Hour"
			' 
			' HourRecurrenceControl
			' 
			Me.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.labelControl1)
			Me.Name = "HourRecurrenceControl"
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
