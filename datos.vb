Public Class datos
    Private _client As String
    Private _code As Integer
    Private _product As String
    Private _price As Double
    Private _amoun As String

    Public Property Nombre As String
        Get
            Return _client
        End Get
        Set(value As String)
            _client = value
        End Set
    End Property

    Public Property Code As Integer
        Get
            Return _code
        End Get
        Set(value As Integer)
            _code = value
        End Set
    End Property

    Public Property Product As String
        Get
            Return _product
        End Get
        Set(value As String)
            _product = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
        End Set
    End Property

    Public Property Amount As String
        Get
            Return _amoun
        End Get
        Set(value As String)
            _amoun = value
        End Set
    End Property

End Class
