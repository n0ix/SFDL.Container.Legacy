Public Class ConnectionInfo

    Private _var_name As String = String.Empty
    Private _var_host As String = String.Empty
    Private _var_port As Integer = 0
    Private _var_path As String = String.Empty
    Private _var_username As String = String.Empty
    Private _var_password As String = String.Empty
    Private _var_auth_required As Boolean = False
    Private _var_connection_type As FTPDataConnectionType = FTPDataConnectionType.AutoPassive
    Private _var_data_type As FTPDataType = FTPDataType.Binary
    Private _var_character_encoding As CharacterEncoding.CharacterEncoding = Legacy.CharacterEncoding.CharacterEncoding.Standard
    Private _var_encryption_mode As FTPEncryptionMode = FTPEncryptionMode.None
    Private _var_list_method As FTPListOption = FTPListOption.NameList
    Private _force_single_connection As Boolean = False
    Private _data_stale_detection As Boolean = True
    Private _special_server_mode As Boolean = False


    ''' <summary>
    ''' Host/IP-Addresse des FTP-Servers
    ''' </summary>
    Public Property Host As String
        Set(value As String)
            _var_host = value
        End Set
        Get
            Return _var_host
        End Get
    End Property
    ''' <summary>
    ''' Port des FTP-Servers
    ''' </summary>
    Public Property Port As Integer
        Set(value As Integer)
            _var_port = value
        End Set
        Get
            Return _var_port
        End Get
    End Property

    ''' <summary>
    ''' Benutzername zum herstellen der FTP-Verbindung
    ''' </summary>
    Public Property Username As String
        Set(value As String)
            _var_username = value
        End Set
        Get
            Return _var_username
        End Get
    End Property
    ''' <summary>
    ''' Passwort zum herstellen der FTP-Verbindung
    ''' </summary>
    Public Property Password As String
        Set(value As String)
            _var_password = value
        End Set
        Get
            Return _var_password
        End Get
    End Property
    ''' <summary>
    ''' Gibt an ob eine Anmeldung benötigt wird.
    ''' </summary>
    Public Property AuthRequired As Boolean
        Set(value As Boolean)
            _var_auth_required = value
        End Set
        Get
            Return _var_auth_required
        End Get
    End Property
    ''' <summary>
    ''' Gibt an ob welcher TransferModus benutzt wird. (Active or Passive)
    ''' </summary>
    Public Property DataConnectionType As FTPDataConnectionType
        Set(value As FTPDataConnectionType)
            _var_connection_type = value
        End Set
        Get
            Return _var_connection_type
        End Get
    End Property
    ''' <summary>
    ''' Gibt an ob welcher TransferType benutzt wird. (Binary or ASCII)
    ''' </summary>
    Public Property DataType As FTPDataType
        Set(value As FTPDataType)
            _var_data_type = value
        End Set
        Get
            Return _var_data_type
        End Get
    End Property
    ''' <summary>
    ''' Gibt an das Encoding an.
    ''' </summary>
    Public Property CharacterEncoding As CharacterEncoding.CharacterEncoding
        Set(value As CharacterEncoding.CharacterEncoding)
            _var_character_encoding = value
        End Set
        Get
            Return _var_character_encoding
        End Get
    End Property
    ''' <summary>
    ''' Gibt an ob und welche Verschlüsselung benutzt wird.
    ''' </summary>
    ''' <remarks>Nicht Implementiert!</remarks>
    Public Property EncryptionMode As FTPEncryptionMode
        Set(value As FTPEncryptionMode)
            _var_encryption_mode = value
        End Set
        Get
            Return _var_encryption_mode
        End Get
    End Property

    Public Property ListMethod As FTPListOption
        Set(value As FTPListOption)
            _var_list_method = value
        End Set
        Get
            Return _var_list_method
        End Get
    End Property

    Public Property DefaultPath As String
        Set(value As String)
            _var_path = value
        End Set
        Get
            Return _var_path
        End Get
    End Property

    Public Property ForceSingleConnection As Boolean
        Set(value As Boolean)
            _force_single_connection = value
        End Set
        Get
            Return _force_single_connection
        End Get
    End Property

    Public Property DataStaleDetection As Boolean
        Set(value As Boolean)
            _data_stale_detection = value
        End Set
        Get
            Return _data_stale_detection
        End Get
    End Property

    Public Property SpecialServerMode As Boolean
        Set(value As Boolean)
            _special_server_mode = value
        End Set
        Get
            Return _special_server_mode
        End Get
    End Property

End Class
