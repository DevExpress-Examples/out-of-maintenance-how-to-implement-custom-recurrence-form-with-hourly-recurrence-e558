Imports DevExpress.XtraScheduler.UI
Imports System

Namespace E558
    Partial Public Class HourRecurrenceControl
        Inherits RecurrenceControlBase

        Public Sub New()
            MyBase.New()
            InitializeComponent()
            Me.UpdateControlsCore()
            Me.SubscribeControlsEvents()

        End Sub
        Protected Overrides Sub SubscribeControlsEvents()
            MyBase.SubscribeControlsEvents()
            AddHandler spinEdit1.EditValueChanged, AddressOf spinEdit1_EditValueChanged
        End Sub
        Protected Overrides Sub UnsubscribeControlsEvents()
            MyBase.UnsubscribeControlsEvents()
            RemoveHandler spinEdit1.EditValueChanged, AddressOf spinEdit1_EditValueChanged
        End Sub

        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.RecurrenceInfo.Periodicity = MyBase.Validator.GetIntegerValue(Me.spinEdit1.EditValue)
        End Sub
        Protected Overrides Sub UpdateControlsCore()
            MyBase.UpdateControlsCore()
            Me.spinEdit1.EditValue = MyBase.RecurrenceInfo.Periodicity
        End Sub
    End Class
End Namespace
