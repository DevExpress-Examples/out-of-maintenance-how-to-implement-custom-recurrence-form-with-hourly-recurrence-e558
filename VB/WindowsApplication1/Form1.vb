Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
			Dim frm As New MyAppointmentForm(TryCast(sender, SchedulerControl), e.Appointment, e.OpenRecurrenceForm)
			e.DialogResult = frm.ShowDialog()
			e.Handled = True
		End Sub
	End Class
	Public Class MyAppointmentForm
		Inherits AppointmentForm
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
			MyBase.New(control, apt, openRecurrenceForm)
		End Sub
        Protected Overrides Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As DevExpress.XtraScheduler.FirstDayOfWeek) As Form
            Dim frm As New XtraForm1(patternCopy, firstDayOfWeek, Me.Controller)
            frm.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel
            frm.ShowExceptionsRemoveMsgBox = Me.Controller.AreExceptionsPresent()
            Return frm
        End Function
	End Class
End Namespace