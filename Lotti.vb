Imports Infragistics.Win.UltraWinGrid

Public Class Lotti
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub Lotti_Load(sender As Object, e As EventArgs) Handles Me.Load
        ImpostazioniControlli()
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
            LeggiLotti(ngrdCommesse.ActiveRow.Cells("t058commessa").Text)
        End If
    End Sub
    Private Sub ImpostazioniControlli()
        Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath.Replace("bin\Debug", "Resources") & "\CE.isl")

        ngrdCommesse.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free
        ngrdCommesse.DisplayLayout.Override.AllowColSwapping = False
        ngrdCommesse.Text = "Commesse Aperte"
        ngrdCommesse.DisplayLayout.Bands(0).ColHeadersVisible = False
        ngrdCommesse.DisplayLayout.Bands(0).Columns("t058commessa").Width = 60

        ngrdT059_Lotti.Text = ""
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059IdLotto").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Commessa").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059InsertUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059InsertDate").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UpdateUser").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059UpdateDate").Hidden = True
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Header.VisiblePosition = 0
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Width = 60
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Header.Caption = "Lotto"
        ngrdT059_Lotti.DisplayLayout.Bands(0).Columns("T059Lotto").Header.Appearance.BackColor = System.Drawing.Color.Orange

        ngrdT059_Lotti2.Text = ""
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Lotto").Width = 30
        ngrdT059_Lotti2.DisplayLayout.Bands(0).Columns("Selezionato").Width = 40

        ngrdT059_Lotti3.Text = ""

        ngrdT059_Lotti4.Text = ""

    End Sub

End Class
