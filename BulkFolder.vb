Public Class BulkFolder

    Private _var_bulk_folder_path As String
    Private _var_package_name As String

    Public Property BulkFolderPath As String
        Set(value As String)
            _var_bulk_folder_path = value
        End Set
        Get
            Return _var_bulk_folder_path
        End Get
    End Property

    Public Property PackageName As String
        Set(value As String)
            _var_package_name = value
        End Set
        Get
            Return _var_package_name
        End Get
    End Property


End Class
