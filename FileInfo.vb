Public Class FileInfo

    Private _var_file_name As String = String.Empty
    Private _var_direcory_root As String = String.Empty
    Private _var_director_path As String = String.Empty
    Private _var_file_full_path As String = String.Empty
    Private _var_file_size As Long = 0
    Private _var_hash_type As HashType = HashType.None
    Private _var_file_hash As String = String.Empty
    Private _var_package_name As String = String.Empty

    'Private _progress As Integer

    ''' <summary>
    ''' Gibt den Dateinamen der Datei an.
    ''' </summary>

    Public Property FileName As String
        Set(value As String)
            _var_file_name = value
        End Set
        Get
            Return _var_file_name
        End Get
    End Property
    ''' <summary>
    ''' Gibt den Root Pfad der Datei an.
    ''' z.B REALESE.AC3-inD\CD1
    ''' </summary>
    Public Property DirectoryRoot As String
        Set(value As String)
            _var_direcory_root = value
        End Set
        Get
            Return _var_direcory_root
        End Get
    End Property
    ''' <summary>
    ''' Gibt den Ordner an im welchem die Datei liegt.
    ''' </summary>
    Public Property DirectoryPath As String
        Set(value As String)
            _var_director_path = value
        End Set
        Get
            Return _var_director_path
        End Get
    End Property
    ''' <summary>
    ''' Gibt den vollen Pfad der Datei zurück.
    ''' </summary>
    Public Property FileFullPath As String
        Set(value As String)
            _var_file_full_path = value
        End Set
        Get
            Return _var_file_full_path
        End Get
    End Property
    ''' <summary>
    ''' Gibt die Dateigröße in Bytes zurück.
    ''' </summary>
    Public Property FileSize As Long
        Set(value As Long)
            _var_file_size = value
        End Set
        Get
            Return _var_file_size
        End Get
    End Property

    Public Property FileHashType As HashType
        Set(value As HashType)
            _var_hash_type = value
        End Set
        Get
            Return _var_hash_type
        End Get
    End Property
    ''' <summary>
    ''' Gibt den MD5-Hash der Datei zurück.
    ''' </summary>
    ''' <remarks>Der Wert ist Optional und kann leer sein!</remarks>
    Public Property FileHash As String
        Set(value As String)
            _var_file_hash = value
        End Set
        Get
            Return _var_file_hash
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


    Public Enum HashType
        MD5
        CRC
        SHA1
        None
    End Enum

End Class
