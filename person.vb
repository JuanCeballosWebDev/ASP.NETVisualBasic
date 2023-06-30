Imports Microsoft.VisualBasic
Imports System.Data


Public Class AddressTypeClass
    Public _id As String
    Public _Description As String

    Public ReadOnly Property id() As String
        Get
            Return _id
        End Get
    End Property
    Public ReadOnly Property Description() As String
        Get
            Return _Description
        End Get
    End Property
    Sub New(ByVal Reader As OleDb.OleDbDataReader)
        _id = Reader("id").ToString
        _Description = Reader("Description").ToString
    End Sub
End Class

Public Class personclass
    Public _id As String
    Public _firstname As String
    Public _lastname As String
    Public _citytown As String
    Public _state As String
    Public _zipcode As String
    Public _phonenumber As String
    Public _age As String
    Public _AddressType As String

    Public ReadOnly Property id() As String
        Get
            Return _id
        End Get
    End Property
    Public ReadOnly Property firstname() As String
        Get
            Return _firstname
        End Get
    End Property

    Public ReadOnly Property lastname() As String
        Get
            Return _lastname
        End Get
    End Property

    Public ReadOnly Property citytown() As String
        Get
            Return _citytown
        End Get
    End Property

    Public ReadOnly Property state() As String
        Get
            Return _state
        End Get
    End Property

    Public ReadOnly Property zipcode() As String
        Get
            Return _zipcode
        End Get
    End Property

    Public ReadOnly Property phonenumber() As String
        Get
            Return _phonenumber
        End Get
    End Property

    Public ReadOnly Property age() As String
        Get
            Return _age
        End Get
    End Property

    Public ReadOnly Property addressType() As String
        Get
            Return _AddressType
        End Get
    End Property


    Sub New(ByVal Reader As OleDb.OleDbDataReader)
        _id = Reader("id").ToString
        _firstname = Reader("firstname").ToString
        _lastname = Reader("lastname").ToString
        _citytown = Reader("citytown").ToString
        _state = Reader("state").ToString
        _zipcode = Reader("zipcode").ToString
        _phonenumber = Reader("phonenumber").ToString
        _age = Reader("age").ToString
        _AddressType = Reader("AddressType").ToString
    End Sub
End Class


Public Class Person
    Public firstName As String = ""
    Public lastName As String = ""
    Public phoneNumber As String = ""
    Public Age As String = ""
    Public Overrides Function toString() As String
        Return firstName + " " +
                lastName + " " +
                phoneNumber + " " +
                Age
    End Function

    Public Function isComplete() As Boolean

        If firstName.Length = 0 Then
            Throw New EntryMissingException("First name")
        End If
        If lastName.Length = 0 Then
            Throw New EntryMissingException("Last name")
        End If
        If phoneNumber.Length = 0 Then
            Throw New EntryMissingException("Phone number")
        End If
        If phoneNumber.Length < 10 Then
            Throw New EntryOutOfRangeException("Phone number")
        End If
        If Age.Length = 0 Then
            Throw New EntryMissingException("Age")
        End If
        If Not IsNumeric(Age) Then
            Throw New EntryHasBadTypeException("Age")
        End If
        If Integer.Parse(Age) < 0 Then
            Throw New EntryOutOfRangeException("Age")
        End If
        Return True
    End Function
End Class

Public Class EntryMissingException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class EntryHasBadTypeException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
Public Class EntryOutOfRangeException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
