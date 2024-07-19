Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports Infragistics.Win.UltraWinGrid

Public Class Lotti
    Dim CommessaAttiva As String
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub Lotti_Load(sender As Object, e As EventArgs) Handles Me.Load
        ImpostazioniControlli()
        ImpostazioneToolBar()
        T058_Commesse_aperteTableAdapter.Fill(Me.LottiDataSet.T058_Commesse_aperte)
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
    End Sub

    Private Sub ngrdCommesse_AfterRowActivate(sender As Object, e As EventArgs) Handles ngrdCommesse.AfterRowActivate
        If ngrdCommesse.ActiveRow IsNot Nothing AndAlso ngrdCommesse.ActiveRow.IsDataRow Then
            Me.Text = ngrdCommesse.ActiveRow.Cells("t058commessa").Text.Trim & " - " & ngrdCommesse.ActiveRow.Cells("t055RagioneSociale").Text
            CommessaAttiva = ngrdCommesse.ActiveRow.Cells("t058commessa").Text
            LeggiLotti(CommessaAttiva)
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

        '0123456789012345678901234567890123
        'Color [A=255, R=227, G=175, B=201]
        '1234567890123456789012345678901234
        'Color [Black]

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
End Class
