Imports Microsoft.VisualBasic

Public Class ApplicationData
    Public Shared appDataObj As ApplicationData
    Public currentUsers As New Collections.Hashtable
End Class
Public Class UserData
    Public yourperson As Person
    Public CurrentUserName As String
    Public PersonID As String
    Sub New(ByVal CurrentUserName As String)
        Me.CurrentUserName = CurrentUserName
        yourperson = New Person
    End Sub
End Class



Public Class WebUtility
    Inherits System.Web.UI.Page

    Public currentUser As UserData
    Protected Overridable Sub iPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        currentUser = ApplicationData.appDataObj.currentUsers.Item(Session.SessionID)
    End Sub
End Class



