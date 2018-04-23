Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon
Imports System.Xml.Linq
Imports DevExpress.DashboardWin

Namespace Dashboard_UserData
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Dim dashboard As New Dashboard()
            dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
        End Sub

        Private Sub btnSaveDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnSaveDashboard.Click
            Dim dashboard As New Dashboard()
            dashboard.LoadFromXml("..\..\Data\Dashboard.xml")

            ' Obtains dashboard parameter settings and metadata for a currently open dashboard.
            Dim parameters As IList(Of DashboardParameterDescriptor) = dashboardViewer1.Parameters

            ' Saves parameter settings and current values to an XML element.
            Dim xml As New XElement("ParametersInfo", _
                From parameter In parameters _
                Select New XElement("ParameterInfo", New XElement("Name", parameter.Name),
                                    New XElement("Value", parameter.Value),
                                    New XElement("Type", parameter.Type)))

            ' Adds the created XML element to the dashboard XML definition and saves the dashboard.
            dashboard.UserData = xml
            dashboard.SaveToXml("..\..\Data\Dashboard.xml")
        End Sub

        Private Sub btnLoadDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnLoadDashboard.Click
            Dim dashboard As New Dashboard()
            dashboard.LoadFromXml("..\..\Data\Dashboard.xml")

            If dashboard.UserData IsNot Nothing Then
                ' Obtains used data from the dashboard XML definition.
                Dim xml As XElement = dashboard.UserData

                ' Saves values from the XML element to the list.
                Dim parsInfo As IList(Of XElement) = xml.Elements().ToList()
                Dim values As IList(Of Object) = New List(Of Object)()
                For Each parInfo As XElement In parsInfo
                    ' Converts parameter values with the 'DateTime' type to date-time values.
                    If parInfo.Element("Type").Value = "DateTime" Then
                        values.Add(Date.Parse(parInfo.Element("Value").Value))
                    Else
                        values.Add(parInfo.Element("Value").Value)
                    End If
                Next parInfo

                Dim parameters1 As DashboardParameters = dashboardViewer1.Parameters

                ' Sets obtained user values as current parameters' values.
                dashboardViewer1.BeginUpdateParameters()
                For i As Integer = 0 To parameters1.Count - 1
                    parameters1(i).Value = values(i)
                Next i
                dashboardViewer1.EndUpdateParameters()
            End If
        End Sub
    End Class
End Namespace
