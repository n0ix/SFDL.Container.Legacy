Public Enum FTPListOption
    <Xml.Serialization.XmlEnum("default")>
    NameList = 0
    Modify = 1
    Size = 2
    SizeModify = 3
    AllFiles = 4
    ForceList = 5
    ForceNameList = 6
    DerefLinks = 7
    UseLS = 8
    Recursive = 9
    <Xml.Serialization.XmlEnum("")>
    DefaultAlias = NameList
End Enum