Imports System.Data.SqlClient
Module MyMod
    Public mycommand As New System.Data.SqlClient.SqlCommand
    Public myadapter As New System.Data.SqlClient.SqlDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.SqlClient.SqlDataReader
    Public SQL As String
    Public conn As New SqlConnection
    Public cn As New Connection

    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    Public Sub DBConnect()
        cn.DataSource = "DESKTOP-QJ51NG5\SQLEXPRESS"
        cn.DatabaseName = "umc"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
End Module
