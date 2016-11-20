Public Class SFDLPackage

    Private _var_package_name As String = String.Empty
    Private _var_file_list As List(Of FileInfo)
    Private _var_bfd_mode As Boolean = False  'BFD = Bulk Folder Download
    Private _var_bfd_list As List(Of BulkFolder)

    Public Property Packagename As String
        Set(value As String)
            _var_package_name = value
        End Set
        Get
            Return _var_package_name
        End Get
    End Property

    Public Property FileList As List(Of FileInfo)
        Set(value As List(Of FileInfo))
            _var_file_list = value
        End Set
        Get
            Return _var_file_list
        End Get
    End Property

    Public Property BulkFolderMode As Boolean
        Set(value As Boolean)
            _var_bfd_mode = value
        End Set
        Get
            Return _var_bfd_mode
        End Get
    End Property

    Public Property BulkFolderList As List(Of BulkFolder)
        Set(value As List(Of BulkFolder))
            _var_bfd_list = value
        End Set
        Get
            Return _var_bfd_list
        End Get
    End Property

End Class
