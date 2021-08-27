<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581321/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T146533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_UserData/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_UserData/Form1.vb))
<!-- default file list end -->
# OBSOLETE: Dashboard for WinForms - How to Save Parameter Values to a Dashboard XML Definition

---
**UPDATED:** *The UserData mechanism is an obsolete approach. From v.20.1, use [Custom Properties](https://docs.devexpress.com/Dashboard/401595/winforms-dashboard/winforms-designer/custom-properties) to save data to the dashboard XML definition. Instead of UserData, you can save custom data not only for a dashboard, but also for dashboard items and its data items.*

---

This example demonstrates how to use the [Dashboard.UserData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.UserData) property to save custom data to a dashboard XML definition. 

Click **Save Dashboard** to save the [dashboard parameter](https://docs.devexpress.com/Dashboard/17632) values to the dashboard XML file. Click **Load Dashboard** to load a dashboard and restore parameter values from the _Dashboard.UserData_ property.


![screenshot](/images/screenshot.png)

## More Examples

- [How to Set the Initial Dashboard State in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-viewer-save-and-apply-dashboard-state)
- [How to Set the Initial Dashboard State in the WinForms Designer](https://github.com/DevExpress-Examples/winforms-designer-save-and-apply-dashboard-state)
