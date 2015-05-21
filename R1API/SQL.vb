Imports System.Data.SqlClient
Public Module SQLFunctions

    Public Sub FillDataGrid()
        Dim sqltest = TestSQLSettings()
        If sqltest = "Success" Then

            'TODO: This line of code loads data into the 'EDiscoveryDataSet.ProductionSet_ExportTemplates' table. You can move, or remove it, as needed.
            Try
                FillDataGridView()

                '     Me.ProductionSet_ExportTemplatesTableAdapter.Fill(Me.EDiscoveryDataSet.ProductionSet_ExportTemplates)

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox("Error connecting to SQL. ")
                '  Settings.ShowDialog()

            End Try
            'Update the Template Names - Code located in XMLCode.vb
            ' UpdateTemplateNames()
        Else

            'Settings.ShowDialog()
        End If
    End Sub


    Public Function SQLConnectionString()



        Dim myConnection As New SqlConnection("")
        If My.Settings.sqlauth = "Windows" Then

            myConnection = New SqlConnection("Data Source=" & My.Settings.sqlserver & ";Initial Catalog=eDiscovery;Integrated Security=SSPI")
            Return myConnection
        Else
            myConnection = New SqlConnection("Data Source=" & My.Settings.sqlserver & ";Initial Catalog=eDiscovery;Persist Security Info=True;User ID=" & My.Settings.sqlusername & ";Password=" & My.Settings.sqlpassword)
            Return myConnection

        End If



    End Function

    Public Function TestSQLSettings()
        Dim myConnection As SqlConnection
        Try

            myConnection = SQLConnectionString()
            myConnection.Open()
            myConnection.Close()
            Return "Success"
        Catch ex As Exception
            Return "Fail"


        End Try
        myConnection.Dispose()
    End Function



    Public Sub InsertECATemplate(item1 As String, item2 As String, item3 As String, item4 As String, item5 As String)
        Try
            Dim myConnection As SqlConnection
            Dim myCommand As SqlCommand
            Dim ra As Integer
            'integer holds the number of records inserted 

            'myConnection = New SqlConnection("server=localhost;uid=sa;pwd=;database=pubs")
            ' If My.Settings.AuthenticationType = True Then
            ' myConnection = New SqlConnection(My.Settings.eDiscoveryConnectionString1)
            ' ElseIf My.Settings.AuthenticationType = False Then
            ' myConnection = New SqlConnection(My.Settings.eDiscoveryConnectionString)
            ' Else
            ' myConnection = New SqlConnection
            ' Settings.ShowDialog()
            ' End If
            myConnection = SQLConnectionString()
            Dim NeID As New Guid()
            Dim UserId As String = NeID.ToString()
            ' MsgBox(UserId)
            '  MsgBox(Guid.NewGuid.ToString)
            'you need to provide password for sql server
            myConnection.Open()
            myCommand = New SqlCommand
            Dim sSql As String = ""

            sSql = "INSERT INTO [eDiscovery].[dbo].[ProductionSet_ExportTemplates]([TemplateId],[ExportDataXML],[CreatedBy],[CreatedDate],[TemplateType])"
            'GUID.NewGUID.TOstring gives you a new unique id, UserID gives you a guid with all zeros
            sSql = sSql & " VALUES('" & Guid.NewGuid.ToString & "','" & item2 & "','" & UserId & "','" & item4 & "','" & item5 & "')"
            myCommand = New SqlCommand(sSql, myConnection)
            ra = myCommand.ExecuteNonQuery()
            myConnection.Close()
            MessageBox.Show("Filter Imported Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Function GetJobStatus(ByVal GUID As String)
        Dim myconnection As SqlConnection
        myconnection = SQLConnectionString()
        Dim sql As String = "SELECT JobStatus FROM [eDiscovery].[dbo].[JobResults] Where JobId='" & GUID & "'"
        ' Dim connection As New SqlConnection(myconnection)
        Dim dataadapter As New SqlDataAdapter(sql, myconnection)
        Dim ds As New DataSet()
        myconnection.Open()
        dataadapter.Fill(ds, "JobResults")
        myconnection.Close()

        Return ds.Tables(0).Rows(0).Item(0)

    End Function


    Public Sub FillDataGridView()
        ' Dim connectionString As String = "Data Source=.;Initial Catalog=pubs;Integrated Security=True"
        Dim myconnection As SqlConnection
        myconnection = SQLConnectionString()
        Dim sql As String = "SELECT * FROM [eDiscovery].[dbo].[ProductionSet_ExportTemplates]"
        ' Dim connection As New SqlConnection(myconnection)
        Dim dataadapter As New SqlDataAdapter(sql, myconnection)
        Dim ds As New DataSet()
        myconnection.Open()
        dataadapter.Fill(ds, "ProductionSet_ExportTemplates")
        myconnection.Close()
        'Main.DataGridView1.DataSource = ds
        'Main.DataGridView1.DataMember = "ProductionSet_ExportTemplates"
    End Sub
End Module
