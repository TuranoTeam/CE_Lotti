Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGanttView
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinSchedule
Imports Infragistics.Win.UltraWinTabControl

Public Class Lotti
    Dim CommessaAttiva As String
    Private GanttProject As Project
    Private Const ProjectKey As String = "Gantt"
    Dim Colore As System.Drawing.Color
    Dim ColorePianificata As System.Drawing.Color = Nothing
    Dim ColoreFinita As System.Drawing.Color = Nothing
    Dim ColoreIniziata As System.Drawing.Color = Nothing
    Dim ColoreOltre As System.Drawing.Color = Nothing
    Dim WithEvents UG As New UltraGrid
    Dim WithEvents CI As New UltraCalendarInfo
    Dim TtmConfigurazioneGeneraleDR As LottiDataSet.TtmConfigurazioneGeneraleRow
    Dim GantPDT As New DataTable("GantP")
    Dim Iniziata As String = "Iniziata"
    Dim Lotto As String = ""
    Private LottoTask As Task
    Private AttivitaChildTask As Task
    Private AttivitaChildTaskPrecedente As Task


    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub Lotti_Load(sender As Object, e As EventArgs) Handles Me.Load

        TtmConfigurazioneGeneraleTableAdapter.Fill(LottiDataSet.TtmConfigurazioneGenerale)
        TtmConfigurazioneGeneraleDR = LottiDataSet.TtmConfigurazioneGenerale.NewTtmConfigurazioneGeneraleRow
        TtmConfigurazioneGeneraleDR.ItemArray = LottiDataSet.TtmConfigurazioneGenerale.Rows(0).ItemArray
        ColorePianificata = TtmConvertColorToARGB(NxaNvl(TtmConfigurazioneGeneraleDR.CngeColoreAttivitaPianificata))
        ColoreFinita = TtmConvertColorToARGB(NxaNvl(TtmConfigurazioneGeneraleDR.CngeColoreAttivitaFinita))
        ColoreIniziata = TtmConvertColorToARGB(NxaNvl(TtmConfigurazioneGeneraleDR.CngeColoreAttivitaIniziata))
        ColoreOltre = TtmConvertColorToARGB(NxaNvl(TtmConfigurazioneGeneraleDR.CngeColoreAttivitaOltre))

        ugbDataFine.Text = "Data Fine"
        ugbDataInizio.Text = "Data Inizio"
        ugbSpostamento.Text = "Spostamento"
        ugbPercComp.Text = "Completamento"

        numStartDay.Value = 1
        numEndDay.Value = 1
        numPercComp.Value = 1
        numActivityDay.Value = 7

        numStartDay.FormatString = "###"
        numStartDay.Appearance.TextHAlign = HAlign.Center

        numEndDay.FormatString = "###"
        numEndDay.Appearance.TextHAlign = HAlign.Center

        numPercComp.FormatString = "###"
        numPercComp.Appearance.TextHAlign = HAlign.Center

        numActivityDay.FormatString = "###"
        numActivityDay.Appearance.TextHAlign = HAlign.Center

        btnPercCompPiu.Text = "+"
        btnPercCompMeno.Text = "-"
        btnEndPiu.Text = "+"
        btnEndMeno.Text = "-"
        btnActivityPiu.Text = "+"
        btnActivityMeno.Text = "-"
        btnStartPiu.Text = "+"
        StartMeno.Text = "-"

        ImpostazioniControlli()
        ImpostazioneToolBar()
        T058_Commesse_aperteTableAdapter.Fill(Me.LottiDataSet.T058_Commesse_aperte)
        CreateTasks()
        CreateProject()
    End Sub

    Private Sub LeggiLotti(commessa As String)
        Dim DT As DataTable
        DT = T059_Lotti_SelezionaTableAdapter.GetData(commessa, Environ("Username"))
        TmpLottiTableAdapter.Fill(LottiDataSet.tmpLotti, Environ("Username"))
        ngrdT059_Lotti2.DataSource = LottiDataSet.tmpLotti

        T059_LottiTableAdapter.Fill(LottiDataSet.T059_Lotti, commessa, Environ("USERNAME"))
        TmpLottiTableAdapter.Fill(LottiDataSet.tmpLotti, Environ("USERNAME"))

        T074_LottiDettaglioTableAdapter.Fill(LottiDataSet.T074_LottiDettaglio, commessa)
        T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter.Fill(LottiDataSet.T058_Commesse_Totale_Ore_Lotti_Selezionati, Environ("USERNAME"))
        T058_Commesse_Totale_OreTableAdapter.Fill(LottiDataSet.T058_Commesse_Totale_Ore, commessa)

        'usGantt.Collapsed = True

    End Sub

    Private Sub ngrdCommesse_AfterRowActivate(sender As Object, e As EventArgs) Handles ngrdCommesse.AfterRowActivate
        If ngrdCommesse.ActiveRow IsNot Nothing AndAlso ngrdCommesse.ActiveRow.IsDataRow Then
            Me.Text = ngrdCommesse.ActiveRow.Cells("t058commessa").Text.Trim & " - " & ngrdCommesse.ActiveRow.Cells("t055RagioneSociale").Text
            CommessaAttiva = ngrdCommesse.ActiveRow.Cells("t058commessa").Text
            LeggiLotti(CommessaAttiva)
            GantPDT = TableAdapterGantP.GetData(Environ("Username"))

            Lotto = ""
            CreateTasks()
            ImpostaGrigliaGant(UG)
        End If
    End Sub
    Private Sub ngrdT059_Lotti2_CellChange(sender As Object, e As CellEventArgs) Handles ngrdT059_Lotti2.CellChange
        Dim DT As DataTable
        DT = T059_Lotto_SelezionaTableAdapter.GetData(ngrdT059_Lotti2.ActiveRow.Cells("Lotto").Value.ToString, Environ("Username"))
        T059_LottiTableAdapter.Fill(LottiDataSet.T059_Lotti, CommessaAttiva, Environ("USERNAME"))
        T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter.Fill(LottiDataSet.T058_Commesse_Totale_Ore_Lotti_Selezionati, Environ("USERNAME"))
    End Sub

    Private Sub UtbManager_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UTBManager.ToolClick
        Select Case e.Tool.Key
            Case "ButtonTool1"
                Me.Close()
            Case "ButtonTool2"
                MsgBox("btn2")
            Case "ButtonTool3"
                MsgBox("btn3")
        End Select
    End Sub
    Private Sub ImpostazioniControlli()
        Dim VisiblePosition As Integer = 0
        Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath.Replace("bin\Debug", "Resources") & "\CE.isl")

        ' tacamia
        TtmConfigurazioneGrigliaTableAdapter.Fill(LottiDataSet.TtmConfigurazioneGriglia, 0, "T059_Lotti", "BLACK", "")
        T108_UfficiTableAdapter.Fill(LottiDataSet.T108_Uffici, 0, 1, 1)

        Dim Colore As System.Drawing.Color
        For Each RwGr As LottiDataSet.TtmConfigurazioneGrigliaRow In LottiDataSet.TtmConfigurazioneGriglia.Rows
            If Not RwGr.IsCngrTraduzioneNull AndAlso RwGr.CngrTraduzione.Trim.Length > 0 Then
                If ngrdT059_Lotti.DisplayLayout.Bands(0).Columns.Exists(RwGr.CngrNomeColonna.Trim) Then
                    ngrdT059_Lotti.DisplayLayout.Bands(0).Columns(RwGr.CngrNomeColonna.Trim).Header.Caption = RwGr.CngrTraduzione
                End If
            End If
            If Not RwGr.IsCngrUfficioNull Then
                For Each rwcol As LottiDataSet.T108_UfficiRow In LottiDataSet.T108_Uffici.Select("T108Id=" & RwGr.CngrUfficio)

                    If Not rwcol.IsT108ColoreNull Then
                        Colore = TtmConvertColorToARGB(rwcol.T108Colore)
                        If ngrdT059_Lotti.DisplayLayout.Bands(0).Columns.Exists(RwGr.CngrNomeColonna.Trim) Then
                            ngrdT059_Lotti.DisplayLayout.Bands(0).Columns(RwGr.CngrNomeColonna.Trim).Header.Appearance.BackColor = Colore
                        End If
                    End If
                Next
            End If
        Next

        For Each rwcol As LottiDataSet.T108_UfficiRow In LottiDataSet.T108_Uffici.Rows
            Colore = TtmConvertColorToARGB(rwcol.T108Colore)
            If rwcol.T108Id = 7 Then
                ulUfficio7.Appearance.BackColor = Colore
            End If
            'If rwcol.T108Id = 8 Then
            '    ulUfficio8.Appearance.BackColor = Colore
            'End If
            If rwcol.T108Id = 9 Then
                ulUfficio9.Appearance.BackColor = Colore
            End If
            If rwcol.T108Id = 10 Then
                ulUfficio10.Appearance.BackColor = Colore
            End If
            'If rwcol.T108Id = 11 Then
            '    ulUfficio11.Appearance.BackColor = Colore
            'End If
            'If rwcol.T108Id = 12 Then
            '    ulUfficio12.Appearance.BackColor = Colore
            'End If
            If rwcol.T108Id = 13 Then
                ulUfficio13.Appearance.BackColor = Colore
            End If
            'If rwcol.T108Id = 14 Then
            '    ulUfficio14.Appearance.BackColor = Colore
            'End If
            'If rwcol.T108Id = 15 Then
            '    ulUfficio15.Appearance.BackColor = Colore
            'End If
            If rwcol.T108Id = 16 Then
                ulUfficio16.Appearance.BackColor = Colore
            End If
            If rwcol.T108Id = 17 Then
                ulUfficio17.Appearance.BackColor = Colore
            End If
            If rwcol.T108Id = 18 Then
                ulUfficio18.Appearance.BackColor = Colore
            End If
        Next

        ulPianificata.Appearance.BackColor = ColorePianificata
        ulIniziata.Appearance.BackColor = ColoreIniziata
        UlFinita.Appearance.BackColor = ColoreFinita
        ulOltre.Appearance.BackColor = ColoreOltre
        ' al pet li

        ngrdCommesse.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
        ngrdCommesse.DisplayLayout.Override.AllowColSwapping = False
        ngrdCommesse.Text = "Commesse Aperte"
        ngrdCommesse.DisplayLayout.Bands(0).ColHeadersVisible = False
        ngrdCommesse.DisplayLayout.Bands(0).Columns("t058commessa").Width = 60

        'ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * ngrdT059_Lotti * 
        ngrdT059_Lotti.Text = ""
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059IdLotto").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Commessa").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059InsertUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059InsertDate").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UpdateUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UpdateDate").Hidden = True

        VisiblePosition = 0
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Width = 30
        '      
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataConsegna").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataConsegna").Width = 80
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataConsegna").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Sede").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Sede").Width = 120
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataChiusura").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataChiusura").Width = 80
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataChiusura").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Note").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Note").Width = 120
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059LavorazioniEsterne").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059LavorazioniEsterne").Width = 80
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059NoteUfficioIndustrializzazione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059NoteUfficioIndustrializzazione").Width = 200
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataAggiornamentoOre").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataAggiornamentoOre").Width = 140
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DataAggiornamentoOre").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UtenteAggiornamentoOre").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UtenteAggiornamentoOre").Width = 200
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Consegna").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Consegna").Width = 200
        '
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DescrizioneLotto").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DescrizioneLotto").Width = 200
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059DescrizioneLotto").Header.Caption = "Descrizione"
        '      
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Colonne").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Colonne").Width = 80

        'ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * 

        ngrdT059_Lotti2.Text = ""
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Lotto").Width = 30
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Selezionato").Width = 20
        ngrdT059_Lotti2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        ngrdT059_Lotti2.DisplayLayout.Override.AllowColSwapping = AllowColSwapping.NotAllowed

        'ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * 

        ngrdT059_Lotti3.Text = "Totali Ore  Lotti Selezionati"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("T074Centro").Header.Caption = "Centro"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("T074Centro").Width = 60
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Preventivo").Header.Caption = "Preventivo"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Preventivo").Width = 100
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Obbiettivo").Header.Caption = "Obbiettivo"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Obbiettivo").Width = 100
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Esterne").Header.Caption = "Ore Esterne"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Esterne").Width = 100
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Consuntivo").Header.Caption = "Consuntivo"
        ngrdT059_Lotti3.DisplayLayout.Bands(0).Columns("Consuntivo").Width = 100

        'ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * ngrdT059_Lotti4 * 

        ngrdT059_Lotti4.Text = "Totale Ore Commessa"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("T074Centro").Header.Caption = "Centro"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("T074Centro").Width = 60
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Preventivo").Header.Caption = "Preventivo"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Preventivo").Width = 100
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Obbiettivo").Header.Caption = "Obbiettivo"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Obbiettivo").Width = 100
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Esterne").Header.Caption = "Ore Esterne"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Esterne").Width = 100
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Consuntivo").Header.Caption = "Consuntivo"
        ngrdT059_Lotti4.DisplayLayout.Bands(0).Columns("Consuntivo").Width = 100

    End Sub
    Private Sub ImpostazioneToolBar()
        UTBManager.Toolbars(0).Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False
        UTBManager.Toolbars(0).Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.False
        UTBManager.Toolbars(0).Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False
        UTBManager.Toolbars(0).Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False
        UTBManager.Toolbars(0).Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False
        UTBManager.Toolbars(0).Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.False
        'UTBManager.Toolbars(0).Tools(0).CustomizedDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        'UTBManager.Toolbars(0).Tools(1).CustomizedDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        'UTBManager.Toolbars(0).Tools(2).CustomizedDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText

        UTBManager.Toolbars(0).Tools(0).CustomizedCaption = "Uscita"
        UTBManager.Toolbars(0).Tools(1).CustomizedCaption = "funz2"
        UTBManager.Toolbars(0).Tools(2).CustomizedCaption = "funz3"

    End Sub
    Public Shared Function TtmConvertColorToARGB(colorstring As String) As System.Drawing.Color
        Return TtmConvertColorToARGB(colorstring, 0, 0, 0, 0)
    End Function
    Public Shared Function TtmConvertColorToARGB(colorstring As String, ByRef A As Integer, ByRef R As Integer, ByRef G As Integer, ByRef B As Integer) As System.Drawing.Color

        If colorstring.Trim.Length > 8 Then
            If colorstring.Substring(0, 9) = "Color [A=" Then
                A = CInt(colorstring.Substring(colorstring.IndexOf("A=") + 2, colorstring.IndexOf(",", colorstring.IndexOf("A=")) - (colorstring.IndexOf("A=") + 2)))
                R = CInt(colorstring.Substring(colorstring.IndexOf("R=") + 2, colorstring.IndexOf(",", colorstring.IndexOf("R=")) - (colorstring.IndexOf("R=") + 2)))
                G = CInt(colorstring.Substring(colorstring.IndexOf("G=") + 2, colorstring.IndexOf(",", colorstring.IndexOf("G=")) - (colorstring.IndexOf("G=") + 2)))
                B = CInt(colorstring.Substring(colorstring.IndexOf("B=") + 2, colorstring.IndexOf("]", colorstring.IndexOf("B=")) - (colorstring.IndexOf("B=") + 2)))

                Return System.Drawing.Color.FromArgb(A, R, G, B)
            Else
                Return System.Drawing.Color.FromName(colorstring.Replace("Color [", "").Replace("]", ""))
            End If

        End If

    End Function
    Private Function SetVisiblePosition(ByRef position As Integer) As Integer
        position += 1
        Return position
    End Function

    Public Shared Function NxaNvl(ByVal wStringa As Object) As String
        If IsDBNull(wStringa) OrElse wStringa Is Nothing Then
            NxaNvl = ""
        Else
            NxaNvl = wStringa.ToString
        End If
    End Function

    Public Shared Function NxaNvlNum(ByVal wNum As Object) As Object
        If IsDBNull(wNum) OrElse wNum Is Nothing OrElse (TypeOf (wNum) Is String AndAlso CStr(wNum).Trim.Length = 0) Then
            NxaNvlNum = 0
        Else
            NxaNvlNum = wNum
        End If
    End Function

    ' daqui

    Private Sub CreateTasks()
        UltraCalendarInfo1.Tasks.Clear()
        UltraCalendarInfo1.CustomTaskColumns.Clear()
        UltraGanttView1.GridSettings.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Constraint).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.ConstraintDateTime).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.PercentComplete).Visible = DefaultableBoolean.True
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Deadline).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Milestone).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Dependencies).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Duration).Visible = DefaultableBoolean.True
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.EndDateTime).Visible = DefaultableBoolean.True
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Name).Visible = DefaultableBoolean.True
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Notes).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.Resources).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.RowNumber).Visible = DefaultableBoolean.False
        UltraGanttView1.GridSettings.ColumnSettings(TaskField.StartDateTime).Visible = DefaultableBoolean.True
        UltraCalendarInfo1.CustomTaskColumns.Add("Colore", GetType([String]), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("NA", GetType(Boolean), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("Iniziata", GetType(Boolean), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("Finita", GetType(Boolean), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("IdGant", GetType(Integer), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("Durata", GetType(Integer), False)
        UltraCalendarInfo1.CustomTaskColumns.Add("IsLotto", GetType(Boolean), False)
        CaricaDati()
        UltraGanttView1.TimelineSettings.ColumnWidth = 10
    End Sub
    Private Sub CreateProject()
        GanttProject = UltraCalendarInfo1.Projects.Add("GanttProject", Today.AddDays(-14))
        GanttProject.Key = ProjectKey
        UltraGanttView1.CalendarInfo = UltraCalendarInfo1
        UltraGanttView1.CalendarInfo.ActiveDay = UltraGanttView1.CalendarInfo.GetDay(DateTime.Today, True)
        UltraGanttView1.Project = UltraGanttView1.CalendarInfo.Projects(1)
        UltraGanttView1.TaskSettings.AllowEditDuration = DefaultableBoolean.True

        UG = CType(Me.UltraGanttView1.[GetType]().GetField("grid", System.Reflection.BindingFlags.CreateInstance Or System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic).GetValue(Me.UltraGanttView1), UltraGrid)
    End Sub
    Private Sub ImpostaGrigliaGant(ByRef grigliagant As UltraGrid)

        grigliagant.DisplayLayout.Override.RowSelectors = DefaultableBoolean.False

        grigliagant.DisplayLayout.Bands(0).Columns("NA").Header.VisiblePosition = 0
        grigliagant.DisplayLayout.Bands(0).Columns("NA").Width = 25

        grigliagant.DisplayLayout.Bands(0).Columns("Name").Header.VisiblePosition = 1
        grigliagant.DisplayLayout.Bands(0).Columns("Name").Header.Caption = "Lotto" & vbCrLf & "Att.tà"
        grigliagant.DisplayLayout.Bands(0).Columns("Name").Width = 68

        grigliagant.DisplayLayout.Bands(0).Columns("StartDateTime").Header.VisiblePosition = 2
        grigliagant.DisplayLayout.Bands(0).Columns("StartDateTime").Header.Caption = "Inizio"
        grigliagant.DisplayLayout.Bands(0).Columns("StartDateTime").Width = 80

        grigliagant.DisplayLayout.Bands(0).Columns("Iniziata").Header.VisiblePosition = 3
        grigliagant.DisplayLayout.Bands(0).Columns("Iniziata").Header.Caption = "I."
        grigliagant.DisplayLayout.Bands(0).Columns("Iniziata").Header.ToolTipText = "Attività Iniziata"
        grigliagant.DisplayLayout.Bands(0).Columns("Iniziata").Width = 25

        grigliagant.DisplayLayout.Bands(0).Columns("EndDateTime").Header.VisiblePosition = 4
        grigliagant.DisplayLayout.Bands(0).Columns("EndDateTime").Header.Caption = "Fine"
        grigliagant.DisplayLayout.Bands(0).Columns("EndDateTime").Width = 80

        grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.VisiblePosition = 5
        grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.Caption = "F."
        grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.ToolTipText = "Attività Finita"
        grigliagant.DisplayLayout.Bands(0).Columns("Finita").Width = 25

        'grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.VisiblePosition = 5
        'grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.Caption = "F."
        'grigliagant.DisplayLayout.Bands(0).Columns("Finita").Header.ToolTipText = "Attività Finita"
        'grigliagant.DisplayLayout.Bands(0).Columns("Finita").Width = 25

        grigliagant.DisplayLayout.Bands(0).Columns("Duration").Header.VisiblePosition = 6
        grigliagant.DisplayLayout.Bands(0).Columns("Duration").Header.Caption = "Durata"

        grigliagant.DisplayLayout.Bands(0).Columns("Colore").Hidden = True

        grigliagant.DisplayLayout.Bands(0).Columns("IdGant").Hidden = True

        grigliagant.DisplayLayout.Bands(0).Columns("Durata").Hidden = True

        grigliagant.DisplayLayout.Bands(0).Columns("IsLotto").Hidden = True

        UltraGanttView1.GridAreaWidth = 0
        For Each c As UltraGridColumn In grigliagant.DisplayLayout.Bands(0).Columns
            If Not c.Hidden Then UltraGanttView1.GridAreaWidth = UltraGanttView1.GridAreaWidth + c.Width
        Next
        UltraGanttView1.GridAreaWidth = UltraGanttView1.GridAreaWidth - 8

        'If Not NxaCore.NxaCommon.NxaVars.NxaInDesignTime Then
        '    BuildContextMenu()
        'End If

        ImpostaColore(UG)

    End Sub
    Private Sub CaricaDati()
        Dim F1 As String
        Dim F2 As String
        Dim G As String = ""

        If GantPDT.Rows.Count = 0 Then Exit Sub

        If uceAttivitaNA.Checked Then
            If uceAttivitaFinite.Checked Then
                F1 = "T072NonApplicabile IN (0,-1)"
                F2 = "T072F IN (0,-1)"
            Else
                F1 = "T072NonApplicabile IN (0,-1)"
                F2 = "T072F IN (0)"
            End If
        Else
            If uceAttivitaFinite.Checked Then
                F1 = "T072NonApplicabile IN (0)"
                F2 = "T072F IN (0,-1)"
            Else
                F1 = "T072NonApplicabile IN (0)"
                F2 = "T072F IN (0)"
            End If
        End If
        G = F1 & " AND " & F2
        Dim rows As DataRow() = GantPDT.Select(G, "Lotto , T073Sequenza")
        For i As Integer = 0 To rows.Length - 1
            If rows(i)("Lotto").ToString <> Lotto Then
                LottoTask = New Task
                LottoTask = UltraCalendarInfo1.Tasks.Add(CDate(rows(i)("DataInizioLotto").ToString), TimeSpan.FromDays(6), rows(i)("Lotto").ToString, ProjectKey)
                LottoTask.SetCustomProperty("Durata", 1)
                LottoTask.SetCustomProperty("IsLotto", True)
                Lotto = rows(i)("Lotto").ToString
            End If
            AttivitaChildTask = New Task

            AttivitaChildTask = LottoTask.Tasks.Add(CDate(rows(i)("DataInizioAttivita").ToString), TimeSpan.FromDays(CInt(rows(i)("DD").ToString)), TimeSpanFormat.Days, rows(i)("Attivita").ToString)
            If CDec(rows(i)("Preventivo")) > 0 Then
                If CDec(rows(i)("Consuntivo")) > 0 Then
                    If CDec(rows(i)("Preventivo")) < CDec(rows(i)("Consuntivo")) Then
                        AttivitaChildTask.PercentComplete = 100
                    Else
                        AttivitaChildTask.PercentComplete = CDec((100 * CDec(rows(i)("Consuntivo"))) / CDec(rows(i)("Preventivo")))
                    End If
                End If
            End If

            AttivitaChildTask.SetCustomProperty("Colore", rows(i)("T108Colore").ToString)
            AttivitaChildTask.SetCustomProperty("NA", CInt(rows(i)("T072NonApplicabile").ToString))
            AttivitaChildTask.SetCustomProperty("Iniziata", CInt(rows(i)("T072I").ToString))
            AttivitaChildTask.SetCustomProperty("Finita", CInt(rows(i)("T072F").ToString))
            AttivitaChildTask.SetCustomProperty("IdGant", CInt(rows(i)("T072Id").ToString))
            AttivitaChildTask.SetCustomProperty("Durata", CInt(rows(i)("Durata").ToString))
            If CInt(rows(i)("Durata")) <> 0 Then AttivitaChildTask.TimelineSettings.AllowedDragActions = BarDragActions.StartDateTime
            AttivitaChildTask.SetCustomProperty("IsLotto", False)
            AttivitaChildTask.TimelineSettings.BarSettings.BarAppearance.BackColor = ColorePianificata
            If CBool(CInt(rows(i)("T072I"))) Then AttivitaChildTask.TimelineSettings.BarSettings.BarAppearance.BackColor = ColoreIniziata
            If CBool(CInt(rows(i)("T072F"))) Then AttivitaChildTask.TimelineSettings.BarSettings.BarAppearance.BackColor = ColoreFinita
            If CBool(CInt(rows(i)("T072NonApplicabile"))) Then AttivitaChildTask.TimelineSettings.BarSettings.BarAppearance.BackColor = System.Drawing.Color.Transparent
            AttivitaChildTask.TimelineSettings.BarSettings.BarHeight = 100
            AttivitaChildTaskPrecedente = AttivitaChildTask
        Next

        ImpostaColore(UG)

    End Sub
    Private Sub uceAttivitaNA_CheckedChanged(sender As Object, e As EventArgs) Handles uceAttivitaNA.CheckedChanged
        Lotto = ""
        CreateTasks()
        ImpostaGrigliaGant(UG)
        'CreateProject()
    End Sub
    Private Sub uceAttivitaFinite_CheckedChanged(sender As Object, e As EventArgs) Handles uceAttivitaFinite.CheckedChanged
        Lotto = ""
        CreateTasks()
        ImpostaGrigliaGant(UG)
        'CreateProject()
    End Sub
    Private Sub ImpostaColore(ByRef grigliagant As UltraGrid)
        For Each rg As Infragistics.Win.UltraWinGrid.UltraGridRow In grigliagant.Rows
            Colore = TtmConvertColorToARGB(NxaNvl(rg.Cells("Colore").Value))
            rg.Cells("Name").Appearance.BackColor = Colore
            rg.Cells("Name").Appearance.TextHAlign = HAlign.Left
            rg.Cells("Name").Activation = Activation.ActivateOnly
            If Not IsDBNull(rg.Cells("NA").Value) AndAlso CBool(rg.Cells("NA").Value) Then ImpostaNA(rg, True)
            rg.Cells("Duration").Hidden = CInt(rg.Cells("Durata").Value) = 1 Or Not IsDBNull(rg.Cells("NA").Value) AndAlso CBool(rg.Cells("NA").Value)
            rg.Cells("NA").Hidden = CBool(rg.Cells("Islotto").Value)
            rg.Cells("Iniziata").Hidden = CBool(rg.Cells("Islotto").Value)
            rg.Cells("Finita").Hidden = CBool(rg.Cells("Islotto").Value)
        Next
    End Sub
    Private Sub ImpostaNA(ByRef r As UltraGridRow, X As Boolean)
        r.Cells("Duration").Hidden = X
        If Not r.Cells("Duration").Hidden Then r.Cells("Duration").Hidden = CInt(r.Cells("Durata").Value) = 1
        r.Cells("Iniziata").Hidden = X
        r.Cells("Finita").Hidden = X
        r.Cells("StartDateTime").Hidden = X
        r.Cells("EndDateTime").Hidden = X
    End Sub
    Private Sub UltraGanttView1_TimelineVisibleDateTimeRangeChanged(sender As Object, e As VisibleDateTimeRangeChangedEventArgs)
        For Each rg As Infragistics.Win.UltraWinGrid.UltraGridRow In UG.Rows
            ImpostaAllarmi(rg, e.VisibleDateTimeRange.StartDateTime, e.VisibleDateTimeRange.EndDateTime)
        Next
    End Sub
    Private Sub ImpostaAllarmi(ByRef rg As UltraGridRow, sdt As Date, edt As Date)
        rg.Cells("StartDateTime").Appearance.BackColor = rg.Cells("Duration").Appearance.BackColor
        rg.Cells("EndDateTime").Appearance.BackColor = rg.Cells("Duration").Appearance.BackColor
        If Not IsDBNull(rg.Cells("NA").Value) AndAlso Not CBool((rg.Cells("NA").Value)) Then
            If Not CBool(rg.Cells("Finita").Value) Then
                If CDate(rg.Cells("EndDatetime").Value) < sdt Then rg.Cells("StartDateTime").Appearance.BackColor = ColoreOltre
                If CDate(rg.Cells("StartDatetime").Value) > edt Then rg.Cells("EndDateTime").Appearance.BackColor = ColoreOltre
            End If
        End If
    End Sub

    Private Sub SalvaModificheGant()
        If GantPDT.GetChanges IsNot Nothing Then
            ' T072_GantPTableAdapter.Connection = TtmConnection
            T072_GantPTableAdapter.Fill(LottiDataSet.T072_GantP, CommessaAttiva)
            For Each dr As DataRow In GantPDT.GetChanges.Rows
                For Each drGant As LottiDataSet.T072_GantPRow In LottiDataSet.T072_GantP.Select("T072Id=" & CInt(dr.Item("T072ID")))
                    If CBool(drGant.T072NonApplicabile) Then
                        drGant.SetT072D1Null()
                        drGant.SetT072D2Null()
                        drGant.T072F = 0
                        drGant.T072I = 0
                    Else
                        drGant.T072D1 = CDate(dr.Item("DataInizioAttivita"))
                        drGant.T072D2 = CDate(dr.Item("DataFineAttivita"))
                        drGant.T072F = CInt(dr.Item("T072F"))
                        drGant.T072I = CInt(dr.Item("T072I"))
                    End If
                Next
            Next
            T072_GantPTableAdapter.Update(LottiDataSet.T072_GantP)
        End If
    End Sub
    Dim TS As New TimeSpan
    Dim TaskName As String = ""
    Private Sub StartMeno_Click(sender As Object, e As EventArgs) Handles StartMeno.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataInizio.Value = CDate(UG.ActiveRow.Cells("StartDateTime").Value)
            datDataInizio.Value = CDate(datDataInizio.Value).AddDays(CInt(numStartDay.Value) * -1)
            TS = UltraGanttView1.ActiveTask.Duration
            UltraGanttView1.ActiveTask.SetDuration(TimeSpan.FromDays(TS.Days + CInt(numStartDay.Value)), TimeSpanFormat.Days)
            UltraGanttView1.ActiveTask.StartDateTime = CDate(datDataInizio.Value)
        End If
    End Sub

    Private Sub StartPiu_Click(sender As Object, e As EventArgs) Handles btnStartPiu.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataInizio.Value = CDate(UG.ActiveRow.Cells("StartDateTime").Value)
            datDataInizio.Value = CDate(datDataInizio.Value).AddDays(CInt(numStartDay.Value))
            TS = UltraGanttView1.ActiveTask.Duration
            UltraGanttView1.ActiveTask.SetDuration(TimeSpan.FromDays(TS.Days - CInt(numStartDay.Value)), TimeSpanFormat.Days)
            UltraGanttView1.ActiveTask.StartDateTime = CDate(datDataInizio.Value)
        End If

    End Sub

    Private Sub ActivityMeno_Click(sender As Object, e As EventArgs) Handles btnActivityMeno.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataInizio.Value = CDate(UG.ActiveRow.Cells("StartDateTime").Value)
            datDataInizio.Value = CDate(datDataInizio.Value).AddDays(CInt(numActivityDay.Value) * -1)
            UltraGanttView1.ActiveTask.StartDateTime = CDate(datDataInizio.Value)
            datDataFine.Value = UltraGanttView1.ActiveTask.EndDateTime.Date
        End If

    End Sub

    Private Sub ActivityPiu_Click(sender As Object, e As EventArgs) Handles btnActivityPiu.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataInizio.Value = CDate(UG.ActiveRow.Cells("StartDateTime").Value)
            datDataInizio.Value = CDate(datDataInizio.Value).AddDays(CInt(numActivityDay.Value))
            UltraGanttView1.ActiveTask.StartDateTime = CDate(datDataInizio.Value)
            datDataFine.Value = UltraGanttView1.ActiveTask.EndDateTime.Date
        End If

    End Sub

    Private Sub EndMeno_Click(sender As Object, e As EventArgs) Handles btnEndMeno.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataFine.Value = CDate(UG.ActiveRow.Cells("EndDateTime").Value)
            datDataFine.Value = CDate(datDataFine.Value).AddDays(CInt(numEndDay.Value) * -1)
            TS = UltraGanttView1.ActiveTask.Duration
            UltraGanttView1.ActiveTask.SetDuration(TimeSpan.FromDays(TS.Days - CInt(numEndDay.Value)), TimeSpanFormat.Days)
            UltraGanttView1.ActiveTask.EndDateTime = CDate(datDataFine.Value)
        End If

    End Sub

    Private Sub EndPiu_Click(sender As Object, e As EventArgs) Handles btnEndPiu.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            datDataFine.Value = CDate(UG.ActiveRow.Cells("EndDateTime").Value)
            datDataFine.Value = CDate(datDataFine.Value).AddDays(CInt(numEndDay.Value))
            TS = UltraGanttView1.ActiveTask.Duration
            UltraGanttView1.ActiveTask.SetDuration(TimeSpan.FromDays(TS.Days + CInt(numEndDay.Value)), TimeSpanFormat.Days)
            UltraGanttView1.ActiveTask.EndDateTime = CDate(datDataFine.Value)
        End If

    End Sub

    Private Sub UltraGanttView1_ActiveTaskChanged(sender As Object, e As ActiveTaskChangedEventArgs) Handles UltraGanttView1.ActiveTaskChanged
        datDataInizio.Value = UltraGanttView1.ActiveTask.StartDateTime.Date
        datDataFine.Value = UltraGanttView1.ActiveTask.EndDateTime.Date.AddDays(-1)
        TaskName = UltraGanttView1.ActiveTask.Name
        If TaskName.ToUpper.Contains("LOTTO") Then
            TaskName = "LOTTO"
        End If
    End Sub

    Private Sub btnPercCompMeno_Click(sender As Object, e As EventArgs) Handles btnPercCompMeno.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            If UltraGanttView1.ActiveTask.PercentComplete > 0 Then
                UltraGanttView1.ActiveTask.PercentComplete = UltraGanttView1.ActiveTask.PercentComplete - CInt(numPercComp.Value)
            End If
        End If
    End Sub

    Private Sub btnPercCompPiu_Click(sender As Object, e As EventArgs) Handles btnPercCompPiu.Click
        If UltraGanttView1.ActiveTask IsNot Nothing And TaskName <> "LOTTO" Then
            If UltraGanttView1.ActiveTask.PercentComplete < 100 Then
                UltraGanttView1.ActiveTask.PercentComplete = UltraGanttView1.ActiveTask.PercentComplete + CInt(numPercComp.Value)
            End If
        End If
    End Sub
    Private Sub txtRicercaCommessa_Validating(sender As Object, e As CancelEventArgs) Handles txtRicercaCommessa.Validating
        CercaCommessa(txtRicercaCommessa.Text, 0)
    End Sub
    Private Sub txtRicercaCommessa_ValueChanged(sender As Object, e As EventArgs) Handles txtRicercaCommessa.ValueChanged
        If NxaNvl(txtRicercaCommessa.Value).Trim.Length = 5 Then CercaCommessa(txtRicercaCommessa.Text, 0)
    End Sub
    Private Sub CercaCommessa(Commessa As String, IdCommessa As Integer)
        For Each UGR As Infragistics.Win.UltraWinGrid.UltraGridRow In ngrdCommesse.Rows.GetRowEnumerator(Infragistics.Win.UltraWinGrid.GridRowType.DataRow, Nothing, Nothing)
            If UGR.Cells("T058Commessa").Value.ToString = Commessa Or CInt(UGR.Cells("T058IdCommessa").Value) = IdCommessa Then
                ngrdCommesse.Selected.Rows.Clear()
                ngrdCommesse.ActiveRow = UGR
                Exit For
            End If
        Next UGR
    End Sub
End Class
