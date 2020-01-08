Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormReportNIMMahasiswa

    Private Sub ButtonSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelesai.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTampilkan.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Zetasky\Documents\Visual Studio 2010\Projects\Project_Akademik_Irpan\CrystalReportNIMMahasiswa.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = TextBoxNIM.Text
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("nim")
        crParameterValues = crParameterFieldDefinition.CurrentValues
        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class