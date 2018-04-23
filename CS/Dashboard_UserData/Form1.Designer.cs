namespace Dashboard_UserData {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.btnSaveDashboard = new System.Windows.Forms.Button();
            this.btnLoadDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None;
            this.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = ((byte)(0));
            this.dashboardViewer1.PrintingOptions.FontInfo.Name = null;
            this.dashboardViewer1.Size = new System.Drawing.Size(958, 468);
            this.dashboardViewer1.TabIndex = 0;
            // 
            // btnSaveDashboard
            // 
            this.btnSaveDashboard.Location = new System.Drawing.Point(35, 13);
            this.btnSaveDashboard.Name = "btnSaveDashboard";
            this.btnSaveDashboard.Size = new System.Drawing.Size(114, 23);
            this.btnSaveDashboard.TabIndex = 1;
            this.btnSaveDashboard.Text = "Save Dashboard";
            this.btnSaveDashboard.UseVisualStyleBackColor = true;
            this.btnSaveDashboard.Click += new System.EventHandler(this.btnSaveDashboard_Click);
            // 
            // btnLoadDashboard
            // 
            this.btnLoadDashboard.Location = new System.Drawing.Point(155, 13);
            this.btnLoadDashboard.Name = "btnLoadDashboard";
            this.btnLoadDashboard.Size = new System.Drawing.Size(114, 23);
            this.btnLoadDashboard.TabIndex = 2;
            this.btnLoadDashboard.Text = "Load Dashboard";
            this.btnLoadDashboard.UseVisualStyleBackColor = true;
            this.btnLoadDashboard.Click += new System.EventHandler(this.btnLoadDashboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 468);
            this.Controls.Add(this.btnLoadDashboard);
            this.Controls.Add(this.btnSaveDashboard);
            this.Controls.Add(this.dashboardViewer1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private System.Windows.Forms.Button btnSaveDashboard;
        private System.Windows.Forms.Button btnLoadDashboard;
    }
}

