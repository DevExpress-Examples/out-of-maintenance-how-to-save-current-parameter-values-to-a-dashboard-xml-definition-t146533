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
			AddHandler dashboardViewer1.CustomizeDashboardTitle, AddressOf DashboardViewer1_CustomizeDashboardTitle
			dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
		End Sub

		Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim itemSave As DashboardToolbarItem = New DashboardToolbarItem(Sub(args)
				SaveDashboard()
			End Sub)
			itemSave.Caption = "Save Dashboard"
			e.Items.Add(itemSave)
			Dim itemLoad As DashboardToolbarItem = New DashboardToolbarItem(Sub(args)
				LoadDashboard()
			End Sub)
			itemLoad.Caption = "Load Dashboard"
			e.Items.Add(itemLoad)
		End Sub

		Private Sub SaveDashboard()
			Dim dashboard As New Dashboard()
			dashboard.LoadFromXml("..\..\Data\Dashboard.xml")

			Dim parameters As IList(Of DashboardParameterDescriptor) = dashboardViewer1.Parameters

			Dim xml As New XElement("ParametersInfo",
			    From parameter In parameters
			    Select New XElement("ParameterInfo", New XElement("Name", parameter.Name), New XElement("Value", parameter.SelectedValue), New XElement("Type", parameter.Type)))

			dashboard.UserData = xml
			dashboard.SaveToXml("..\..\Data\Dashboard.xml")
		End Sub

		Private Sub LoadDashboard()
			Dim dashboard As New Dashboard()
			dashboard.LoadFromXml("..\..\Data\Dashboard.xml")

			If dashboard.UserData IsNot Nothing Then
				Dim xml As XElement = dashboard.UserData

				Dim parsInfo As IList(Of XElement) = xml.Elements().ToList()
				Dim values As IList(Of Object) = New List(Of Object)()
				For Each parInfo As XElement In parsInfo
					If parInfo.Element("Type").Value = "DateTime" Then
						values.Add(Date.Parse(parInfo.Element("Value").Value))
					Else
						values.Add(parInfo.Element("Value").Value)
					End If
				Next parInfo

				Dim parameters1 As DashboardParameters = dashboardViewer1.Parameters

				dashboardViewer1.BeginUpdateParameters()
				For i As Integer = 0 To parameters1.Count - 1
					parameters1(i).SelectedValue = values(i)
				Next i
				dashboardViewer1.EndUpdateParameters()
			End If
		End Sub
	End Class
End Namespace
