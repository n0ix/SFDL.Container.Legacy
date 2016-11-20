Public Class SFDLFile

    Private _var_description As String = String.Empty
    Private _var_uploader As String = String.Empty
    Private _var_sfdl_file_version As Integer = 0
    Private _var_encrypted As Boolean = False
    Private _var_connectio_info As New ConnectionInfo
    Private _var_package_list As New List(Of SFDLPackage)

    Private _var_max_download_threads As Integer = 0

    ''' <summary>
    ''' Gibt die Beschreibung der SFDL Datei an.
    ''' </summary>
    Public Property Description As String
        Set(value As String)
            _var_description = value
        End Set
        Get
            Return _var_description
        End Get
    End Property
    ''' <summary>
    ''' Gibt den Upper an
    ''' </summary>
    Public Property Uploader As String
        Set(value As String)
            _var_uploader = value
        End Set
        Get
            Return _var_uploader
        End Get
    End Property
    ''' <summary>
    ''' Gibt die SFDL Datei Version zurück.
    ''' </summary>
    Public Property SFDLFileVersion As Integer
        Set(value As Integer)
            _var_sfdl_file_version = value
        End Set
        Get
            Return _var_sfdl_file_version
        End Get
    End Property
    Public Property Encrypted As Boolean
        Set(value As Boolean)
            _var_encrypted = value
        End Set
        Get
            Return _var_encrypted
        End Get
    End Property
    ''' <summary>
    ''' Gibt die FTP Verbindungsinformationen zurück.
    ''' </summary>
    Public Property ConnectionInfo As ConnectionInfo
        Set(value As ConnectionInfo)
            _var_connectio_info = value
        End Set
        Get
            Return _var_connectio_info
        End Get
    End Property
    ''' <summary>
    ''' Gibt die Liste mit allen Dateien zurück.
    ''' </summary>
    Public Property Packages As List(Of SFDLPackage)
        Set(value As List(Of SFDLPackage))
            _var_package_list = value
        End Set
        Get
            Return _var_package_list
        End Get
    End Property
    ''' <summary>
    ''' Gibt die Maximale Thread Anzahl zurück.
    ''' </summary>
    Public Property MaxDownloadThreads As Integer
        Set(value As Integer)
            _var_max_download_threads = value
        End Set
        Get
            Return _var_max_download_threads
        End Get
    End Property

End Class
