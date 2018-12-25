Namespace Commands
    Public Class CommandResponse

        Private _success As Boolean

        Public Shared OK As CommandResponse = New CommandResponse With {
            .Success = True
        }
        Public Shared Fail As CommandResponse = New CommandResponse With {
            .Success = False
        }

        Public Sub New(ByVal Optional success As Boolean = False)
            Me._success = success
        End Sub

        Public Property Success As Boolean
            Get
                Return _success
            End Get
            Set(value As Boolean)
                _success = value
            End Set
        End Property
    End Class
End Namespace

