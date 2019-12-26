Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports System

Namespace E558
	Partial Public Class XtraForm1
		Inherits LegacyAppointmentRecurrenceForm

		Public Sub New(ByVal pattern As Appointment, ByVal fdow As FirstDayOfWeek, ByVal afc As AppointmentFormController)
			MyBase.New(pattern, fdow, afc)
			'InitializeComponent();
			checkEdit1.Tag = RecurrenceType.Hourly
			UnsubscribeRecurrenceTypeControlsEvents()
			SubscribeRecurrenceTypeControlsEvents()
			SetRecurrenceType(Me.GetRecurrenceType())
		End Sub

		Protected Overrides Sub InitializeControls(ByVal firstDayOfWeek As FirstDayOfWeek)
			InitializeComponent()
			MyBase.InitializeControls(firstDayOfWeek)
		End Sub

		Protected Overrides Sub SubscribeRecurrenceTypeControlsEvents()
			MyBase.SubscribeRecurrenceTypeControlsEvents()
			If checkEdit1 IsNot Nothing Then
				AddHandler checkEdit1.EditValueChanged, AddressOf chkRecurrenceTypeChanged
			End If
		End Sub
		Protected Overrides Sub UnsubscribeRecurrenceTypeControlsEvents()
			MyBase.UnsubscribeRecurrenceTypeControlsEvents()
			If checkEdit1 IsNot Nothing Then
				RemoveHandler checkEdit1.EditValueChanged, AddressOf chkRecurrenceTypeChanged
			End If
		End Sub
		Protected Overrides Sub ChangeCurrentRecurrenceControl()
			If Me.CurrentRecurrenceControl IsNot Nothing Then
				Me.CurrentRecurrenceControl.Visible = False
			End If
			Select Case Me.GetRecurrenceType()
				Case RecurrenceType.Daily
					Me.CurrentRecurrenceControl = Me.dailyRecurrenceControl1

				Case RecurrenceType.Weekly
					Me.CurrentRecurrenceControl = Me.weeklyRecurrenceControl1

				Case RecurrenceType.Monthly
					Me.CurrentRecurrenceControl = Me.monthlyRecurrenceControl1
				Case RecurrenceType.Hourly
					Me.CurrentRecurrenceControl = Me.hourRecurrenceControl1

				Case Else
					Me.CurrentRecurrenceControl = Me.yearlyRecurrenceControl1
			End Select

			Me.CurrentRecurrenceControl.Visible = True

		End Sub
		Protected Overrides Sub SetRecurrenceType(ByVal type As RecurrenceType)
            If type = RecurrenceType.Hourly AndAlso checkEdit1 IsNot Nothing Then
                checkEdit1.Checked = True
                Return
            End If
            MyBase.SetRecurrenceType(type)
		End Sub
	End Class
End Namespace