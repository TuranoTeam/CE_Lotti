<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lotti
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LavorazioniEsterne_cbo", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Centro")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074LavorazioniEsterne")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T058_Commesse_Totale_Ore", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Centro")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Preventivo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obbiettivo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Esterne")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consuntivo")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T058_Commesse_Totale_Ore_Lotti_Selezionati", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Centro")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Preventivo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obbiettivo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Esterne")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consuntivo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T059_Lotti", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059IdLotto")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Commessa")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Lotto")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059DescrizioneLotto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059DataConsegna")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Sede")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Consegna")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Colonne")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059Note")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059NoteUfficioIndustrializzazione")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059LavorazioniEsterne")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059DataChiusura")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059DataAggiornamentoOre")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059UtenteAggiornamentoOre")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059InsertUser")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059InsertDate")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059UpdateUser")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059UpdateDate")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T059_Lotti_T074_LottiDettaglio")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T059_Lotti_T074_LottiDettaglio", 0)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Id")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Commessa")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Lotto")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Centro")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Obbiettivo")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074OreEsterne")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074LavorazioniEsterne")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074InsertUser")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074InsertDate")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074UpdateUser")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074UpdateDate")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T074Preventivo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consuntivo")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T058_Commesse_aperte", -1)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T058Commessa")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T055RagioneSociale")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T058Descrizione")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T058IdCommessa")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T058CartellaArchivio")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tmpLotti", -1)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lotto")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Selezionato")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T042_ListeQuadri", -1)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ordinamento")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Id")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Commessa")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Numerazione")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042PosizioneInterna")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042PosizioneOrdine")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Quantita")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Descrizione")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Lotto")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042StandBy")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Revisione")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042DataRevisione")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Note")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042ConsegnaMateriali")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Colonne")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042PrezzoUnitario")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042PrezzoVarianti")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042InsertUser")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042InsertDate")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042UpdateUser")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042UpdateDate")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042PrezzoTotale")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042DescrizioneLotto")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042_ListeQuadri_T117_ListeQuadriDettaglio")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042_ListeQuadri_T045_ListeQuadriElenchiMateriali")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T042_ListeQuadri_T117_ListeQuadriDettaglio", 0)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117Id")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117Commessa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117PosizioneInterna")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117Centro")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117OrePreventivate")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117InsertUser")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117InsertDate")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117UpdateUser")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T117UpdateDate")
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T042_ListeQuadri_T045_ListeQuadriElenchiMateriali", 0)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045Id")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045Commessa")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045PosizioneInterna")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045ElencoMateriali")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045Quantita")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045DataConsegnaMateriali")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045TipoConsegna")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045StandBy")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045Revisione")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045DataRevisione")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045Note")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045InsertUser")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045InsertDate")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045UpdateUser")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T045UpdateDate")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Descrizione")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T042Quantita")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T043Descrizione")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("T062_ListeQuadriNumerazione", -1)
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T062IdTipologia")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T062Tipologia")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("T062Attiva")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool9")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool10")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool5")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool6")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool7")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool8")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool5")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool6")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool7")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool8")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool9")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool10")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lotti))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel4 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGanttView1 = New Infragistics.Win.UltraWinGanttView.UltraGanttView()
        Me.UltraSplitter3 = New Infragistics.Win.Misc.UltraSplitter()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel9 = New Infragistics.Win.Misc.UltraPanel()
        Me.datDataFine = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.datDataInizio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ugbPercComp = New System.Windows.Forms.GroupBox()
        Me.numPercComp = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnPercCompPiu = New System.Windows.Forms.Button()
        Me.btnPercCompMeno = New System.Windows.Forms.Button()
        Me.ugbGanttOpzioni = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboT074LavorazioniEsterneG = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.LavorazioniEsternecboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LottiDataSet = New CE_Lotti.LottiDataSet()
        Me.uceAttivitaNA = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uceAttivitaFinite = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ugbDataInizio = New System.Windows.Forms.GroupBox()
        Me.numStartDay = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnStartPiu = New System.Windows.Forms.Button()
        Me.StartMeno = New System.Windows.Forms.Button()
        Me.ugbSpostamento = New System.Windows.Forms.GroupBox()
        Me.numActivityDay = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnActivityPiu = New System.Windows.Forms.Button()
        Me.btnActivityMeno = New System.Windows.Forms.Button()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ulUfficio13 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio16 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulIniziata = New Infragistics.Win.Misc.UltraLabel()
        Me.ulPianificata = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UlFinita = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio9 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulOltre = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio18 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulUfficio17 = New Infragistics.Win.Misc.UltraLabel()
        Me.ulCalcolato = New Infragistics.Win.Misc.UltraLabel()
        Me.ugbDataFine = New System.Windows.Forms.GroupBox()
        Me.numEndDay = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btnEndMeno = New System.Windows.Forms.Button()
        Me.btnEndPiu = New System.Windows.Forms.Button()
        Me.UltraPanel8 = New Infragistics.Win.Misc.UltraPanel()
        Me.ngrdT059_Lotti4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.T058CommesseTotaleOreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraPanel7 = New Infragistics.Win.Misc.UltraPanel()
        Me.ngrdT059_Lotti3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.T058CommesseTotaleOreLottiSelezionatiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraSplitter1 = New Infragistics.Win.Misc.UltraSplitter()
        Me.UltraPanel6 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.ngrdT059_Lotti = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.T059LottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraSplitter4 = New Infragistics.Win.Misc.UltraSplitter()
        Me.UltraPanel10 = New Infragistics.Win.Misc.UltraPanel()
        Me.ngrdCommesse = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.T058CommesseaperteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraPanel11 = New Infragistics.Win.Misc.UltraPanel()
        Me.lblRicercaCommessa = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRicercaCommessa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraSplitter2 = New Infragistics.Win.Misc.UltraSplitter()
        Me.UltraPanel5 = New Infragistics.Win.Misc.UltraPanel()
        Me.ngrdT059_Lotti2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TmpLottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ngrdT042_ListeQuadri = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.T042ListeQuadriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ugT042Totali = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cboT042Numerazione = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.T062ListeQuadriNumerazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraPanelResto = New Infragistics.Win.Misc.UltraPanel()
        Me.TabControlPrincipale = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UTBManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Lotti_Fill_Panel = New System.Windows.Forms.Panel()
        Me.UltraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.T059_LottiTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T059_LottiTableAdapter()
        Me.T074_LottiDettaglioTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T074_LottiDettaglioTableAdapter()
        Me.T058_Commesse_aperteTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T058_Commesse_aperteTableAdapter()
        Me.T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter()
        Me.T058_Commesse_Totale_OreTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T058_Commesse_Totale_OreTableAdapter()
        Me.T059_Lotti_SelezionaTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T059_Lotti_SelezionaTableAdapter()
        Me.TmpLottiTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.tmpLottiTableAdapter()
        Me.T059_Lotto_SelezionaTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T059_Lotto_SelezionaTableAdapter()
        Me.TtmConfigurazioneGrigliaTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.TtmConfigurazioneGrigliaTableAdapter()
        Me.T108_UfficiTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T108_UfficiTableAdapter()
        Me.TtmConfigurazioneGeneraleTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.TtmConfigurazioneGeneraleTableAdapter()
        Me.T072_GantPTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T072_GantPTableAdapter()
        Me.TableAdapterGantP = New CE_Lotti.LottiDataSetTableAdapters.TableAdapterGantP()
        Me.LavorazioniEsterne_cboTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.LavorazioniEsterne_cboTableAdapter()
        Me.Inserimento_LottoTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.Inserimento_LottoTableAdapter()
        Me.T042_ListeQuadriTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T042_ListeQuadriTableAdapter()
        Me.T117_ListeQuadriDettaglioTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T117_ListeQuadriDettaglioTableAdapter()
        Me.T045_ListeQuadriElenchiMaterialiTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T045_ListeQuadriElenchiMaterialiTableAdapter()
        Me.T042_MagicTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T042_MagicTableAdapter()
        Me.T062_ListeQuadriNumerazioneTableAdapter = New CE_Lotti.LottiDataSetTableAdapters.T062_ListeQuadriNumerazioneTableAdapter()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.UltraPanel4.ClientArea.SuspendLayout()
        Me.UltraPanel4.SuspendLayout()
        CType(Me.UltraGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        Me.UltraPanel9.ClientArea.SuspendLayout()
        Me.UltraPanel9.SuspendLayout()
        CType(Me.datDataFine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDataInizio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbPercComp.SuspendLayout()
        CType(Me.numPercComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugbGanttOpzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbGanttOpzioni.SuspendLayout()
        CType(Me.cboT074LavorazioniEsterneG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LavorazioniEsternecboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LottiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uceAttivitaNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uceAttivitaFinite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbDataInizio.SuspendLayout()
        CType(Me.numStartDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbSpostamento.SuspendLayout()
        CType(Me.numActivityDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.ugbDataFine.SuspendLayout()
        CType(Me.numEndDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel8.ClientArea.SuspendLayout()
        Me.UltraPanel8.SuspendLayout()
        CType(Me.ngrdT059_Lotti4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T058CommesseTotaleOreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel7.ClientArea.SuspendLayout()
        Me.UltraPanel7.SuspendLayout()
        CType(Me.ngrdT059_Lotti3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T058CommesseTotaleOreLottiSelezionatiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel6.ClientArea.SuspendLayout()
        Me.UltraPanel6.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.ngrdT059_Lotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T059LottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel10.ClientArea.SuspendLayout()
        Me.UltraPanel10.SuspendLayout()
        CType(Me.ngrdCommesse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T058CommesseaperteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel11.ClientArea.SuspendLayout()
        Me.UltraPanel11.SuspendLayout()
        CType(Me.txtRicercaCommessa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel5.ClientArea.SuspendLayout()
        Me.UltraPanel5.SuspendLayout()
        CType(Me.ngrdT059_Lotti2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmpLottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ngrdT042_ListeQuadri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T042ListeQuadriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugT042Totali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.cboT042Numerazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T062ListeQuadriNumerazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanelResto.ClientArea.SuspendLayout()
        Me.UltraPanelResto.SuspendLayout()
        CType(Me.TabControlPrincipale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPrincipale.SuspendLayout()
        CType(Me.UTBManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1689, 786)
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel4)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraSplitter3)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraSplitter1)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel6)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1689, 786)
        Me.UltraPanel1.TabIndex = 6
        '
        'UltraPanel4
        '
        '
        'UltraPanel4.ClientArea
        '
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraGanttView1)
        Me.UltraPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel4.Location = New System.Drawing.Point(0, 420)
        Me.UltraPanel4.Name = "UltraPanel4"
        Me.UltraPanel4.Size = New System.Drawing.Size(1689, 366)
        Me.UltraPanel4.TabIndex = 6
        '
        'UltraGanttView1
        '
        Me.UltraGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Constraint").VisiblePosition = 6
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("ConstraintDateTime").VisiblePosition = 7
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Dependencies").VisiblePosition = 4
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Deadline").VisiblePosition = 8
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Duration").VisiblePosition = 1
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("EndDateTime").VisiblePosition = 3
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Milestone").VisiblePosition = 9
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Name").VisiblePosition = 0
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Notes").VisiblePosition = 10
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("PercentComplete").VisiblePosition = 11
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("Resources").VisiblePosition = 5
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("StartDateTime").VisiblePosition = 2
        Me.UltraGanttView1.GridSettings.ColumnSettings.GetValue("RowNumber").VisiblePosition = 12
        Me.UltraGanttView1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGanttView1.Name = "UltraGanttView1"
        Me.UltraGanttView1.Size = New System.Drawing.Size(1689, 366)
        Me.UltraGanttView1.TabIndex = 11
        Me.UltraGanttView1.Text = "UltraGanttView1"
        Me.UltraGanttView1.VerticalSplitterMinimumResizeWidth = 10
        '
        'UltraSplitter3
        '
        Me.UltraSplitter3.BackColor = System.Drawing.Color.Transparent
        Me.UltraSplitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraSplitter3.Location = New System.Drawing.Point(0, 410)
        Me.UltraSplitter3.Name = "UltraSplitter3"
        Me.UltraSplitter3.RestoreExtent = 170
        Me.UltraSplitter3.Size = New System.Drawing.Size(1689, 10)
        Me.UltraSplitter3.TabIndex = 5
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraPanel9)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraPanel8)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraPanel7)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 240)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(1689, 170)
        Me.UltraPanel2.TabIndex = 4
        '
        'UltraPanel9
        '
        '
        'UltraPanel9.ClientArea
        '
        Me.UltraPanel9.ClientArea.Controls.Add(Me.datDataFine)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.datDataInizio)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.ugbPercComp)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.ugbGanttOpzioni)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.ugbDataInizio)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.ugbSpostamento)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.UltraGroupBox2)
        Me.UltraPanel9.ClientArea.Controls.Add(Me.ugbDataFine)
        Me.UltraPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel9.Location = New System.Drawing.Point(1014, 0)
        Me.UltraPanel9.Name = "UltraPanel9"
        Me.UltraPanel9.Size = New System.Drawing.Size(675, 170)
        Me.UltraPanel9.TabIndex = 43
        '
        'datDataFine
        '
        Me.datDataFine.Location = New System.Drawing.Point(141, 75)
        Me.datDataFine.Name = "datDataFine"
        Me.datDataFine.Size = New System.Drawing.Size(100, 21)
        Me.datDataFine.TabIndex = 30
        '
        'datDataInizio
        '
        Me.datDataInizio.Location = New System.Drawing.Point(37, 75)
        Me.datDataInizio.Name = "datDataInizio"
        Me.datDataInizio.Size = New System.Drawing.Size(100, 21)
        Me.datDataInizio.TabIndex = 29
        '
        'ugbPercComp
        '
        Me.ugbPercComp.Controls.Add(Me.numPercComp)
        Me.ugbPercComp.Controls.Add(Me.btnPercCompPiu)
        Me.ugbPercComp.Controls.Add(Me.btnPercCompMeno)
        Me.ugbPercComp.Location = New System.Drawing.Point(141, 116)
        Me.ugbPercComp.Name = "ugbPercComp"
        Me.ugbPercComp.Size = New System.Drawing.Size(100, 40)
        Me.ugbPercComp.TabIndex = 28
        Me.ugbPercComp.TabStop = False
        Me.ugbPercComp.Text = "Completamento"
        '
        'numPercComp
        '
        Me.numPercComp.Location = New System.Drawing.Point(25, 15)
        Me.numPercComp.Name = "numPercComp"
        Me.numPercComp.Size = New System.Drawing.Size(50, 21)
        Me.numPercComp.TabIndex = 30
        '
        'btnPercCompPiu
        '
        Me.btnPercCompPiu.Location = New System.Drawing.Point(77, 16)
        Me.btnPercCompPiu.Name = "btnPercCompPiu"
        Me.btnPercCompPiu.Size = New System.Drawing.Size(21, 21)
        Me.btnPercCompPiu.TabIndex = 12
        Me.btnPercCompPiu.Text = "+"
        Me.btnPercCompPiu.UseVisualStyleBackColor = True
        '
        'btnPercCompMeno
        '
        Me.btnPercCompMeno.Location = New System.Drawing.Point(2, 16)
        Me.btnPercCompMeno.Name = "btnPercCompMeno"
        Me.btnPercCompMeno.Size = New System.Drawing.Size(21, 21)
        Me.btnPercCompMeno.TabIndex = 13
        Me.btnPercCompMeno.Text = "-"
        Me.btnPercCompMeno.UseVisualStyleBackColor = True
        '
        'ugbGanttOpzioni
        '
        Me.ugbGanttOpzioni.Controls.Add(Me.cboT074LavorazioniEsterneG)
        Me.ugbGanttOpzioni.Controls.Add(Me.uceAttivitaNA)
        Me.ugbGanttOpzioni.Controls.Add(Me.uceAttivitaFinite)
        Me.ugbGanttOpzioni.Dock = System.Windows.Forms.DockStyle.Right
        Me.ugbGanttOpzioni.Location = New System.Drawing.Point(255, 0)
        Me.ugbGanttOpzioni.Name = "ugbGanttOpzioni"
        Me.ugbGanttOpzioni.Size = New System.Drawing.Size(140, 170)
        Me.ugbGanttOpzioni.TabIndex = 26
        Me.ugbGanttOpzioni.Text = "Opzioni"
        '
        'cboT074LavorazioniEsterneG
        '
        Me.cboT074LavorazioniEsterneG.DataSource = Me.LavorazioniEsternecboBindingSource
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cboT074LavorazioniEsterneG.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cboT074LavorazioniEsterneG.DisplayMember = "T074LavorazioniEsterne"
        Me.cboT074LavorazioniEsterneG.Location = New System.Drawing.Point(14, 139)
        Me.cboT074LavorazioniEsterneG.Name = "cboT074LavorazioniEsterneG"
        Me.cboT074LavorazioniEsterneG.Size = New System.Drawing.Size(120, 22)
        Me.cboT074LavorazioniEsterneG.TabIndex = 16
        Me.cboT074LavorazioniEsterneG.Text = "cboT074LavorazioniEsterneG"
        Me.cboT074LavorazioniEsterneG.ValueMember = "T074LavorazioniEsterne"
        Me.cboT074LavorazioniEsterneG.Visible = False
        '
        'LavorazioniEsternecboBindingSource
        '
        Me.LavorazioniEsternecboBindingSource.DataMember = "LavorazioniEsterne_cbo"
        Me.LavorazioniEsternecboBindingSource.DataSource = Me.LottiDataSet
        '
        'LottiDataSet
        '
        Me.LottiDataSet.DataSetName = "LottiDataSet"
        Me.LottiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uceAttivitaNA
        '
        Me.uceAttivitaNA.Location = New System.Drawing.Point(14, 19)
        Me.uceAttivitaNA.Name = "uceAttivitaNA"
        Me.uceAttivitaNA.Size = New System.Drawing.Size(120, 30)
        Me.uceAttivitaNA.TabIndex = 14
        Me.uceAttivitaNA.Text = "Visualizza Attività Non Applicabili"
        '
        'uceAttivitaFinite
        '
        Me.uceAttivitaFinite.Location = New System.Drawing.Point(14, 51)
        Me.uceAttivitaFinite.Name = "uceAttivitaFinite"
        Me.uceAttivitaFinite.Size = New System.Drawing.Size(120, 30)
        Me.uceAttivitaFinite.TabIndex = 15
        Me.uceAttivitaFinite.Text = "Visualizza Attività Finite"
        '
        'ugbDataInizio
        '
        Me.ugbDataInizio.Controls.Add(Me.numStartDay)
        Me.ugbDataInizio.Controls.Add(Me.btnStartPiu)
        Me.ugbDataInizio.Controls.Add(Me.StartMeno)
        Me.ugbDataInizio.Location = New System.Drawing.Point(35, 27)
        Me.ugbDataInizio.Name = "ugbDataInizio"
        Me.ugbDataInizio.Size = New System.Drawing.Size(100, 40)
        Me.ugbDataInizio.TabIndex = 25
        Me.ugbDataInizio.TabStop = False
        Me.ugbDataInizio.Text = "Data Inizio"
        '
        'numStartDay
        '
        Me.numStartDay.Location = New System.Drawing.Point(25, 16)
        Me.numStartDay.Name = "numStartDay"
        Me.numStartDay.Size = New System.Drawing.Size(50, 21)
        Me.numStartDay.TabIndex = 29
        '
        'btnStartPiu
        '
        Me.btnStartPiu.Location = New System.Drawing.Point(76, 16)
        Me.btnStartPiu.Name = "btnStartPiu"
        Me.btnStartPiu.Size = New System.Drawing.Size(21, 21)
        Me.btnStartPiu.TabIndex = 6
        Me.btnStartPiu.Text = "+"
        Me.btnStartPiu.UseVisualStyleBackColor = True
        '
        'StartMeno
        '
        Me.StartMeno.Location = New System.Drawing.Point(3, 16)
        Me.StartMeno.Name = "StartMeno"
        Me.StartMeno.Size = New System.Drawing.Size(21, 21)
        Me.StartMeno.TabIndex = 7
        Me.StartMeno.Text = "-"
        Me.StartMeno.UseVisualStyleBackColor = True
        '
        'ugbSpostamento
        '
        Me.ugbSpostamento.Controls.Add(Me.numActivityDay)
        Me.ugbSpostamento.Controls.Add(Me.btnActivityPiu)
        Me.ugbSpostamento.Controls.Add(Me.btnActivityMeno)
        Me.ugbSpostamento.Location = New System.Drawing.Point(35, 116)
        Me.ugbSpostamento.Name = "ugbSpostamento"
        Me.ugbSpostamento.Size = New System.Drawing.Size(100, 40)
        Me.ugbSpostamento.TabIndex = 27
        Me.ugbSpostamento.TabStop = False
        Me.ugbSpostamento.Text = "Spostamento"
        '
        'numActivityDay
        '
        Me.numActivityDay.Location = New System.Drawing.Point(24, 16)
        Me.numActivityDay.Name = "numActivityDay"
        Me.numActivityDay.Size = New System.Drawing.Size(50, 21)
        Me.numActivityDay.TabIndex = 30
        '
        'btnActivityPiu
        '
        Me.btnActivityPiu.Location = New System.Drawing.Point(76, 16)
        Me.btnActivityPiu.Name = "btnActivityPiu"
        Me.btnActivityPiu.Size = New System.Drawing.Size(21, 21)
        Me.btnActivityPiu.TabIndex = 12
        Me.btnActivityPiu.Text = "+"
        Me.btnActivityPiu.UseVisualStyleBackColor = True
        '
        'btnActivityMeno
        '
        Me.btnActivityMeno.Location = New System.Drawing.Point(2, 16)
        Me.btnActivityMeno.Name = "btnActivityMeno"
        Me.btnActivityMeno.Size = New System.Drawing.Size(21, 21)
        Me.btnActivityMeno.TabIndex = 13
        Me.btnActivityMeno.Text = "-"
        Me.btnActivityMeno.UseVisualStyleBackColor = True
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio13)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio16)
        Me.UltraGroupBox2.Controls.Add(Me.ulIniziata)
        Me.UltraGroupBox2.Controls.Add(Me.ulPianificata)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio7)
        Me.UltraGroupBox2.Controls.Add(Me.UlFinita)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio9)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio10)
        Me.UltraGroupBox2.Controls.Add(Me.ulOltre)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio18)
        Me.UltraGroupBox2.Controls.Add(Me.ulUfficio17)
        Me.UltraGroupBox2.Controls.Add(Me.ulCalcolato)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox2.Location = New System.Drawing.Point(395, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(280, 170)
        Me.UltraGroupBox2.TabIndex = 27
        Me.UltraGroupBox2.Text = "Legenda"
        '
        'ulUfficio13
        '
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.ulUfficio13.Appearance = Appearance1
        Me.ulUfficio13.Location = New System.Drawing.Point(22, 27)
        Me.ulUfficio13.Name = "ulUfficio13"
        Me.ulUfficio13.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio13.TabIndex = 41
        Me.ulUfficio13.Text = "Commerciale"
        '
        'ulUfficio16
        '
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.ulUfficio16.Appearance = Appearance2
        Me.ulUfficio16.Location = New System.Drawing.Point(148, 65)
        Me.ulUfficio16.Name = "ulUfficio16"
        Me.ulUfficio16.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio16.TabIndex = 43
        Me.ulUfficio16.Text = "Officina C1"
        '
        'ulIniziata
        '
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        Me.ulIniziata.Appearance = Appearance3
        Me.ulIniziata.Location = New System.Drawing.Point(22, 65)
        Me.ulIniziata.Name = "ulIniziata"
        Me.ulIniziata.Size = New System.Drawing.Size(120, 18)
        Me.ulIniziata.TabIndex = 48
        Me.ulIniziata.Text = "Iniziata"
        '
        'ulPianificata
        '
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        Me.ulPianificata.Appearance = Appearance4
        Me.ulPianificata.Location = New System.Drawing.Point(22, 46)
        Me.ulPianificata.Name = "ulPianificata"
        Me.ulPianificata.Size = New System.Drawing.Size(120, 18)
        Me.ulPianificata.TabIndex = 51
        Me.ulPianificata.Text = "Pianificata"
        '
        'ulUfficio7
        '
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance5.TextHAlignAsString = "Center"
        Appearance5.TextVAlignAsString = "Middle"
        Me.ulUfficio7.Appearance = Appearance5
        Me.ulUfficio7.Location = New System.Drawing.Point(148, 46)
        Me.ulUfficio7.Name = "ulUfficio7"
        Me.ulUfficio7.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio7.TabIndex = 42
        Me.ulUfficio7.Text = "Ufficio Acquisti"
        '
        'UlFinita
        '
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UlFinita.Appearance = Appearance6
        Me.UlFinita.Location = New System.Drawing.Point(148, 84)
        Me.UlFinita.Name = "UlFinita"
        Me.UlFinita.Size = New System.Drawing.Size(120, 18)
        Me.UlFinita.TabIndex = 52
        Me.UlFinita.Text = "Finita"
        '
        'ulUfficio9
        '
        Appearance7.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance7.TextHAlignAsString = "Center"
        Appearance7.TextVAlignAsString = "Middle"
        Me.ulUfficio9.Appearance = Appearance7
        Me.ulUfficio9.Location = New System.Drawing.Point(22, 122)
        Me.ulUfficio9.Name = "ulUfficio9"
        Me.ulUfficio9.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio9.TabIndex = 47
        Me.ulUfficio9.Text = "Ufficio Tecnico"
        '
        'ulUfficio10
        '
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextVAlignAsString = "Middle"
        Me.ulUfficio10.Appearance = Appearance8
        Me.ulUfficio10.Location = New System.Drawing.Point(22, 84)
        Me.ulUfficio10.Name = "ulUfficio10"
        Me.ulUfficio10.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio10.TabIndex = 44
        Me.ulUfficio10.Text = "Officina C2"
        '
        'ulOltre
        '
        Appearance9.BackColor = System.Drawing.Color.Red
        Appearance9.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance9.TextHAlignAsString = "Center"
        Appearance9.TextVAlignAsString = "Middle"
        Me.ulOltre.Appearance = Appearance9
        Me.ulOltre.Location = New System.Drawing.Point(148, 103)
        Me.ulOltre.Name = "ulOltre"
        Me.ulOltre.Size = New System.Drawing.Size(120, 18)
        Me.ulOltre.TabIndex = 50
        Me.ulOltre.Text = "Oltre"
        '
        'ulUfficio18
        '
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance10.TextHAlignAsString = "Center"
        Appearance10.TextVAlignAsString = "Middle"
        Me.ulUfficio18.Appearance = Appearance10
        Me.ulUfficio18.Location = New System.Drawing.Point(22, 103)
        Me.ulUfficio18.Name = "ulUfficio18"
        Me.ulUfficio18.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio18.TabIndex = 46
        Me.ulUfficio18.Text = "Cantiere C3"
        '
        'ulUfficio17
        '
        Appearance11.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance11.TextHAlignAsString = "Center"
        Appearance11.TextVAlignAsString = "Middle"
        Me.ulUfficio17.Appearance = Appearance11
        Me.ulUfficio17.Location = New System.Drawing.Point(22, 141)
        Me.ulUfficio17.Name = "ulUfficio17"
        Me.ulUfficio17.Size = New System.Drawing.Size(120, 18)
        Me.ulUfficio17.TabIndex = 45
        Me.ulUfficio17.Text = "OfficinaSbarre"
        '
        'ulCalcolato
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.TextHAlignAsString = "Center"
        Appearance12.TextVAlignAsString = "Middle"
        Me.ulCalcolato.Appearance = Appearance12
        Me.ulCalcolato.Location = New System.Drawing.Point(148, 27)
        Me.ulCalcolato.Name = "ulCalcolato"
        Me.ulCalcolato.Size = New System.Drawing.Size(120, 18)
        Me.ulCalcolato.TabIndex = 49
        Me.ulCalcolato.Text = "Calcolato"
        Me.ulCalcolato.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugbDataFine
        '
        Me.ugbDataFine.Controls.Add(Me.numEndDay)
        Me.ugbDataFine.Controls.Add(Me.btnEndMeno)
        Me.ugbDataFine.Controls.Add(Me.btnEndPiu)
        Me.ugbDataFine.Location = New System.Drawing.Point(141, 27)
        Me.ugbDataFine.Name = "ugbDataFine"
        Me.ugbDataFine.Size = New System.Drawing.Size(100, 40)
        Me.ugbDataFine.TabIndex = 26
        Me.ugbDataFine.TabStop = False
        Me.ugbDataFine.Text = "Data Fine"
        '
        'numEndDay
        '
        Me.numEndDay.Location = New System.Drawing.Point(26, 15)
        Me.numEndDay.Name = "numEndDay"
        Me.numEndDay.Size = New System.Drawing.Size(50, 21)
        Me.numEndDay.TabIndex = 30
        '
        'btnEndMeno
        '
        Me.btnEndMeno.Location = New System.Drawing.Point(2, 16)
        Me.btnEndMeno.Name = "btnEndMeno"
        Me.btnEndMeno.Size = New System.Drawing.Size(21, 21)
        Me.btnEndMeno.TabIndex = 7
        Me.btnEndMeno.Text = "-"
        Me.btnEndMeno.UseVisualStyleBackColor = True
        '
        'btnEndPiu
        '
        Me.btnEndPiu.Location = New System.Drawing.Point(77, 16)
        Me.btnEndPiu.Name = "btnEndPiu"
        Me.btnEndPiu.Size = New System.Drawing.Size(21, 21)
        Me.btnEndPiu.TabIndex = 9
        Me.btnEndPiu.Text = "+"
        Me.btnEndPiu.UseVisualStyleBackColor = True
        '
        'UltraPanel8
        '
        '
        'UltraPanel8.ClientArea
        '
        Me.UltraPanel8.ClientArea.Controls.Add(Me.ngrdT059_Lotti4)
        Me.UltraPanel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanel8.Location = New System.Drawing.Point(507, 0)
        Me.UltraPanel8.Name = "UltraPanel8"
        Me.UltraPanel8.Size = New System.Drawing.Size(507, 170)
        Me.UltraPanel8.TabIndex = 5
        '
        'ngrdT059_Lotti4
        '
        Me.ngrdT059_Lotti4.DataSource = Me.T058CommesseTotaleOreBindingSource
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ngrdT059_Lotti4.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ngrdT059_Lotti4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdT059_Lotti4.Location = New System.Drawing.Point(0, 0)
        Me.ngrdT059_Lotti4.Name = "ngrdT059_Lotti4"
        Me.ngrdT059_Lotti4.Size = New System.Drawing.Size(507, 170)
        Me.ngrdT059_Lotti4.TabIndex = 10
        Me.ngrdT059_Lotti4.Text = "ngrdT059_Lotti4"
        '
        'T058CommesseTotaleOreBindingSource
        '
        Me.T058CommesseTotaleOreBindingSource.DataMember = "T058_Commesse_Totale_Ore"
        Me.T058CommesseTotaleOreBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraPanel7
        '
        '
        'UltraPanel7.ClientArea
        '
        Me.UltraPanel7.ClientArea.Controls.Add(Me.ngrdT059_Lotti3)
        Me.UltraPanel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanel7.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel7.Name = "UltraPanel7"
        Me.UltraPanel7.Size = New System.Drawing.Size(507, 170)
        Me.UltraPanel7.TabIndex = 4
        '
        'ngrdT059_Lotti3
        '
        Me.ngrdT059_Lotti3.DataSource = Me.T058CommesseTotaleOreLottiSelezionatiBindingSource
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ngrdT059_Lotti3.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ngrdT059_Lotti3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdT059_Lotti3.Location = New System.Drawing.Point(0, 0)
        Me.ngrdT059_Lotti3.Name = "ngrdT059_Lotti3"
        Me.ngrdT059_Lotti3.Size = New System.Drawing.Size(507, 170)
        Me.ngrdT059_Lotti3.TabIndex = 44
        Me.ngrdT059_Lotti3.Text = "ngrdT059_Lotti3"
        '
        'T058CommesseTotaleOreLottiSelezionatiBindingSource
        '
        Me.T058CommesseTotaleOreLottiSelezionatiBindingSource.DataMember = "T058_Commesse_Totale_Ore_Lotti_Selezionati"
        Me.T058CommesseTotaleOreLottiSelezionatiBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraSplitter1
        '
        Me.UltraSplitter1.BackColor = System.Drawing.Color.Transparent
        Me.UltraSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraSplitter1.Location = New System.Drawing.Point(0, 230)
        Me.UltraSplitter1.Name = "UltraSplitter1"
        Me.UltraSplitter1.RestoreExtent = 200
        Me.UltraSplitter1.Size = New System.Drawing.Size(1689, 10)
        Me.UltraSplitter1.TabIndex = 3
        '
        'UltraPanel6
        '
        '
        'UltraPanel6.ClientArea
        '
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraPanel3)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraSplitter2)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraPanel5)
        Me.UltraPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel6.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel6.Name = "UltraPanel6"
        Me.UltraPanel6.Size = New System.Drawing.Size(1689, 230)
        Me.UltraPanel6.TabIndex = 2
        '
        'UltraPanel3
        '
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.ngrdT059_Lotti)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.UltraSplitter4)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.UltraPanel10)
        Me.UltraPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel3.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(1588, 230)
        Me.UltraPanel3.TabIndex = 6
        '
        'ngrdT059_Lotti
        '
        Me.ngrdT059_Lotti.DataSource = Me.T059LottiBindingSource
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn27.Header.VisiblePosition = 12
        UltraGridColumn28.Header.VisiblePosition = 13
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn30.Header.VisiblePosition = 15
        UltraGridColumn31.Header.VisiblePosition = 16
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33})
        UltraGridColumn34.Header.VisiblePosition = 0
        UltraGridColumn35.Header.VisiblePosition = 1
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn37.Header.VisiblePosition = 3
        UltraGridColumn38.Header.VisiblePosition = 4
        UltraGridColumn39.Header.VisiblePosition = 5
        UltraGridColumn40.Header.VisiblePosition = 6
        UltraGridColumn41.Header.VisiblePosition = 7
        UltraGridColumn42.Header.VisiblePosition = 8
        UltraGridColumn43.Header.VisiblePosition = 9
        UltraGridColumn44.Header.VisiblePosition = 10
        UltraGridColumn45.Header.VisiblePosition = 11
        UltraGridColumn46.Header.VisiblePosition = 12
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46})
        Me.ngrdT059_Lotti.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ngrdT059_Lotti.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ngrdT059_Lotti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdT059_Lotti.Location = New System.Drawing.Point(232, 0)
        Me.ngrdT059_Lotti.Name = "ngrdT059_Lotti"
        Me.ngrdT059_Lotti.Size = New System.Drawing.Size(1356, 230)
        Me.ngrdT059_Lotti.TabIndex = 8
        Me.ngrdT059_Lotti.Text = "ngrdT059_Lotti"
        '
        'T059LottiBindingSource
        '
        Me.T059LottiBindingSource.DataMember = "T059_Lotti"
        Me.T059LottiBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraSplitter4
        '
        Me.UltraSplitter4.BackColor = System.Drawing.Color.Transparent
        Me.UltraSplitter4.Location = New System.Drawing.Point(222, 0)
        Me.UltraSplitter4.Name = "UltraSplitter4"
        Me.UltraSplitter4.RestoreExtent = 222
        Me.UltraSplitter4.Size = New System.Drawing.Size(10, 230)
        Me.UltraSplitter4.TabIndex = 7
        '
        'UltraPanel10
        '
        '
        'UltraPanel10.ClientArea
        '
        Me.UltraPanel10.ClientArea.Controls.Add(Me.ngrdCommesse)
        Me.UltraPanel10.ClientArea.Controls.Add(Me.UltraPanel11)
        Me.UltraPanel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanel10.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel10.Name = "UltraPanel10"
        Me.UltraPanel10.Size = New System.Drawing.Size(222, 230)
        Me.UltraPanel10.TabIndex = 3
        '
        'ngrdCommesse
        '
        Me.ngrdCommesse.DataSource = Me.T058CommesseaperteBindingSource
        UltraGridColumn47.Header.VisiblePosition = 0
        UltraGridColumn48.Header.VisiblePosition = 1
        UltraGridColumn49.Header.VisiblePosition = 2
        UltraGridColumn50.Header.VisiblePosition = 3
        UltraGridColumn51.Header.VisiblePosition = 4
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51})
        Me.ngrdCommesse.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ngrdCommesse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdCommesse.Location = New System.Drawing.Point(0, 0)
        Me.ngrdCommesse.Name = "ngrdCommesse"
        Me.ngrdCommesse.Size = New System.Drawing.Size(222, 207)
        Me.ngrdCommesse.TabIndex = 7
        Me.ngrdCommesse.Text = "UltraGrid1"
        '
        'T058CommesseaperteBindingSource
        '
        Me.T058CommesseaperteBindingSource.DataMember = "T058_Commesse_aperte"
        Me.T058CommesseaperteBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraPanel11
        '
        '
        'UltraPanel11.ClientArea
        '
        Me.UltraPanel11.ClientArea.Controls.Add(Me.lblRicercaCommessa)
        Me.UltraPanel11.ClientArea.Controls.Add(Me.txtRicercaCommessa)
        Me.UltraPanel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel11.Location = New System.Drawing.Point(0, 207)
        Me.UltraPanel11.Name = "UltraPanel11"
        Me.UltraPanel11.Size = New System.Drawing.Size(222, 23)
        Me.UltraPanel11.TabIndex = 0
        '
        'lblRicercaCommessa
        '
        Appearance13.TextHAlignAsString = "Center"
        Appearance13.TextVAlignAsString = "Middle"
        Me.lblRicercaCommessa.Appearance = Appearance13
        Me.lblRicercaCommessa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRicercaCommessa.Location = New System.Drawing.Point(0, 0)
        Me.lblRicercaCommessa.Name = "lblRicercaCommessa"
        Me.lblRicercaCommessa.Size = New System.Drawing.Size(122, 23)
        Me.lblRicercaCommessa.TabIndex = 1
        Me.lblRicercaCommessa.Text = "Ricerca Commessa"
        '
        'txtRicercaCommessa
        '
        Me.txtRicercaCommessa.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtRicercaCommessa.Location = New System.Drawing.Point(122, 0)
        Me.txtRicercaCommessa.Name = "txtRicercaCommessa"
        Me.txtRicercaCommessa.Size = New System.Drawing.Size(100, 21)
        Me.txtRicercaCommessa.TabIndex = 0
        '
        'UltraSplitter2
        '
        Me.UltraSplitter2.BackColor = System.Drawing.Color.Transparent
        Me.UltraSplitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraSplitter2.Location = New System.Drawing.Point(1588, 0)
        Me.UltraSplitter2.Name = "UltraSplitter2"
        Me.UltraSplitter2.RestoreExtent = 91
        Me.UltraSplitter2.Size = New System.Drawing.Size(10, 230)
        Me.UltraSplitter2.TabIndex = 5
        '
        'UltraPanel5
        '
        '
        'UltraPanel5.ClientArea
        '
        Me.UltraPanel5.ClientArea.Controls.Add(Me.ngrdT059_Lotti2)
        Me.UltraPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraPanel5.Location = New System.Drawing.Point(1598, 0)
        Me.UltraPanel5.Name = "UltraPanel5"
        Me.UltraPanel5.Size = New System.Drawing.Size(91, 230)
        Me.UltraPanel5.TabIndex = 4
        '
        'ngrdT059_Lotti2
        '
        Me.ngrdT059_Lotti2.DataSource = Me.TmpLottiBindingSource
        UltraGridColumn52.Header.VisiblePosition = 0
        UltraGridColumn53.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn52, UltraGridColumn53})
        Me.ngrdT059_Lotti2.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.ngrdT059_Lotti2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdT059_Lotti2.Location = New System.Drawing.Point(0, 0)
        Me.ngrdT059_Lotti2.Name = "ngrdT059_Lotti2"
        Me.ngrdT059_Lotti2.Size = New System.Drawing.Size(91, 230)
        Me.ngrdT059_Lotti2.TabIndex = 8
        Me.ngrdT059_Lotti2.Text = "ngrdT059_Lotti2"
        '
        'TmpLottiBindingSource
        '
        Me.TmpLottiBindingSource.DataMember = "tmpLotti"
        Me.TmpLottiBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1689, 786)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ngrdT042_ListeQuadri)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ugT042Totali)
        Me.SplitContainer1.Size = New System.Drawing.Size(1689, 786)
        Me.SplitContainer1.SplitterDistance = 657
        Me.SplitContainer1.TabIndex = 0
        '
        'ngrdT042_ListeQuadri
        '
        Me.ngrdT042_ListeQuadri.DataSource = Me.T042ListeQuadriBindingSource
        UltraGridColumn54.Header.VisiblePosition = 0
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridColumn56.Header.VisiblePosition = 2
        UltraGridColumn57.Header.VisiblePosition = 3
        UltraGridColumn58.Header.VisiblePosition = 4
        UltraGridColumn59.Header.VisiblePosition = 5
        UltraGridColumn60.Header.VisiblePosition = 6
        UltraGridColumn61.Header.VisiblePosition = 7
        UltraGridColumn62.Header.VisiblePosition = 8
        UltraGridColumn63.Header.VisiblePosition = 9
        UltraGridColumn64.Header.VisiblePosition = 10
        UltraGridColumn65.Header.VisiblePosition = 11
        UltraGridColumn66.Header.VisiblePosition = 12
        UltraGridColumn67.Header.VisiblePosition = 13
        UltraGridColumn68.Header.VisiblePosition = 14
        UltraGridColumn69.Header.VisiblePosition = 15
        UltraGridColumn70.Header.VisiblePosition = 16
        UltraGridColumn71.Header.VisiblePosition = 17
        UltraGridColumn72.Header.VisiblePosition = 18
        UltraGridColumn73.Header.VisiblePosition = 19
        UltraGridColumn74.Header.VisiblePosition = 20
        UltraGridColumn75.Header.VisiblePosition = 21
        UltraGridColumn76.Header.VisiblePosition = 22
        UltraGridColumn77.Header.VisiblePosition = 23
        UltraGridColumn78.Header.VisiblePosition = 24
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78})
        UltraGridColumn79.Header.VisiblePosition = 0
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridColumn83.Header.VisiblePosition = 4
        UltraGridColumn84.Header.VisiblePosition = 5
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn86.Header.VisiblePosition = 7
        UltraGridColumn87.Header.VisiblePosition = 8
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn89.Header.VisiblePosition = 1
        UltraGridColumn90.Header.VisiblePosition = 2
        UltraGridColumn91.Header.VisiblePosition = 3
        UltraGridColumn92.Header.VisiblePosition = 4
        UltraGridColumn93.Header.VisiblePosition = 5
        UltraGridColumn94.Header.VisiblePosition = 6
        UltraGridColumn95.Header.VisiblePosition = 7
        UltraGridColumn96.Header.VisiblePosition = 8
        UltraGridColumn97.Header.VisiblePosition = 9
        UltraGridColumn98.Header.VisiblePosition = 10
        UltraGridColumn99.Header.VisiblePosition = 11
        UltraGridColumn100.Header.VisiblePosition = 12
        UltraGridColumn101.Header.VisiblePosition = 13
        UltraGridColumn102.Header.VisiblePosition = 14
        UltraGridColumn103.Header.VisiblePosition = 15
        UltraGridColumn104.Header.VisiblePosition = 16
        UltraGridColumn105.Header.VisiblePosition = 17
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105})
        Me.ngrdT042_ListeQuadri.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.ngrdT042_ListeQuadri.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.ngrdT042_ListeQuadri.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.ngrdT042_ListeQuadri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ngrdT042_ListeQuadri.Location = New System.Drawing.Point(0, 0)
        Me.ngrdT042_ListeQuadri.Name = "ngrdT042_ListeQuadri"
        Me.ngrdT042_ListeQuadri.Size = New System.Drawing.Size(1689, 657)
        Me.ngrdT042_ListeQuadri.TabIndex = 9
        Me.ngrdT042_ListeQuadri.Text = "ngrdT042_ListeQuadri"
        '
        'T042ListeQuadriBindingSource
        '
        Me.T042ListeQuadriBindingSource.DataMember = "T042_ListeQuadri"
        Me.T042ListeQuadriBindingSource.DataSource = Me.LottiDataSet
        '
        'ugT042Totali
        '
        Me.ugT042Totali.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugT042Totali.Location = New System.Drawing.Point(0, 0)
        Me.ugT042Totali.Name = "ugT042Totali"
        Me.ugT042Totali.Size = New System.Drawing.Size(1689, 125)
        Me.ugT042Totali.TabIndex = 10
        Me.ugT042Totali.Text = "ugT042Totali"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.cboT042Numerazione)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1689, 786)
        '
        'cboT042Numerazione
        '
        Me.cboT042Numerazione.DataSource = Me.T062ListeQuadriNumerazioneBindingSource
        UltraGridColumn160.Header.VisiblePosition = 0
        UltraGridColumn161.Header.VisiblePosition = 1
        UltraGridColumn162.Header.VisiblePosition = 2
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn160, UltraGridColumn161, UltraGridColumn162})
        Me.cboT042Numerazione.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.cboT042Numerazione.DisplayMember = "T062Tipologia"
        Me.cboT042Numerazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboT042Numerazione.Location = New System.Drawing.Point(99, 42)
        Me.cboT042Numerazione.Name = "cboT042Numerazione"
        Me.cboT042Numerazione.Size = New System.Drawing.Size(100, 22)
        Me.cboT042Numerazione.TabIndex = 0
        Me.cboT042Numerazione.ValueMember = "T062IdTipologia"
        '
        'T062ListeQuadriNumerazioneBindingSource
        '
        Me.T062ListeQuadriNumerazioneBindingSource.DataMember = "T062_ListeQuadriNumerazione"
        Me.T062ListeQuadriNumerazioneBindingSource.DataSource = Me.LottiDataSet
        '
        'UltraPanelResto
        '
        '
        'UltraPanelResto.ClientArea
        '
        Me.UltraPanelResto.ClientArea.Controls.Add(Me.TabControlPrincipale)
        Me.UltraPanelResto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanelResto.Location = New System.Drawing.Point(0, 43)
        Me.UltraPanelResto.Name = "UltraPanelResto"
        Me.UltraPanelResto.Size = New System.Drawing.Size(1689, 786)
        Me.UltraPanelResto.TabIndex = 12
        '
        'TabControlPrincipale
        '
        Me.TabControlPrincipale.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabControlPrincipale.Controls.Add(Me.UltraTabPageControl1)
        Me.TabControlPrincipale.Controls.Add(Me.UltraTabPageControl2)
        Me.TabControlPrincipale.Controls.Add(Me.UltraTabPageControl3)
        Me.TabControlPrincipale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipale.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPrincipale.Name = "TabControlPrincipale"
        Me.TabControlPrincipale.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabControlPrincipale.Size = New System.Drawing.Size(1689, 786)
        Me.TabControlPrincipale.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.TabControlPrincipale.TabIndex = 12
        UltraTab1.Key = "Lotti"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lotti"
        UltraTab2.Key = "Prospetto Ore"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Prospetto Ore"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "tab1"
        Me.TabControlPrincipale.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1689, 786)
        '
        'UTBManager
        '
        Me.UTBManager.DesignerFlags = 1
        Me.UTBManager.DockWithinContainer = Me
        Me.UTBManager.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UTBManager.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        ButtonTool13.InstanceProps.IsFirstInGroup = True
        ButtonTool14.InstanceProps.IsFirstInGroup = True
        ButtonTool1.InstanceProps.IsFirstInGroup = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13, ButtonTool15, ButtonTool14, ButtonTool7, ButtonTool12, ButtonTool1, ButtonTool3, ButtonTool5, ButtonTool6, ButtonTool11})
        UltraToolbar1.Text = "CODIFICA"
        Me.UTBManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance14.Image = Global.CE_Lotti.My.Resources.LottiResource.logout_32
        ButtonTool16.SharedPropsInternal.AppearancesLarge.Appearance = Appearance14
        Appearance15.Image = Global.CE_Lotti.My.Resources.LottiResource.logout_16
        ButtonTool16.SharedPropsInternal.AppearancesSmall.Appearance = Appearance15
        ButtonTool16.SharedPropsInternal.Caption = "uscita (BT1)"
        ButtonTool16.SharedPropsInternal.CustomizerCaption = "indietro"
        ButtonTool16.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance16.Image = Global.CE_Lotti.My.Resources.LottiResource.save_32
        ButtonTool17.SharedPropsInternal.AppearancesLarge.Appearance = Appearance16
        Appearance17.Image = Global.CE_Lotti.My.Resources.LottiResource.save_16
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance17
        ButtonTool17.SharedPropsInternal.Caption = "Salva (BT2)"
        ButtonTool17.SharedPropsInternal.CustomizerCaption = "Codifica"
        Appearance18.Image = Global.CE_Lotti.My.Resources.LottiResource.help_center_32
        ButtonTool18.SharedPropsInternal.AppearancesLarge.Appearance = Appearance18
        Appearance19.Image = Global.CE_Lotti.My.Resources.LottiResource.help_center_16
        ButtonTool18.SharedPropsInternal.AppearancesSmall.Appearance = Appearance19
        ButtonTool18.SharedPropsInternal.Caption = "Help (BT3)"
        ButtonTool18.SharedPropsInternal.CustomizerCaption = "Ordina"
        Appearance20.Image = Global.CE_Lotti.My.Resources.LottiResource.view_list_16
        ButtonTool2.SharedPropsInternal.AppearancesSmall.Appearance = Appearance20
        ButtonTool2.SharedPropsInternal.Caption = "LottiProspetto (BT4)"
        ButtonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance21.Image = Global.CE_Lotti.My.Resources.LottiResource.label_16
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance21
        ButtonTool4.SharedPropsInternal.Caption = "Etichette (BT5)"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance22.Image = Global.CE_Lotti.My.Resources.LottiResource.engineering_16
        ButtonTool8.SharedPropsInternal.AppearancesSmall.Appearance = Appearance22
        ButtonTool8.SharedPropsInternal.Caption = "Pianificazione (BT6)"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance23.Image = Global.CE_Lotti.My.Resources.LottiResource.folder_open_16
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance23
        ButtonTool9.SharedPropsInternal.Caption = "ApreCartella (BT7)"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance24.Image = Global.CE_Lotti.My.Resources.LottiResource.list_alt_16
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance24
        ButtonTool10.SharedPropsInternal.Caption = "Ordini (BT8)"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance25.Image = Global.CE_Lotti.My.Resources.LottiResource.add_notes_32
        ButtonTool19.SharedPropsInternal.AppearancesLarge.Appearance = Appearance25
        Appearance26.Image = Global.CE_Lotti.My.Resources.LottiResource.add_notes_16
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance26
        ButtonTool19.SharedPropsInternal.Caption = "NuovoLotto (BT9)"
        Appearance27.Image = Global.CE_Lotti.My.Resources.LottiResource.delete_32
        ButtonTool20.SharedPropsInternal.AppearancesLarge.Appearance = Appearance27
        Appearance28.Image = Global.CE_Lotti.My.Resources.LottiResource.delete_16
        ButtonTool20.SharedPropsInternal.AppearancesSmall.Appearance = Appearance28
        ButtonTool20.SharedPropsInternal.Caption = "CancellaLotto (BT10)"
        Me.UTBManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool2, ButtonTool4, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool19, ButtonTool20})
        Me.UTBManager.UseLargeImagesOnToolbar = True
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_Top
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_Top"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1689, 43)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UTBManager
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_Bottom
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 829)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_Bottom"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1689, 0)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UTBManager
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_Left
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 43)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_Left"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 786)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UTBManager
        '
        '_UltraTabPageControl2_Toolbars_Dock_Area_Right
        '
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1689, 43)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.Name = "_UltraTabPageControl2_Toolbars_Dock_Area_Right"
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 786)
        Me._UltraTabPageControl2_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UTBManager
        '
        'Lotti_Fill_Panel
        '
        Me.Lotti_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lotti_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lotti_Fill_Panel.Location = New System.Drawing.Point(0, 43)
        Me.Lotti_Fill_Panel.Name = "Lotti_Fill_Panel"
        Me.Lotti_Fill_Panel.Size = New System.Drawing.Size(1689, 786)
        Me.Lotti_Fill_Panel.TabIndex = 21
        '
        'UltraCalendarInfo1
        '
        Me.UltraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = Me
        Me.UltraCalendarInfo1.DataBindingsForOwners.BindingContextControl = Me
        '
        'T059_LottiTableAdapter
        '
        Me.T059_LottiTableAdapter.ClearBeforeFill = True
        '
        'T074_LottiDettaglioTableAdapter
        '
        Me.T074_LottiDettaglioTableAdapter.ClearBeforeFill = True
        '
        'T058_Commesse_aperteTableAdapter
        '
        Me.T058_Commesse_aperteTableAdapter.ClearBeforeFill = True
        '
        'T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter
        '
        Me.T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter.ClearBeforeFill = True
        '
        'T058_Commesse_Totale_OreTableAdapter
        '
        Me.T058_Commesse_Totale_OreTableAdapter.ClearBeforeFill = True
        '
        'T059_Lotti_SelezionaTableAdapter
        '
        Me.T059_Lotti_SelezionaTableAdapter.ClearBeforeFill = True
        '
        'TmpLottiTableAdapter
        '
        Me.TmpLottiTableAdapter.ClearBeforeFill = True
        '
        'T059_Lotto_SelezionaTableAdapter
        '
        Me.T059_Lotto_SelezionaTableAdapter.ClearBeforeFill = True
        '
        'TtmConfigurazioneGrigliaTableAdapter
        '
        Me.TtmConfigurazioneGrigliaTableAdapter.ClearBeforeFill = True
        '
        'T108_UfficiTableAdapter
        '
        Me.T108_UfficiTableAdapter.ClearBeforeFill = True
        '
        'TtmConfigurazioneGeneraleTableAdapter
        '
        Me.TtmConfigurazioneGeneraleTableAdapter.ClearBeforeFill = True
        '
        'T072_GantPTableAdapter
        '
        Me.T072_GantPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterGantP
        '
        Me.TableAdapterGantP.ClearBeforeFill = True
        '
        'LavorazioniEsterne_cboTableAdapter
        '
        Me.LavorazioniEsterne_cboTableAdapter.ClearBeforeFill = True
        '
        'Inserimento_LottoTableAdapter
        '
        Me.Inserimento_LottoTableAdapter.ClearBeforeFill = True
        '
        'T042_ListeQuadriTableAdapter
        '
        Me.T042_ListeQuadriTableAdapter.ClearBeforeFill = True
        '
        'T117_ListeQuadriDettaglioTableAdapter
        '
        Me.T117_ListeQuadriDettaglioTableAdapter.ClearBeforeFill = True
        '
        'T045_ListeQuadriElenchiMaterialiTableAdapter
        '
        Me.T045_ListeQuadriElenchiMaterialiTableAdapter.ClearBeforeFill = True
        '
        'T042_MagicTableAdapter
        '
        Me.T042_MagicTableAdapter.ClearBeforeFill = True
        '
        'T062_ListeQuadriNumerazioneTableAdapter
        '
        Me.T062_ListeQuadriNumerazioneTableAdapter.ClearBeforeFill = True
        '
        'Lotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1689, 829)
        Me.Controls.Add(Me.UltraPanelResto)
        Me.Controls.Add(Me.Lotti_Fill_Panel)
        Me.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._UltraTabPageControl2_Toolbars_Dock_Area_Top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lotti"
        Me.Text = "Form1"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.ResumeLayout(False)
        Me.UltraPanel4.ResumeLayout(False)
        CType(Me.UltraGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        Me.UltraPanel9.ClientArea.ResumeLayout(False)
        Me.UltraPanel9.ClientArea.PerformLayout()
        Me.UltraPanel9.ResumeLayout(False)
        CType(Me.datDataFine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDataInizio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbPercComp.ResumeLayout(False)
        Me.ugbPercComp.PerformLayout()
        CType(Me.numPercComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugbGanttOpzioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbGanttOpzioni.ResumeLayout(False)
        Me.ugbGanttOpzioni.PerformLayout()
        CType(Me.cboT074LavorazioniEsterneG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LavorazioniEsternecboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LottiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uceAttivitaNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uceAttivitaFinite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbDataInizio.ResumeLayout(False)
        Me.ugbDataInizio.PerformLayout()
        CType(Me.numStartDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbSpostamento.ResumeLayout(False)
        Me.ugbSpostamento.PerformLayout()
        CType(Me.numActivityDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ugbDataFine.ResumeLayout(False)
        Me.ugbDataFine.PerformLayout()
        CType(Me.numEndDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel8.ClientArea.ResumeLayout(False)
        Me.UltraPanel8.ResumeLayout(False)
        CType(Me.ngrdT059_Lotti4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T058CommesseTotaleOreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel7.ClientArea.ResumeLayout(False)
        Me.UltraPanel7.ResumeLayout(False)
        CType(Me.ngrdT059_Lotti3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T058CommesseTotaleOreLottiSelezionatiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel6.ClientArea.ResumeLayout(False)
        Me.UltraPanel6.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.ngrdT059_Lotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T059LottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel10.ClientArea.ResumeLayout(False)
        Me.UltraPanel10.ResumeLayout(False)
        CType(Me.ngrdCommesse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T058CommesseaperteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel11.ClientArea.ResumeLayout(False)
        Me.UltraPanel11.ClientArea.PerformLayout()
        Me.UltraPanel11.ResumeLayout(False)
        CType(Me.txtRicercaCommessa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel5.ClientArea.ResumeLayout(False)
        Me.UltraPanel5.ResumeLayout(False)
        CType(Me.ngrdT059_Lotti2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmpLottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ngrdT042_ListeQuadri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T042ListeQuadriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugT042Totali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.cboT042Numerazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T062ListeQuadriNumerazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanelResto.ClientArea.ResumeLayout(False)
        Me.UltraPanelResto.ResumeLayout(False)
        CType(Me.TabControlPrincipale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPrincipale.ResumeLayout(False)
        CType(Me.UTBManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel6 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraSplitter2 As Infragistics.Win.Misc.UltraSplitter
    Friend WithEvents UltraPanel5 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraSplitter4 As Infragistics.Win.Misc.UltraSplitter
    Friend WithEvents UltraPanel10 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents T059LottiBindingSource As BindingSource
    Friend WithEvents LottiDataSet As LottiDataSet
    Friend WithEvents T059_LottiTableAdapter As LottiDataSetTableAdapters.T059_LottiTableAdapter
    Friend WithEvents T074_LottiDettaglioTableAdapter As LottiDataSetTableAdapters.T074_LottiDettaglioTableAdapter
    Friend WithEvents T058CommesseaperteBindingSource As BindingSource
    Friend WithEvents T058_Commesse_aperteTableAdapter As LottiDataSetTableAdapters.T058_Commesse_aperteTableAdapter
    Friend WithEvents UltraPanel4 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraSplitter3 As Infragistics.Win.Misc.UltraSplitter
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel8 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel7 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraSplitter1 As Infragistics.Win.Misc.UltraSplitter
    Friend WithEvents ngrdT059_Lotti3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ngrdT059_Lotti4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel9 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ugbPercComp As GroupBox
    Friend WithEvents btnPercCompPiu As Button
    Friend WithEvents btnPercCompMeno As Button
    Friend WithEvents ugbGanttOpzioni As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uceAttivitaNA As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uceAttivitaFinite As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugbDataInizio As GroupBox
    Friend WithEvents btnStartPiu As Button
    Friend WithEvents StartMeno As Button
    Friend WithEvents ugbSpostamento As GroupBox
    Friend WithEvents btnActivityPiu As Button
    Friend WithEvents btnActivityMeno As Button
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ulUfficio13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulIniziata As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulPianificata As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UlFinita As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulOltre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulUfficio17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulCalcolato As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugbDataFine As GroupBox
    Friend WithEvents btnEndMeno As Button
    Friend WithEvents btnEndPiu As Button
    Friend WithEvents ngrdT059_Lotti As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ngrdCommesse As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGanttView1 As Infragistics.Win.UltraWinGanttView.UltraGanttView
    Friend WithEvents T058CommesseTotaleOreBindingSource As BindingSource
    Friend WithEvents T058CommesseTotaleOreLottiSelezionatiBindingSource As BindingSource
    Friend WithEvents T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter As LottiDataSetTableAdapters.T058_Commesse_Totale_Ore_Lotti_SelezionatiTableAdapter
    Friend WithEvents T058_Commesse_Totale_OreTableAdapter As LottiDataSetTableAdapters.T058_Commesse_Totale_OreTableAdapter
    Friend WithEvents ngrdT059_Lotti2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents T059_Lotti_SelezionaTableAdapter As LottiDataSetTableAdapters.T059_Lotti_SelezionaTableAdapter
    Friend WithEvents TmpLottiBindingSource As BindingSource
    Friend WithEvents TmpLottiTableAdapter As LottiDataSetTableAdapters.tmpLottiTableAdapter
    Friend WithEvents datDataFine As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents datDataInizio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents numPercComp As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numStartDay As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numActivityDay As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents numEndDay As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents T059_Lotto_SelezionaTableAdapter As LottiDataSetTableAdapters.T059_Lotto_SelezionaTableAdapter
    Friend WithEvents UltraPanelResto As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UTBManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents Lotti_Fill_Panel As Panel
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _UltraTabPageControl2_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents TtmConfigurazioneGrigliaTableAdapter As LottiDataSetTableAdapters.TtmConfigurazioneGrigliaTableAdapter
    Friend WithEvents T108_UfficiTableAdapter As LottiDataSetTableAdapters.T108_UfficiTableAdapter
    Friend WithEvents UltraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Friend WithEvents TtmConfigurazioneGeneraleTableAdapter As LottiDataSetTableAdapters.TtmConfigurazioneGeneraleTableAdapter
    Friend WithEvents T072_GantPTableAdapter As LottiDataSetTableAdapters.T072_GantPTableAdapter
    Friend WithEvents TableAdapterGantP As LottiDataSetTableAdapters.TableAdapterGantP
    Friend WithEvents UltraPanel11 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents lblRicercaCommessa As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRicercaCommessa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboT074LavorazioniEsterneG As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LavorazioniEsternecboBindingSource As BindingSource
    Friend WithEvents LavorazioniEsterne_cboTableAdapter As LottiDataSetTableAdapters.LavorazioniEsterne_cboTableAdapter
    Friend WithEvents TabControlPrincipale As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Inserimento_LottoTableAdapter As LottiDataSetTableAdapters.Inserimento_LottoTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ngrdT042_ListeQuadri As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugT042Totali As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents T042ListeQuadriBindingSource As BindingSource
    Friend WithEvents T042_ListeQuadriTableAdapter As LottiDataSetTableAdapters.T042_ListeQuadriTableAdapter
    Friend WithEvents T117_ListeQuadriDettaglioTableAdapter As LottiDataSetTableAdapters.T117_ListeQuadriDettaglioTableAdapter
    Friend WithEvents T045_ListeQuadriElenchiMaterialiTableAdapter As LottiDataSetTableAdapters.T045_ListeQuadriElenchiMaterialiTableAdapter
    Friend WithEvents T042_MagicTableAdapter As LottiDataSetTableAdapters.T042_MagicTableAdapter
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboT042Numerazione As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents T062ListeQuadriNumerazioneBindingSource As BindingSource
    Friend WithEvents T062_ListeQuadriNumerazioneTableAdapter As LottiDataSetTableAdapters.T062_ListeQuadriNumerazioneTableAdapter
End Class
