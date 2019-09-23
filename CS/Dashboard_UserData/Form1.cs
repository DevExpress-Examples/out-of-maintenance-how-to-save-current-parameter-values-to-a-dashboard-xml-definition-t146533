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
            dashboardViewer1.CustomizeDashboardTitle += DashboardViewer1_CustomizeDashboardTitle;
            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
        }

        private void DashboardViewer1_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            DashboardToolbarItem itemSave = new DashboardToolbarItem((args) => {SaveDashboard();});
            itemSave.Caption = "Save Dashboard";
            e.Items.Add(itemSave);
            DashboardToolbarItem itemLoad = new DashboardToolbarItem((args) => { LoadDashboard(); });
            itemLoad.Caption = "Load Dashboard";
            e.Items.Add(itemLoad);
        }

        private void SaveDashboard()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            IList<DashboardParameterDescriptor> parameters = dashboardViewer1.Parameters;

            XElement xml = new XElement("ParametersInfo",
                        from parameter in parameters
                        select new XElement("ParameterInfo",
                                    new XElement("Name", parameter.Name),
                                    new XElement("Value", parameter.SelectedValue),
                                    new XElement("Type", parameter.Type)));

            dashboard.UserData = xml;
            dashboard.SaveToXml(@"..\..\Data\Dashboard.xml");
        }

        private void LoadDashboard()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            if (dashboard.UserData != null)
            {
                XElement xml = dashboard.UserData;

                IList<XElement> parsInfo = xml.Elements().ToList();
                IList<object> values = new List<object>();
                foreach (XElement parInfo in parsInfo)
                {
                    if (parInfo.Element("Type").Value == "DateTime")
                    {
                        values.Add(DateTime.Parse(parInfo.Element("Value").Value));
                    }
                    else
                    {
                        values.Add(parInfo.Element("Value").Value);
                    }
                }

                DashboardParameters parameters1 = dashboardViewer1.Parameters;

                dashboardViewer1.BeginUpdateParameters();
                for (int i = 0; i < parameters1.Count; i++)
                {
                    parameters1[i].SelectedValue = values[i];
                }
                dashboardViewer1.EndUpdateParameters();
            }
        }
    }
}
