Namespace E558
	Partial Public Class XtraForm1
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
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.hourRecurrenceControl1 = New E558.HourRecurrenceControl()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' grpRecurrencePattern
			' 
			Me.grpRecurrencePattern.Controls.Add(Me.hourRecurrenceControl1)
			Me.grpRecurrencePattern.Controls.Add(Me.checkEdit1)
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(16, 120)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
			Me.checkEdit1.Properties.Caption = "Hourly"
			Me.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.checkEdit1.Properties.RadioGroupIndex = 1
			Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit1.TabIndex = 13
			Me.checkEdit1.TabStop = False
			Me.checkEdit1.Tag = "Hourly"
			' 
			' hourRecurrenceControl1
			' 
			Me.hourRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hourRecurrenceControl1.Appearance.Options.UseBackColor = True
			Me.hourRecurrenceControl1.Location = New System.Drawing.Point(80, 24)
			Me.hourRecurrenceControl1.Name = "hourRecurrenceControl1"
			Me.hourRecurrenceControl1.Size = New System.Drawing.Size(368, 96)
			Me.hourRecurrenceControl1.TabIndex = 14
			Me.hourRecurrenceControl1.Visible = False
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(488, 390)
			Me.Name = "XtraForm1"
			Me.Text = "XtraForm1"

			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private hourRecurrenceControl1 As HourRecurrenceControl
	End Class
End Namespace