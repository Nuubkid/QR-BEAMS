Imports MySql.Data.MySqlClient

Module SETTINGS
    'Db strings
    Public _CONSTRING = "Server=Localhost;Database=qrc_beams;Uid=root;Pwd=;"
    Public _CONNECTION = New MySqlConnection(_CONSTRING)

    'button and panel colors
    Public BUTTONSHEX = "#003E51"
    Public PANNELHEX = "#152026"
    Public HEADERHEX = "#003E51"
    Public _BUTTONCOLOR As Color = ColorTranslator.FromHtml(BUTTONSHEX)
    Public _PANELCOLOR As Color = ColorTranslator.FromHtml(PANNELHEX)
    Public _HEADERCOLOR As Color = ColorTranslator.FromHtml(HEADERHEX)
End Module
