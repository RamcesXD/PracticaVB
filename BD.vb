Module BD
    Public BD As New OleDb.OleDbConnection
    Public T As New DataSet
    Public Sql As String

    Friend Sub CONECTARBD()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\RUTA.udl"
        BD.ConnectionString = Ruta
        BD.Open()
    End Sub

    Friend Sub DESCONECTARBD()
        BD.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef TABLA As DataSet, ByVal SQL As String)
        'El metodo cargar_tabla hace consultas en la base de datos, Select'

        CONECTARBD()
        Dim Consulta As New OleDb.OleDbDataAdapter(SQL, BD)
        Consulta.Fill(TABLA)
        DESCONECTARBD()

        REM Ejemplo de un query
        REM SQL = SELECT ID FROM CATEGORIAS WHERE NOMBRE = '" & "ANDRES" & "'"
        REM cuando un valor sea varchar, utiliza comillas simples y comillas dobles
    End Sub

    Friend Sub EJECUTAR(ByVal SQL As String)
        'El metodo EJECUTAR hace todo lo demas en la base de datos, Delete/Update/Save'

        CONECTARBD()
        Dim Comando As New OleDb.OleDbCommand(SQL, BD)
        Comando.ExecuteNonQuery()
        DESCONECTARBD()

    End Sub

    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        'La funcion PK genera el numero del id, que es la llave primaria, pd: no entiendo muy bien esto' 

        T.Tables.Clear()
        Sql = "SELECT " & ID & " FROM " & TABLA
        ExamenParcial1byRancesArtavia       CARGAR_TABLA(T, Sql)

        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            Sql = "SELECT MAX(IDkid) FROM " & TABLA
            CARGAR_TABLA(T, Sql)
            PK = T.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If

    End Function

    Friend Sub INSERTAR_DATOS(ByVal TABLA As String, ByVal COLUMNAS As String, ByVal VALORES As String)
        Sql = "INSERT INTO " & TABLA & " (" & COLUMNAS & ") VALUES (" & VALORES & ")"
        EJECUTAR(Sql)

        MsgBox("Informacion guardada con exito!", vbInformation + vbOKOnly, "Guardado") 'esto muestra un mensaje en pantalla al usuario'
    End Sub

    Friend Sub CONSULTA_KIDS(ByVal TABLA As String, ByVal ID As Integer)

        T.Tables.Clear()
        PantallaConsulta.LISTA.Items.Clear()

        Sql = "select K.IDkid, K.kidFN Nombre, K.age Edad, S.schN Escuela, H.hbbN Pasatiempo 
               from kid K join school S on K.IDschool = S.IDschool join hobbie H on K.IDhobbie = H.IDhobbie where K.IDkid = " & ID & ""

        CARGAR_TABLA(T, Sql)

        If T.Tables(0).Rows.Count > 0 Then

            For FILAS As Integer = 0 To T.Tables(0).Rows.Count - 1
                PantallaConsulta.LISTA.Items.Add(T.Tables(0).Rows(FILAS).ItemArray(0))

                For COLUMNAS As Integer = 1 To T.Tables(0).Columns.Count - 1
                    PantallaConsulta.LISTA.Items(PantallaConsulta.LISTA.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILAS).ItemArray(COLUMNAS))

                Next
            Next
        End If

    End Sub

    Friend Sub BORRAR(ByVal TABLA As String, ByVal ID As String, ByVal PK As Integer)

        Sql = "delete from " & TABLA & " where " & ID & " = " & PK & ""
        EJECUTAR(Sql)
        MsgBox("Informacion borrada con exito!", vbOK, "Borrado")

    End Sub

    Friend Sub ACTUALIZAR(ByVal TABLA As String, ByVal COLUMNAS_DATOS As String, ByVal ID As String, ByVal PK As Integer)

        Sql = "update " & TABLA & " set " & COLUMNAS_DATOS & " where " & ID & " = " & PK & ""
        EJECUTAR(Sql)
        MsgBox("Informacion actualizada con exito!", vbOK, "Actualizado")

    End Sub

    Friend Sub OBTENER_IDS()

        Dim schoolSel As String = PantallaRegistro.cbEscuela.Text                'Todas estas lineas ante de la llamada del metodo INSERTAR DATOS funcionan para 
        Dim hbbSel As String = PantallaRegistro.cbPasatiempo.Text                'extraer el int de la escuela que seleccione el usuario

        Dim schoolPartes() As String = schoolSel.Split(" "c)    'split divide el string donde se guarda la escuela, en un arreglo y en la pocision 0
        Dim hbbPartes() As String = schoolSel.Split(" "c)       'es donde tengo los numeros de cada uno

    End Sub

    Friend Sub MOSTRAR_ESCUELAS()
        T.Tables.Clear()

        Sql = "SELECT CAST(IDschool AS VARCHAR)+ ' ' + schN AS ColumnaConcatenada FROM school;"
        CARGAR_TABLA(T, Sql)

        If T.Tables(0).Rows.Count > 0 Then

            For FILAS As Integer = 0 To T.Tables(0).Rows.Count - 1
                PantallaRegistro.cbEscuela.Items.Add(T.Tables(0).Rows(FILAS).ItemArray(0))
                For COLUMNAS As Integer = 1 To T.Tables(0).Columns.Count - 1
                    PantallaRegistro.cbEscuela.Items(PantallaRegistro.cbEscuela.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILAS).ItemArray(COLUMNAS))
                Next
            Next

        End If

    End Sub

    Friend Sub MOSTRAR_HOBBIES()

        T.Tables.Clear()

        Sql = "SELECT CAST(IDhobbie AS VARCHAR)+ ' ' + hbbN AS ColumnaConcatenada FROM hobbie;"
        CARGAR_TABLA(T, Sql)

        If T.Tables(0).Rows.Count > 0 Then

            For FILAS As Integer = 0 To T.Tables(0).Rows.Count - 1
                PantallaRegistro.cbPasatiempo.Items.Add(T.Tables(0).Rows(FILAS).ItemArray(0))

            Next

        End If

    End Sub

End Module
