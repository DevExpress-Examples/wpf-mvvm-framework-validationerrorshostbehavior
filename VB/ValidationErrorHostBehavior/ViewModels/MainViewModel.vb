Imports DevExpress.Mvvm
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace ValidationErrorHostBehavior.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase
        Implements IDataErrorInfo

        Protected firstname_ As String

        <Required>
        <RegularExpression("^[a-zA-Z''-'\s]{1,40}$", ErrorMessage:="Characters are not allowed.")>
        Public Property FirstName As String
            Get
                Return firstname_
            End Get

            Set(ByVal value As String)
                SetProperty(firstname_, value, "FirstName")
            End Set
        End Property

        Protected lastname_ As String

        <Required>
        <RegularExpression("^[a-zA-Z''-'\s]{1,40}$", ErrorMessage:="Characters are not allowed.")>
        Public Property LastName As String
            Get
                Return lastname_
            End Get

            Set(ByVal value As String)
                SetProperty(lastname_, value, "LastName")
            End Set
        End Property

        Public ReadOnly Property [Error] As String Implements IDataErrorInfo.[Error]
            Get
                Return String.Join(";", Me("FirstName"), Me("LastName"))
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                Return IDataErrorInfoHelper.GetErrorText(Me, columnName)
            End Get
        End Property
    End Class
End Namespace
