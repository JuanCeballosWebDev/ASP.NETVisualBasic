Imports System.Data




Partial Class MyPersonRecords
    Inherits WebUtility

    Public personrecords As New Collections.ArrayList

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        iPage_Load(sender, e)

        Dim Connection As OleDb.OleDbConnection
        Dim Command As OleDb.OleDbCommand
        Dim Reader As OleDb.OleDbDataReader


        Connection = New OleDb.OleDbConnection()
        Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CIS241\CIS241SUM2009\db2\cis241db.mdb"
        Connection.Open()
        Command = Connection.CreateCommand()
        Command.CommandText = "SELECT * FROM persontable"
        Reader = Command.ExecuteReader()
        personrecords.Clear()
        If Reader.Read() Then
            Do
                personrecords.Add(New personclass(Reader))
            Loop While Reader.Read()
            Reader.Close()
            Reader = Nothing
        End If
        Command.Dispose()
        Command = Nothing
        Connection.Close()
        Connection = Nothing


        personRepeater.DataSource = personrecords
        personRepeater.DataBind()


    End Sub

    Protected Sub personRepeater_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles personRepeater.ItemCommand
        Dim PersonID As String
        PersonID = CType(e.CommandSource, LinkButton).Attributes("PersonID")
        currentUser.PersonID = PersonID
        Response.Redirect("MyPersonDetail.aspx", True)
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        currentUser.PersonID = 0
        Response.Redirect("MyPersonDetail.aspx", True)
    End Sub
End Class
