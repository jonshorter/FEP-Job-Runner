Imports System.Timers
Public Module Automation

    Public Class CheckJob : Implements IDisposable
        Public JobGUID As String
        Public Sub CheckOnJob()
            Dim JTimer As New System.Timers.Timer()
            JTimer.Interval = 10000
            AddHandler JTimer.Elapsed, New ElapsedEventHandler(AddressOf JTimeUp)
            JTimer.Enabled = True
        End Sub
        Private Sub JTimeUp(ByVal source As Object, ByVal e As ElapsedEventArgs)
            Dim JTimer As System.Timers.Timer = DirectCast(source, System.Timers.Timer)
            Dim stat = GetJobStatus(JobGUID)

            Select Case stat
                Case 0
                    MsgBox(JobGUID & "Not Started")
                Case 1
                    MsgBox(JobGUID & "Queued")
                Case 2
                    MsgBox(JobGUID & "Collecting")
                Case 3
                    JTimer.Enabled = False
                    Me.Dispose()
                    MsgBox(JobGUID & "Completed")
                Case 4
                    MsgBox(JobGUID & "Waiting")
                Case 5
                    MsgBox(JobGUID & "Cancelled")
                Case 6
                    MsgBox(JobGUID & "Terminated")
                Case 7
                    MsgBox(JobGUID & "Failed")
                Case 8
                    MsgBox(JobGUID & "Completed with Errors")


            End Select

        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class


 

End Module
