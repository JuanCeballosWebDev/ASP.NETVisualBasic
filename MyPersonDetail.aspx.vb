Imports System.Data
Partial Class MyPersonDetail
    Inherits WebUtility
    Dim addressTypes As New ArrayList
    Dim CurrentAddressType As AddressTypeClass
    Sub loadAddressTypes()
        Dim Connection As OleDb.OleDbConnection
        Dim Command As OleDb.OleDbCommand
        Dim Reader As OleDb.OleDbDataReader


        Connection = New OleDb.OleDbConnection()
        Connection.ConnectionString = “Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cebal\OneDrive\Server-Side Web Development\db2(2)\db2\cis241db.mdb"
        Connection.Open()
        Command = Connection.CreateCommand()
        Command.CommandText = "SELECT * FROM AddressTypes"
        Reader = Command.ExecuteReader()
        addressTypes.Clear()
        If Reader.Read() Then
            Do
                CurrentAddressType = New AddressTypeClass(Reader)
                addressTypes.Add(CurrentAddressType)

            Loop While Reader.Read()
            Reader.Close()
            Reader = Nothing
        End If
        Command.Dispose()
        Command = Nothing
        Connection.Close()
        Connection = Nothing

        For Each CurrentAddressType In addressTypes
            AddressTypesList.Items.Add( _
               New ListItem(CurrentAddressType.Description, _
                            CurrentAddressType.id))
        Next

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        iPage_Load(sender, e)
        If Not IsPostBack Then
            loadAddressTypes()
            If currentUser.PersonID <> 0 Then
                Dim Connection As OleDb.OleDbConnection
                Dim Command As OleDb.OleDbCommand
                Dim Reader As OleDb.OleDbDataReader
                Dim MyPersonData As personclass

                Connection = New OleDb.OleDbConnection()
                Connection.ConnectionString = “Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cebal\OneDrive\Server-Side Web Development\db2(2)\db2\cis241db.mdb"
                Connection.Open()
                Command = Connection.CreateCommand()
                Command.CommandText = "SELECT * FROM persontable where id = " + currentUser.PersonID
                Reader = Command.ExecuteReader()
                If Reader.Read() Then
                    MyPersonData = New personclass(Reader)
                    IDDisplay.Text = MyPersonData.id
                    FirstNameEntry.Text = MyPersonData.firstname
                    LastNameEntry.Text = MyPersonData.lastname
                    CityTownEntry.Text = MyPersonData.citytown
                    StateEntry.Text = MyPersonData.state
                    ZipCodeEntry.Text = MyPersonData.zipcode
                    PhoneEntry.Text = MyPersonData.phonenumber
                    AgeEntry.Text = MyPersonData.age
                    AddressTypesList.SelectedValue = MyPersonData.addressType
                    Reader.Close()
                    Reader = Nothing
                End If
                Command.Dispose()
                Command = Nothing
                Connection.Close()
                Connection = Nothing
                DisplayMessage.Text = "Viewing Existing Person"
            Else
                cmdDelete.Enabled = False
                DisplayMessage.Text = "Adding New Person"
            End If

        End If

    End Sub



    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim Connection As OleDb.OleDbConnection
        Dim Command As OleDb.OleDbCommand

        Connection = New OleDb.OleDbConnection()
        Connection.ConnectionString = “Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cebal\OneDrive\Server-Side Web Development\db2(2)\db2\cis241db.mdb"
        Connection.Open()
        Command = Connection.CreateCommand()
        If currentUser.PersonID <> 0 Then
            Command.CommandText = "Update persontable set firstname=" + """" + FirstNameEntry.Text + """" + ", " +
                                  "lastname=" + """" + LastNameEntry.Text + """" + ", " +
                                  "citytown=" + """" + CityTownEntry.Text + """" + ", " +
                                  "state=" + """" + StateEntry.Text + """" + ", " +
                                  "zipcode=" + """" + ZipCodeEntry.Text + """" + ", " +
                                  "phonenumber=" + """" + PhoneEntry.Text + """" + ", " +
                                  "age=" + """" + AgeEntry.Text + """" + ", " +
                                  "AddressType=" + """" + AddressTypesList.SelectedValue + """" + " where id=" + currentUser.PersonID + ";"
        Else
            Command.CommandText = "Insert Into persontable (firstname,lastname,citytown, state, zipcode, 
                                   phonenumber, age, AddressType) values(" +
                                    """" + FirstNameEntry.Text + """" + ", " +
                                    """" + LastNameEntry.Text + """" + ", " +
                                    """" + CityTownEntry.Text + """" + ", " +
                                    """" + StateEntry.Text + """" + ", " +
                                    """" + ZipCodeEntry.Text + """" + ", " +
                                    """" + PhoneEntry.Text + """" + ", " +
                                    """" + AgeEntry.Text + """" + ", " +
                                    """" + AddressTypesList.SelectedValue + """" + ");"
        End If

        Dim recordAffected As Boolean = Command.ExecuteNonQuery() = 1
        Command.Dispose()
        Command = Nothing
        Connection.Close()
        Connection = Nothing

        DisplayMessage.Text = "Operation failed"
        If recordAffected Then
            DisplayMessage.Text = "Record Operation Completed"
            Response.Redirect("MyPersonRecords.aspx", True)
        End If

    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim Connection As OleDb.OleDbConnection
        Dim Command As OleDb.OleDbCommand

        Connection = New OleDb.OleDbConnection()
        Connection.ConnectionString = “Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cebal\OneDrive\Server-Side Web Development\db2(2)\db2\cis241db.mdb"
        Connection.Open()
        Command = Connection.CreateCommand()
        Command.CommandText = "Delete * from persontable where id=" + currentUser.PersonID + ";"


        Dim recordDeleted As Boolean = Command.ExecuteNonQuery() = 1
        Command.Dispose()
        Command = Nothing
        Connection.Close()
        Connection = Nothing

        DisplayMessage.Text = "Delete failed"
        If recordDeleted Then
            DisplayMessage.Text = "Record Deleted"
            Response.Redirect("MyPersonRecords.aspx", True)
        End If

    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Response.Redirect("MyPersonRecords.aspx", True)
    End Sub
End Class
