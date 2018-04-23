Namespace Dashboard_UserData
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            Me.btnSaveDashboard = New System.Windows.Forms.Button()
            Me.btnLoadDashboard = New System.Windows.Forms.Button()
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardViewer1
            ' 
            Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
            Me.dashboardViewer1.Name = "dashboardViewer1"
            Me.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
            Me.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = (CByte(0))
            Me.dashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
            Me.dashboardViewer1.Size = New System.Drawing.Size(958, 468)
            Me.dashboardViewer1.TabIndex = 0
            ' 
            ' btnSaveDashboard
            ' 
            Me.btnSaveDashboard.Location = New System.Drawing.Point(35, 13)
            Me.btnSaveDashboard.Name = "btnSaveDashboard"
            Me.btnSaveDashboard.Size = New System.Drawing.Size(114, 23)
            Me.btnSaveDashboard.TabIndex = 1
            Me.btnSaveDashboard.Text = "Save Dashboard"
            Me.btnSaveDashboard.UseVisualStyleBackColor = True
            ' 
            ' btnLoadDashboard
            ' 
            Me.btnLoadDashboard.Location = New System.Drawing.Point(155, 13)
            Me.btnLoadDashboard.Name = "btnLoadDashboard"
            Me.btnLoadDashboard.Size = New System.Drawing.Size(114, 23)
            Me.btnLoadDashboard.TabIndex = 2
            Me.btnLoadDashboard.Text = "Load Dashboard"
            Me.btnLoadDashboard.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(958, 468)
            Me.Controls.Add(Me.btnLoadDashboard)
            Me.Controls.Add(Me.btnSaveDashboard)
            Me.Controls.Add(Me.dashboardViewer1)
            Me.Name = "Form1"
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
        Private WithEvents btnSaveDashboard As System.Windows.Forms.Button
        Private WithEvents btnLoadDashboard As System.Windows.Forms.Button
    End Class
End Namespace

