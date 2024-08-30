Imports System.ComponentModel
Imports System.Data.SqlClient
Imports CE_Lotti.LottiDataSetTableAdapters
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGanttView
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinSchedule

'aggestionale01l.dmcasagrande.local
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
        Me.Height = 1000
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

        DT1.Columns.Add("Dummy", GetType(Integer))
        DT1.Columns.Add("Lotto", GetType(String))
        DT1.Columns.Add("Descrizione", GetType(String))
        DT1.Columns.Add("C1", GetType(Integer))
        DT1.Columns.Add("C2", GetType(Integer))
        DT1.Columns.Add("C3", GetType(Integer))
        DT1.Columns.Add("C4", GetType(Integer))

        DT2.Columns.Add("Dummy", GetType(Integer))
        DT2.Columns.Add("Lotto", GetType(String))
        DT2.Columns.Add("Descrizione", GetType(String))
        DT2.Columns.Add("C1", GetType(Integer))
        DT2.Columns.Add("C2", GetType(Integer))
        DT2.Columns.Add("C3", GetType(Integer))
        DT2.Columns.Add("C4", GetType(Integer))

        DT3.Columns.Add("Commessa", GetType(String))
        DT3.Columns.Add("DataConsegna", GetType(Date))

        T062_ListeQuadriNumerazioneTableAdapter.Fill(LottiDataSet.T062_ListeQuadriNumerazione)
        T058_Commesse_aperteTableAdapter.Fill(Me.LottiDataSet.T058_Commesse_aperte)
        LavorazioniEsterne_cboTableAdapter.Fill(Me.LottiDataSet.LavorazioniEsterne_cbo)
        ImpostazioniControlli()
        ImpostazioneToolBar()

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
    Private Sub LeggiProspettoOre()
        T042_ListeQuadriTableAdapter.Fill(LottiDataSet.T042_ListeQuadri, CommessaAttiva)
        T117_ListeQuadriDettaglioTableAdapter.Fill(LottiDataSet.T117_ListeQuadriDettaglio, CommessaAttiva)
        T045_ListeQuadriElenchiMaterialiTableAdapter.Fill(LottiDataSet.T045_ListeQuadriElenchiMateriali, CommessaAttiva)
        T042_MagicTableAdapter.Fill(LottiDataSet.T042_Magic, CommessaAttiva)
        T045_ListeQuadriElenchiMaterialiTableAdapter.Fill(LottiDataSet.T045_ListeQuadriElenchiMateriali, CommessaAttiva)
        ' T058_LottiTableAdapter.Fill(DataSetCommesse.T058_Lotti, CommessaAttiva)
        T117_ListeQuadriDettaglioTableAdapter.Fill(LottiDataSet.T117_ListeQuadriDettaglio, CommessaAttiva)
        ngrdT042_ListeQuadri_TotaliOrePreventivate_Calcolo()

    End Sub

    Private Sub ngrdCommesse_AfterRowActivate(sender As Object, e As EventArgs) Handles ngrdCommesse.AfterRowActivate
        If ngrdCommesse.ActiveRow IsNot Nothing AndAlso ngrdCommesse.ActiveRow.IsDataRow Then
            Me.Text = ngrdCommesse.ActiveRow.Cells("t058commessa").Text.Trim & " - " & ngrdCommesse.ActiveRow.Cells("t055RagioneSociale").Text
            CommessaAttiva = ngrdCommesse.ActiveRow.Cells("t058commessa").Text
            LeggiLotti(CommessaAttiva)
            LeggiProspettoOre()
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
    Dim LottiProspetto As String = "L"
    Private Sub UtbManager_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UTBManager.ToolClick

        Select Case e.Tool.Key
            Case "ButtonTool1"
                Me.Close()
            Case "ButtonTool2"
                VerificaModifiche(False)
            Case "ButtonTool3"
                'help
            Case "ButtonTool4"
                'cambio lotti/prospetto
                If TabControlPrincipale.SelectedTab Is UltraTabPageControl1.Tab Then
                    TabControlPrincipale.SelectedTab = UltraTabPageControl2.Tab
                    UTBManager.Toolbars(0).Tools(5).CustomizedCaption = "Lotti"
                    LottiProspetto = "P"
                    UTBManager.Toolbars(0).Tools(3).CustomizedCaption = "Nuovo Quadro"
                    UTBManager.Toolbars(0).Tools(4).CustomizedCaption = "Cancella Quadro202408010"
                Else
                    TabControlPrincipale.SelectedTab = UltraTabPageControl1.Tab
                    UTBManager.Toolbars(0).Tools(5).CustomizedCaption = "Prospetto Ore"
                    LottiProspetto = "L"
                    UTBManager.Toolbars(0).Tools(3).CustomizedCaption = "Nuovo Lotto"
                    UTBManager.Toolbars(0).Tools(4).CustomizedCaption = "Cancella Lotto"
                End If
            Case "ButtonTool5"
                'Process.Start("O:\CE_VS\Access\Lotti.accdb", "/X McrModelli")
                Process.Start("C:\Program Files (x86)\Microsoft Office\Office16\MSACCESS.EXE", "O:\CE_VS\Access\Lotti.accdb /X McrModelli")

            Case "ButtonTool6"
                MsgBox("6666")
            Case "ButtonTool7"
                T058_Commessa_Cartella()
            Case "ButtonTool8"
                MsgBox("8888")
            Case "ButtonTool9"
                ' nuovo
                If LottiProspetto = "L" Then
                    ' MsgBox("nuovo lotto")
                    Inserimento_LottoTableAdapter.Fill(LottiDataSet.Inserimento_Lotto, CommessaAttiva, Environ("USERNAME"))
                    LeggiLotti(CommessaAttiva)
                End If
                If LottiProspetto = "P" Then

                End If
            Case "ButtonTool10"
                ' cancella
                If LottiProspetto = "L" Then
                    ngrdT059_Lotti.DeleteSelectedRows(False)
                End If
                If LottiProspetto = "P" Then
                    ngrdT042_ListeQuadri.DeleteSelectedRows(False)
                End If
        End Select


        'Select Case T062IdTipologia, T062Tipologia, T062Attiva
        'From T062_Tipologie
        'Where (T062Identificatore = 2)
        'Order By T062Tipologia
    End Sub
    Private Sub T058_Commessa_Cartella()

        Dim Commessa As String = ngrdCommesse.ActiveRow.Cells("T058Commessa").Value.ToString
        Dim Path1 As String = "P:\000Comm\"
        Dim Path2 As String = "Comm" & CStr(IIf(Val(Strings.Left(Commessa, 2)) < 50, "20", "19")) & Strings.Left(Commessa, 2) & "\C" & Strings.Left(Commessa, 2) & "-" & Strings.Right(Commessa, 3)
        Dim X As String
        If Not System.IO.Directory.Exists(Path1 & Path2) Then
            Path1 = "\\srvfs01\Archivio-Comm\"
            If Not System.IO.Directory.Exists(Path1 & Path2) Then
                X = "C:\"
            Else
                X = Path1 & Path2
            End If
        Else
            X = Path1 & Path2
        End If
        Process.Start(X)
    End Sub
    Private Sub ConfigurazioneGriglia(ByRef griglia As UltraGrid, band As Integer, tabella As String)
        TtmConfigurazioneGrigliaTableAdapter.Fill(LottiDataSet.TtmConfigurazioneGriglia, 0, tabella, "BLACK", "")
        T108_UfficiTableAdapter.Fill(LottiDataSet.T108_Uffici, 0, 1, 1)

        Dim Colore As System.Drawing.Color
        For Each RwGr As LottiDataSet.TtmConfigurazioneGrigliaRow In LottiDataSet.TtmConfigurazioneGriglia.Rows
            If Not RwGr.IsCngrTraduzioneNull AndAlso RwGr.CngrTraduzione.Trim.Length > 0 Then
                If griglia.DisplayLayout.Bands(band).Columns.Exists(RwGr.CngrNomeColonna.Trim) Then
                    griglia.DisplayLayout.Bands(band).Columns(RwGr.CngrNomeColonna.Trim).Header.Caption = RwGr.CngrTraduzione
                End If
            End If
            If Not RwGr.IsCngrUfficioNull Then
                For Each rwcol As LottiDataSet.T108_UfficiRow In LottiDataSet.T108_Uffici.Select("T108Id=" & RwGr.CngrUfficio)

                    If Not rwcol.IsT108ColoreNull Then
                        Colore = TtmConvertColorToARGB(rwcol.T108Colore)
                        If griglia.DisplayLayout.Bands(band).Columns.Exists(RwGr.CngrNomeColonna.Trim) Then
                            griglia.DisplayLayout.Bands(band).Columns(RwGr.CngrNomeColonna.Trim).Header.Appearance.BackColor = Colore
                        End If
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub ImpostazioniControlli()

        Dim VisiblePosition As Integer = 0

        If Environ("Username").ToUpper = "BLACK" Or Environ("Username").ToUpper = "ABACU" Then
            Infragistics.Win.AppStyling.StyleManager.Load(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CE_VisualStudio\CE.isl")
        Else
            Infragistics.Win.AppStyling.StyleManager.Load("U:\0000\CE_VS\CE.isl")
        End If

        ' tacamia
        ConfigurazioneGriglia(ngrdT059_Lotti, 0, "T059_Lotti")
        ConfigurazioneGriglia(ngrdT059_Lotti, 1, "T074_LottiDettaglio")
        ConfigurazioneGriglia(ngrdT042_ListeQuadri, 0, "T042_ListeQuadri")
        ngrdT042_ListeQuadri.Text = "Prospetto Ore"
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Numerazione").EditorComponent = cboT042Numerazione
        ugT042Totali.Text = ""
        ConfigurazioneGriglia(ngrdT042_ListeQuadri, 1, "T117_ListeQuadriDettaglio")
        ConfigurazioneGriglia(ngrdT042_ListeQuadri, 2, "T045_ListeQuadriElenchiMateriali")


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

        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Id").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Lotto").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Commessa").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074InsertUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074InsertDate").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074UpdateUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074UpdateDate").Hidden = True

        cboT074LavorazioniEsterneG.DisplayLayout.Bands(0).Columns("T074Centro").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074LavorazioniEsterne").EditorComponent = cboT074LavorazioniEsterneG

        VisiblePosition = 0
        ngrdT059_Lotti.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
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

        VisiblePosition = 0
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Centro").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Centro").Width = 60
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Preventivo").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Preventivo").Width = 100
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Obbiettivo").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074Obbiettivo").Width = 100
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074OreEsterne").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074OreEsterne").Width = 100
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074LavorazioniEsterne").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("T074LavorazioniEsterne").Width = 100
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("Consuntivo").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT059_Lotti.DisplayLayout.Bands(1).Columns("Consuntivo").Width = 100


        'ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * ngrdT059_Lotti2 * 
        ngrdT059_Lotti2.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free

        ngrdT059_Lotti2.Text = ""
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Lotto").Width = 30
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Selezionato").Width = 20
        ngrdT059_Lotti2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        ngrdT059_Lotti2.DisplayLayout.Override.AllowColSwapping = AllowColSwapping.NotAllowed

        'ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * ngrdT059_Lotti3 * 

        ngrdT059_Lotti3.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
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

        ngrdT059_Lotti4.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
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

        'ngrdT042_ListeQuadri * ngrdT042_ListeQuadri * ngrdT042_ListeQuadri * ngrdT042_ListeQuadri * ngrdT042_ListeQuadri * ngrdT042_ListeQuadri * 

        ngrdT042_ListeQuadri.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("Ordinamento").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Commessa").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042DescrizioneLotto").Hidden = True

        VisiblePosition = 0
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Numerazione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Numerazione").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PosizioneInterna").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PosizioneInterna").Width = 50

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PosizioneOrdine").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PosizioneOrdine").Width = 100

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Quantita").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Quantita").Width = 60

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Descrizione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Descrizione").Width = 200

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Lotto").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Lotto").Width = 40

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Revisione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Revisione").Width = 50

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042DataRevisione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042DataRevisione").Width = 70

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042StandBy").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042StandBy").Width = 50

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Note").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Note").Width = 200

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042ConsegnaMateriali").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042ConsegnaMateriali").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Colonne").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Colonne").Width = 60

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoUnitario").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoUnitario").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoVarianti").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoVarianti").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoTotale").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042PrezzoTotale").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertUser").Header.Caption = "Utente Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042InsertDate").Header.Caption = "Data Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateUser").Header.Caption = "Utente Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042UpdateDate").Header.Caption = "Data Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Id").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(0).Columns("T042Id").Width = 60

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117PosizioneInterna").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117Commessa").Hidden = True


        VisiblePosition = 0
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117Centro").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117Centro").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117OrePreventivate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117OrePreventivate").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertUser").Header.Caption = "Utente Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117InsertDate").Header.Caption = "Data Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateUser").Header.Caption = "Utente Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117UpdateDate").Header.Caption = "Data Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117Id").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(1).Columns("T117Id").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Commessa").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045PosizioneInterna").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T042Descrizione").Hidden = True
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T042Quantita").Hidden = True
        VisiblePosition = 0

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045ElencoMateriali").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045ElencoMateriali").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T043Descrizione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T043Descrizione").Width = 300

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Quantita").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Quantita").Width = 60

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045DataConsegnaMateriali").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045DataConsegnaMateriali").Width = 90

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045TipoConsegna").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045TipoConsegna").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Note").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Note").Width = 300

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Revisione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Revisione").Width = 60

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045DataRevisione").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045DataRevisione").Width = 80

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045StandBy").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045StandBy").Width = 50

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertUser").Header.Caption = "Utente Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045InsertDate").Header.Caption = "Data Inserimento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateUser").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateUser").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateUser").Header.Caption = "Utente Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateDate").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateDate").Width = 100
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045UpdateDate").Header.Caption = "Data Aggiornamento"

        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Id").Header.VisiblePosition = SetVisiblePosition(VisiblePosition)
        ngrdT042_ListeQuadri.DisplayLayout.Bands(2).Columns("T045Id").Width = 90
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
        UTBManager.Toolbars(0).Tools(1).CustomizedCaption = "Help"
        UTBManager.Toolbars(0).Tools(2).CustomizedCaption = "Salva Modifiche"
        UTBManager.Toolbars(0).Tools(3).CustomizedCaption = "Nuovo Lotto"
        UTBManager.Toolbars(0).Tools(4).CustomizedCaption = "Cancella Lotto"
        UTBManager.Toolbars(0).Tools(5).CustomizedCaption = "Prospetto Ore"
        UTBManager.Toolbars(0).Tools(6).CustomizedCaption = "Etichette/Modelli"
        UTBManager.Toolbars(0).Tools(7).CustomizedCaption = "Pianificazione Attività"
        UTBManager.Toolbars(0).Tools(8).CustomizedCaption = "Cartella Commessa"
        UTBManager.Toolbars(0).Tools(9).CustomizedCaption = "Situazione Ordini"

        ' UTBManager.Toolbars(0).

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

    Private Sub ngrdT059_Lotti_AfterRowActivate(sender As Object, e As EventArgs) Handles ngrdT059_Lotti.AfterRowActivate
        If ngrdT059_Lotti.ActiveRow.Band.Index = 1 Then
            CType(ngrdT059_Lotti.ActiveRow.Cells("T074LavorazioniEsterne").EditorComponentResolved, UltraCombo).DisplayLayout.Bands(0).ColumnFilters("T074Centro").ClearFilterConditions()
            CType(ngrdT059_Lotti.ActiveRow.Cells("T074LavorazioniEsterne").EditorComponentResolved, UltraCombo).DisplayLayout.Bands(0).ColumnFilters("T074Centro").FilterConditions.Add(FilterComparisionOperator.Equals, ngrdT059_Lotti.ActiveRow.Cells("T074Centro").Text.Trim)
        End If
    End Sub
    Dim TtmTransaction As SqlClient.SqlTransaction
    Private Sub VerificaModifiche(Richiesta As Boolean)
        ngrdT059_Lotti.UpdateData()

        If LottiDataSet.HasChanges Or GantPDT.GetChanges IsNot Nothing Then
            If Richiesta Then
                If MessageBox.Show("Confermi Modifiche ?", "Lotti", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Verificamodifiche()
                Else
                    LottiDataSet.RejectChanges()
                End If
            Else
                Verificamodifiche()
            End If
        End If
    End Sub

    Private Sub Verificamodifiche()

        Try
            T074_LottiDettaglioTableAdapter.Update(LottiDataSet.T074_LottiDettaglio)
            T059_LottiTableAdapter.Update(LottiDataSet.T059_Lotti)

            SalvaModificheGant()
            LavorazioniEsterne_cboTableAdapter.Fill(Me.LottiDataSet.LavorazioniEsterne_cbo)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ngrdCommesse_BeforeRowDeactivate(sender As Object, e As CancelEventArgs) Handles ngrdCommesse.BeforeRowDeactivate
        VerificaModifiche(True)
    End Sub

    Private Sub Lotti_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        VerificaModifiche(True)
    End Sub
    Dim cmd As SqlCommand
    Dim con As New SqlClient.SqlConnection(My.MySettings.Default.LottiConnectionString)
    Dim D As New DataTable

    Private Sub ngrdT059_Lotti_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles ngrdT059_Lotti.BeforeRowsDeleted
        For Each rg As UltraGridRow In ngrdT059_Lotti.Selected.Rows
            If rg.Band.Index <> 0 Then
                MsgBox("Selezionare Riga Lotto")
                e.Cancel = True
                Exit Sub
            End If
        Next
        If MessageBox.Show("Confermi Cancellazione Lotto/i", "Cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
        cmd = New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        con.Open()
        For Each rg As UltraGridRow In ngrdT059_Lotti.Selected.Rows
            cmd.CommandText = "delete from T074_LottiDettaglio where T074Commessa = '" & CommessaAttiva & "' and T074Lotto = '" & rg.Cells("T059Lotto").Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from T072_GantP where T072Commessa = '" & CommessaAttiva & "' and T072Lotto = '" & rg.Cells("T059Lotto").Text & "'"
            cmd.ExecuteNonQuery()
        Next
        con.Close()
    End Sub

    Private Sub ngrdT059_Lotti_AfterRowsDeleted(sender As Object, e As EventArgs) Handles ngrdT059_Lotti.AfterRowsDeleted
        VerificaModifiche(False)
    End Sub
    Dim DT1 As New DataTable
    Dim DT2 As New DataTable
    Dim DT3 As New DataTable
    Private Sub ngrdT042_ListeQuadri_TotaliOrePreventivate_Calcolo()
        DT1.Clear()
        DT2.Clear()
        Dim X As DataTable = LottiDataSet.T042_Magic.Clone
        Dim nRW As DataRow = Nothing
        For Each RW As DataRow In LottiDataSet.T042_Magic.Rows
            If RW.RowState <> DataRowState.Deleted Then
                nRW = X.NewRow
                nRW.ItemArray = RW.ItemArray
                X.Rows.Add(nRW)
            End If
        Next
        If X.Rows.Count > 0 Then
            DT1 = X.AsEnumerable().GroupBy(Function(r) r.Field(Of String)("T042Lotto")).[Select](Function(g)
                                                                                                     Dim row As DataRow = DT1.NewRow()
                                                                                                     row("Dummy") = 1
                                                                                                     row("Lotto") = NxaNvl(g.Key)
                                                                                                     row("Descrizione") = g.GroupBy(Function(r) r.Field(Of String)("DescrizioneLotto"))(0).Key
                                                                                                     row("C1") = g.Sum(Function(r) r.Field(Of Integer)("C1"))
                                                                                                     row("C2") = g.Sum(Function(r) r.Field(Of Integer)("C2"))
                                                                                                     row("C3") = g.Sum(Function(r) r.Field(Of Integer)("C3"))
                                                                                                     row("C4") = g.Sum(Function(r) r.Field(Of Integer)("C4"))
                                                                                                     Return row
                                                                                                 End Function).CopyToDataTable()
        End If
        If DT1.Rows.Count > 1 Then
            DT2 = X.AsEnumerable().GroupBy(Function(r) r.Field(Of String)("T042Commessa")).[Select](Function(g)
                                                                                                        Dim row As DataRow = DT2.NewRow()
                                                                                                        row("Dummy") = 2
                                                                                                        row("Lotto") = ""
                                                                                                        row("Descrizione") = "Totali"
                                                                                                        row("C1") = g.Sum(Function(r) r.Field(Of Integer)("C1"))
                                                                                                        row("C2") = g.Sum(Function(r) r.Field(Of Integer)("C2"))
                                                                                                        row("C3") = g.Sum(Function(r) r.Field(Of Integer)("C3"))
                                                                                                        row("C4") = g.Sum(Function(r) r.Field(Of Integer)("C4"))
                                                                                                        Return row
                                                                                                    End Function).CopyToDataTable()
        End If
        Dim DT3 As New DataTable()
        Dim dc As New DataColumn("Id") With {
            .AutoIncrement = True,
            .AutoIncrementSeed = 1,
            .AutoIncrementStep = 1,
            .DataType = GetType(Int32)
        }
        DT3.Columns.Add(dc)
        DT3.Columns.Add("Lotto", GetType(String))
        DT3.Columns.Add("Descrizione", GetType(String))
        DT3.Columns.Add("C1", GetType(Integer))
        DT3.Columns.Add("C2", GetType(Integer))
        DT3.Columns.Add("C3", GetType(Integer))
        DT3.Columns.Add("C4", GetType(Integer))
        For I As Integer = 0 To DT1.Rows.Count - 1
            Dim row As DataRow = DT3.Rows.Add()
            row.ItemArray = DT1(I).ItemArray
        Next I
        If DT1.Rows.Count > 1 Then
            For I As Integer = 0 To DT2.Rows.Count - 1
                Dim row As DataRow = DT3.Rows.Add()
                row.ItemArray = DT2(I).ItemArray
            Next I
        End If
        ugT042Totali.DataSource = DT3
        ugT042Totali.DisplayLayout.Bands(0).Columns(0).Hidden = True
        ugT042Totali.DisplayLayout.Bands(0).Columns(1).Width = 50
        ugT042Totali.DisplayLayout.Bands(0).Columns(2).Width = 250
        For I As Integer = 3 To 6
            ugT042Totali.DisplayLayout.Bands(0).Columns(I).Width = 100
            ugT042Totali.DisplayLayout.Bands(0).Columns(I).Format = "###,###,###"
            ugT042Totali.DisplayLayout.Bands(0).Columns(I).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        Next I
        ugT042Totali.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        ugT042Totali.DisplayLayout.Bands(0).Columns(0).SortIndicator = SortIndicator.Ascending
    End Sub
    Private Sub ngrdT042_ListeQuadri_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ngrdT042_ListeQuadri.AfterCellUpdate
        If e.Cell.Row.Band.Index = 0 Then
            e.Cell.Row.Cells("T042StandBy").Value = CBool(1)
            If e.Cell.Column.Key = "T042Lotto" Or Strings.Left(e.Cell.Column.Key, 19) = "T042OrePreventivate" Then ngrdT042_ListeQuadri_TotaliOrePreventivate_Calcolo()
            If e.Cell.Column.Key = "T042PrezzoUnitario" Or e.Cell.Column.Key = "T042PrezzoVarianti" Then e.Cell.Row.Cells("T042PrezzoTotale").Value = CDec(IIf(e.Cell.Row.Cells("T042PrezzoUnitario").Value.ToString = "", 0, e.Cell.Row.Cells("T042PrezzoUnitario").Value)) + CDec(IIf(e.Cell.Row.Cells("T042PrezzoVarianti").Value.ToString = "", 0, e.Cell.Row.Cells("T042PrezzoVarianti").Value))
        Else
            If e.Cell.Row.Band.Index = 1 Then
                e.Cell.Row.ParentRow.Cells("T042StandBy").Value = CBool(1)
            Else
                e.Cell.Row.Cells("T045StandBy").Value = CBool(1)
            End If
        End If
    End Sub
    Dim PosizioneAttiva As String = ""

    Private Sub ngrdT042_ListeQuadri_AfterRowExpanded(sender As Object, e As RowEventArgs) Handles ngrdT042_ListeQuadri.AfterRowExpanded
        CercaPosizione(NxaNvl(e.Row.Cells("T042PosizioneInterna").Value))
        PosizioneAttiva = NxaNvl(e.Row.Cells("T042PosizioneInterna").Value)
    End Sub
    Private Sub ngrdT042_ListeQuadri_AfterRowInsert(sender As Object, e As RowEventArgs) Handles ngrdT042_ListeQuadri.AfterRowInsert
        e.Row.Cells("T042PosizioneInterna").Value = e.Row.Cells("T042Id").Value
        e.Row.Cells("T042Commessa").Value = CommessaAttiva
        e.Row.Cells("T042Quantita").Value = 1
    End Sub
    Private Sub CercaPosizione(Posizione As String)
        For Each UGR As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.ngrdT042_ListeQuadri.Rows
            If UGR.Cells("T042PosizioneInterna").Value.ToString = Posizione Then
                ngrdT042_ListeQuadri.Selected.Rows.Clear()
                ngrdT042_ListeQuadri.ActiveRow = UGR
                UGR.Selected = True
                Exit For
            End If
        Next
    End Sub
    Private Sub ngrdT042_ListeQuadri_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles ngrdT042_ListeQuadri.InitializeLayout
        e.Layout.Override.HeaderClickAction = HeaderClickAction.Select
        e.Layout.Override.SelectTypeCol = UltraWinGrid.SelectType.None
    End Sub
    Private Sub ngrdT042_ListeQuadri_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles ngrdT042_ListeQuadri.InitializeRow
        If e.Row.Band.Index = 0 AndAlso CInt(e.Row.Cells("T042Id").Value) = 0 Then
            e.Row.Cells("T042PosizioneInterna").Appearance.FontData.Bold = DefaultableBoolean.True
            e.Row.Cells("T042PrezzoUnitario").Appearance.FontData.Bold = DefaultableBoolean.True
            e.Row.Cells("T042PrezzoVarianti").Appearance.FontData.Bold = DefaultableBoolean.True
            e.Row.Cells("T042PrezzoTotale").Appearance.FontData.Bold = DefaultableBoolean.True
            e.Row.Cells("T042Id").Appearance.ForeColor = e.Row.Cells("T042Id").Appearance.BackColor
            e.Row.Activation = Activation.ActivateOnly
        End If
    End Sub
    'Private Sub ngrdT042_ListeQuadri_MouseUp(sender As Object, e As Windows.Forms.MouseEventArgs) Handles ngrdT042_ListeQuadri.MouseUp
    '    If ngrdT042_ListeQuadri.ActiveRow IsNot Nothing AndAlso ngrdT042_ListeQuadri.ActiveRow.IsDataRow AndAlso ngrdT042_ListeQuadri.ActiveRow.Band.Index = 0 Then
    '        Dim Grid As UltraGrid = CType(sender, UltraGrid)
    '        Dim element As UIElement = Grid.DisplayLayout.UIElement.LastElementEntered
    '        Dim header As Infragistics.Win.UltraWinGrid.ColumnHeader = CType(element.GetContext(GetType(ColumnHeader)), Infragistics.Win.UltraWinGrid.ColumnHeader)
    '        If header IsNot Nothing AndAlso header.Column.Key = "T045ElencoMateriali" Then
    '            Dim f As New T045Inserimento(Me, CommessaAttiva, NxaNvl(ngrdT042_ListeQuadri.NxaActiveDataRow.Cells("T042PosizioneInterna").Value), "P")
    '            f.StartPosition = Windows.Forms.FormStartPosition.CenterParent
    '            f.WindowState = Windows.Forms.FormWindowState.Normal
    '            RigheInserite = False
    '            f.ShowDialog()
    '            If RigheInserite Then T045_Lettura()
    '        End If
    '    End If
    'End Sub
    'Private Sub ngrdT042_ListeQuadri_TtmAfterUpdate(sender As Object, e As CancelEventArgs) Handles ngrdT042_ListeQuadri.TtmAfterUpdate
    '    T117_ListeQuadriDettaglioTableAdapter.Fill(LottiDataSet.T117_ListeQuadriDettaglio, CommessaAttiva)
    'End Sub
    Dim A As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
    Dim S As New SqlClient.SqlConnection(My.MySettings.Default.LottiConnectionString)

    Private Sub ngrdT042_ListeQuadri_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles ngrdT042_ListeQuadri.BeforeRowsDeleted

        Dim DT_presente As New DataTable
        For Each rg As Infragistics.Win.UltraWinGrid.UltraGridRow In ngrdT042_ListeQuadri.Selected.Rows
            If rg.Band.Index = 0 Then
                A.SelectCommand = New SqlClient.SqlCommand("select dbo.CE_FS_ControlloMovimentazionePosizione('" & CommessaAttiva & "','" & NxaNvl(rg.Cells("T042PosizioneInterna").Value) & "') Trovati", S)
                A.Fill(DT_presente)
                If CInt(NxaNvlNum(DT_presente.Rows(0).Item("Trovati"))) > 0 Then
                    MsgBox("Impossibile Cancellare Posizione " & NxaNvl(rg.Cells("T042PosizioneInterna").Value).Trim & " Perchè Utilizzata ", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Prospetto Ore")
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            If rg.Band.Index = 1 Then
                MsgBox("Impossibile Cancellare Ore Preventivo", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Prospetto Ore")
                e.Cancel = True
                Exit Sub
            End If
            If rg.Band.Index = 2 Then
                MsgBox("Impossibile Cancellare Aggregazioni Da Questa Visualizzazione", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Prospetto Ore")
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub
    'Private Sub ngrdT042_ListeQuadri_TtmBeforeLoad(sender As Object, e As CancelEventArgs) Handles ngrdT042_ListeQuadri.TtmBeforeLoad
    '    Dim DT1 As New DataTable
    '    Dim DT2 As New DataTable
    '    Dim DT3 As New DataTable
    '    DT1.Clear()
    '    DT1 = CType(Lottidataset.T042_ListeQuadri, DataTable).GetChanges
    '    DT2.Clear()
    '    DT2 = CType(Lottidataset.T045_ListeQuadriElenchiMateriali, DataTable).GetChanges
    '    DT3.Clear()
    '    DT3 = CType(Lottidataset.T117_ListeQuadriDettaglio, DataTable).GetChanges
    '    If CiSonoModifiche(DT1, DT2, DT3) Then
    '        If MsgBox("Confermi Rilettura Elenco Quadri", vbYesNo, "Tutte le Modifiche Andranno Perse") = vbYes Then ngrdT042_ListeQuadri_Lettura()
    '    End If
    '    e.Cancel = True
    'End Sub
    'Private Sub ngrdT042_ListeQuadri_TtmLettaConfigurazioneTabella(sender As Object, ByRef ConfigurazioneTabella As TtmDataSet.TtmConfigurazioneTabellaRow, Band As Integer, Tabella As String) Handles ngrdT042_ListeQuadri.TtmLettaConfigurazioneTabella
    '    If Tabella = "T045_ListeQuadriElenchiMateriali" Then ConfigurazioneTabella.Item("CntaNewRowMode") = 0
    'End Sub

    Private Sub ngrdT042_ListeQuadri______Update()
        Try
            ngrdT042_ListeQuadri.UpdateData()
            'If TtmConnection.State = ConnectionState.Closed Then TtmConnection.Open()
            'TtmTransaction = TtmConnection.BeginTransaction
            'T042_ListeQuadriTableAdapter.Transaction = TtmTransaction
            T045_ListeQuadriElenchiMaterialiTableAdapter.Transaction = TtmTransaction
            T117_ListeQuadriDettaglioTableAdapter.Transaction = TtmTransaction
            T042_ListeQuadriTableAdapter.Update(LottiDataSet.T042_ListeQuadri)
            T045_ListeQuadriElenchiMaterialiTableAdapter.Update(LottiDataSet.T045_ListeQuadriElenchiMateriali)
            T117_ListeQuadriDettaglioTableAdapter.Update(LottiDataSet.T117_ListeQuadriDettaglio)
            TtmTransaction.Commit()
            'TtmConnection.Close()
            ngrdT042_ListeQuadri______Revisione_Controllo()
            T042_ListeQuadriTableAdapter.Fill(LottiDataSet.T042_ListeQuadri, CommessaAttiva)
            'If ngrdT042_ListeQuadri.NxaDisabledTools.Contains(NxaCore.NxaCommon.NxaConsts.NXACONST_TOOLBAR_BUTTONUPDATE) Then
            '    ngrdT042_ListeQuadri.NxaDisabledTools.Remove(NxaCore.NxaCommon.NxaConsts.NXACONST_TOOLBAR_BUTTONUPDATE)
            '    NxaDisableTools()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            TtmTransaction.Rollback()
            '  TtmConnection.Close()
        End Try
    End Sub
    Private Sub ngrdT042_ListeQuadri______Revisione_Controllo()

        Dim DT As New DataTable()
        Dim Revisione As Integer
        'Dim SqlQuery As String
        A.SelectCommand = New SqlClient.SqlCommand("SELECT T042StandBy FROM T042_ListeQuadri WHERE T042Commessa = '" & CommessaAttiva & "' AND T042StandBy=1", S)
        A.Fill(DT)
        'SqlQuery = "SELECT T042StandBy FROM T042_ListeQuadri WHERE T042Commessa = '" & CommessaAttiva & "' AND T042StandBy=1"
        '    DT = NxaCore.NxaWindows.NxaDatabase.TtmFillDataTable(SqlQuery)
        If DT.Rows.Count > 0 Then
            If MsgBox("Aumentare Indice Revisione ?", vbYesNo, "Prospetto Ore Commessa " & CommessaAttiva) = vbYes Then
                'SqlQuery = "SELECT ISNULL(T042Revisione, -1) AS R FROM T042_ListeQuadri WHERE T042Commessa = '" & CommessaAttiva & "' ORDER BY R DESC"
                'DT = NxaCore.NxaWindows.NxaDatabase.TtmFillDataTable(SqlQuery)
                A.SelectCommand = New SqlClient.SqlCommand("SELECT ISNULL(T042Revisione, -1) AS R FROM T042_ListeQuadri WHERE T042Commessa = '" & CommessaAttiva & "' ORDER BY R DESC", S)
                A.Fill(DT)
                Revisione = CInt(NxaNvlNum(DT.Rows(0).Item("R")))
                'SqlQuery = "exec [dbo].[T042_ListeQuadri_Revisione_Aumento] '" & CommessaAttiva & "'," & CInt(IIf(Revisione = -1, 0, Revisione + 1))
                'DT = NxaCore.NxaWindows.NxaDatabase.TtmFillDataTable(SqlQuery)
                A.SelectCommand = New SqlClient.SqlCommand("exec [dbo].[T042_ListeQuadri_Revisione_Aumento] '" & CommessaAttiva & "'," & CInt(IIf(Revisione = -1, 0, Revisione + 1)), S)
                A.Fill(DT)
                For Each DR As DataRow In DT.Rows
                    If CInt(DR("Esito").ToString) = 0 Then Dim Risposta As Long = MsgBox(DR("Errore").ToString & " - " & DR("Messaggio").ToString, CType(vbCritical + vbOKOnly, MsgBoxStyle), "Aumento Revisione Prospetto Ore")
                Next DR
            End If
        End If
    End Sub
    Dim EM As LottiDataSet.T043_ElenchiMaterialiRow
    Dim EMD As LottiDataSet.T044_ElenchiMaterialiDettaglioComponenteRow
    Dim EMDA As LottiDataSet.T044_ElenchiMaterialiDettaglioAccessorioRow
    Dim DtElenchi As New DataTable
    Public ElencoMaterialiAttivo As String = ""

    Private Sub InserimentoRiga(TipoRiga As Integer, IdSuperiore As String, RigaGrid As UltraGridRow, RigaDT As DataRow, Griglia As String)
        If DtElenchi IsNot Nothing Then
            DtElenchi.Clear()
        End If
        If RigaGrid IsNot Nothing Then
            ElencoMaterialiAttivo = NxaNvl(RigaGrid.Cells("T043ElencoMateriali").Value)
        ElseIf RigaDT IsNot Nothing Then
            ElencoMaterialiAttivo = NxaNvl(RigaDT.Item("T043ElencoMateriali"))
        Else
            Exit Sub
        End If
        '  DtElenchi = NxaCore.NxaWindows.NxaDatabase.TtmFillDataTable("exec T044_ElenchiMaterialiDettaglio_InsertCommand '" & CommessaAttiva & "','" & ElencoMaterialiAttivo & "'," & IdSuperiore & ",'" & NxaCore.NxaCommon.NxaVars.NxaUser & "'")
        A.SelectCommand = New SqlClient.SqlCommand("exec T044_ElenchiMaterialiDettaglio_InsertCommand '" & CommessaAttiva & "','" & ElencoMaterialiAttivo & "'," & IdSuperiore & ",'" & Environ("Username") & "'", S)
        A.Fill(DtElenchi)
        For Each R As DataRow In DtElenchi.Rows
            EMD = LottiDataSet.T044_ElenchiMaterialiDettaglioComponente.NewT044_ElenchiMaterialiDettaglioComponenteRow
            For Each dc As DataColumn In R.Table.Columns
                EMD.Item(dc.ColumnName) = R.Item(dc.ColumnName)
            Next
            If RigaGrid IsNot Nothing Then
                EMD.T043Id = CInt(RigaGrid.Cells("T043Id").Value)
                EMD.T043Commessa = NxaNvl(RigaGrid.Cells("T043Commessa").Value)
                EMD.T043ElencoMateriali = NxaNvl(RigaGrid.Cells("T043ElencoMateriali").Value)
            Else
                EMD.T043Id = CInt(RigaDT.Item("T043Id"))
                EMD.T043Commessa = NxaNvl(RigaDT.Item("T043Commessa"))
                EMD.T043ElencoMateriali = NxaNvl(RigaDT.Item("T043ElencoMateriali"))
            End If

            EMD.TipoRiga = TipoRiga
            LottiDataSet.T044_ElenchiMaterialiDettaglioComponente.Rows.Add(EMD)

        Next
        If TipoRiga = 2 Then
            For Each R As DataRow In DtElenchi.Rows
                EMDA = LottiDataSet.T044_ElenchiMaterialiDettaglioAccessorio.NewT044_ElenchiMaterialiDettaglioAccessorioRow
                For Each dc As DataColumn In R.Table.Columns
                    EMDA.Item(dc.ColumnName) = R.Item(dc.ColumnName)
                Next
                If RigaGrid IsNot Nothing Then
                    EMDA.T043Id = CInt(RigaGrid.Cells("T043Id").Value)
                    EMDA.T043Commessa = NxaNvl(RigaGrid.Cells("T043Commessa").Value)
                    EMDA.T043ElencoMateriali = NxaNvl(RigaGrid.Cells("T043ElencoMateriali").Value)
                Else
                    EMDA.T043Id = CInt(RigaDT.Item("T043Id"))
                    EMDA.T043Commessa = NxaNvl(RigaDT.Item("T043Commessa"))
                    EMDA.T043ElencoMateriali = NxaNvl(RigaDT.Item("T043ElencoMateriali"))
                End If

                EMDA.TipoRiga = TipoRiga
                LottiDataSet.T044_ElenchiMaterialiDettaglioAccessorio.Rows.Add(EMDA)

            Next
        End If
        'If Griglia = "G" Then
        '    If RigaGrid IsNot Nothing Then
        '        CercaRigaMateriali_G(EMD.T044Id)

        '    Else
        '        'CercaRigaMateriali_G(CInt(RigaDT.Item("T044Id")))
        '        ngrdT043_ElenchiMateriali_G.NxaLastRecord()
        '    End If
        'End If
        'If Griglia = "L" Then
        '    If RigaGrid IsNot Nothing Then
        '        CercaRigaMateriali_L(EMD.T044Id)
        '    Else
        '        CercaRigaMateriali_L(EMD.T044Id)
        '    End If
        'End If
    End Sub



    'Private Sub CercaRigaMateriali_G(Id As Integer)
    '    If ngrdT043_ElenchiMateriali_G.NxaActiveDataRow IsNot Nothing Then
    '        If ngrdT043_ElenchiMateriali_G.NxaActiveDataRow.Band.Index = 1 Then
    '            For Each UGR As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.ngrdT043_ElenchiMateriali_G.NxaActiveDataRow.ParentRow.ChildBands(0).Rows
    '                If CInt(UGR.Cells("T044Id").Value) = Id Then
    '                    ngrdT043_ElenchiMateriali_G.Selected.Rows.Clear()
    '                    ngrdT043_ElenchiMateriali_G.ActiveRow = UGR
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    End If
    'End Sub
    Private Sub ngrdT042_ListeQuadri_Totali_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles ugT042Totali.InitializeRow
        If e.Row.Cells(2).Value.ToString = "Totali" Then
            For I As Integer = 1 To 6
                e.Row.Cells(I).Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
            Next I
        End If
    End Sub
End Class
