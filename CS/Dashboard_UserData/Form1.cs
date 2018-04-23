using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;
using System.Xml.Linq;
using DevExpress.DashboardWin;

namespace Dashboard_UserData {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
        }

        private void btnSaveDashboard_Click(object sender, EventArgs e) {
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            // Obtains dashboard parameter settings and metadata for a currently open dashboard.
            IList<DashboardParameterDescriptor> parameters = dashboardViewer1.Parameters;

            // Saves parameter settings and current values to an XML element.
            XElement xml = new XElement("ParametersInfo",
                        from parameter in parameters
                        select new XElement("ParameterInfo",
                                    new XElement("Name", parameter.Name),
                                    new XElement("Value", parameter.Value),
                                    new XElement("Type", parameter.Type)));

            // Adds the created XML element to the dashboard XML definition and saves the dashboard.
            dashboard.UserData = xml;
            dashboard.SaveToXml(@"..\..\Data\Dashboard.xml");
        }

        private void btnLoadDashboard_Click(object sender, EventArgs e) {
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            if (dashboard.UserData != null) {
                // Obtains used data from the dashboard XML definition.
                XElement xml = dashboard.UserData;

                // Saves values from the XML element to the list.
                IList<XElement> parsInfo = xml.Elements().ToList();
                IList<object> values = new List<object>();
                foreach (XElement parInfo in parsInfo) {
                    // Converts parameter values with the 'DateTime' type to date-time values.
                    if (parInfo.Element("Type").Value == "DateTime") {
                        values.Add(DateTime.Parse(parInfo.Element("Value").Value));
                    }
                    else {
                        values.Add(parInfo.Element("Value").Value);
                    }
                }

                DashboardParameters parameters1 = dashboardViewer1.Parameters;

                // Sets obtained user values as current parameters' values.
                dashboardViewer1.BeginUpdateParameters();
                for (int i = 0; i < parameters1.Count; i++) {
                    parameters1[i].Value = values[i];
                }
                dashboardViewer1.EndUpdateParameters();
            }
        }
    }
}
