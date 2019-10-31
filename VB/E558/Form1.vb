Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports System.Windows.Forms

Namespace E558
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			AddHandler schedulerControl1.EditAppointmentFormShowing, AddressOf schedulerControl1_EditAppointmentFormShowing
		End Sub

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
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
		Protected Overrides Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek) As Form
			Dim frm As New XtraForm1(patternCopy, firstDayOfWeek, Me.Controller)
			frm.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel
			frm.ShowExceptionsRemoveMsgBox = Me.Controller.AreExceptionsPresent()
			Return frm
		End Function
	End Class
End Namespace