<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="ComplaintsAvrageTimeReport.aspx.cs" Inherits="DepartmentOfficials_ComplaintsAvrageTimeReport" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
      google.charts.load('current', {'packages':['line']});
      google.charts.setOnLoadCallback(drawChart);

    function drawChart() {

      var data = new google.visualization.DataTable();
      data.addColumn('number', 'Hours');
      data.addColumn('number', 'Average Complaint Resolution Time');

      data.addRows([
        <%: GraphReportData %>
      ]);

      var options = {
        chart: {
          title: 'Average Complaint Resolution Time Report',
          subtitle: ''
        },
        width: 900,
        height: 500,
        axes: {
          x: {
            0: {side: 'top'}
          }
        }
      };

      var chart = new google.charts.Line(document.getElementById('line_top_x'));

      chart.draw(data, google.charts.Line.convertOptions(options));
    }
  </script>
    <h1>Report - Average Complaint Resolution Time</h1>
    <br />
    Select the date range to view report
    <br />
    <br />

    <asp:HiddenField ID="HiddenField1" runat="server" />
    Select Department : <asp:DropDownList runat="server" ID="ddlDepartments" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id">
                            
                        </asp:DropDownList>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllByUseraname" TypeName="BusinessLogic.DepartmentBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="HiddenField1" Name="username" PropertyName="Value" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <br />
    <br />
    <table>
        <tr>
            <td>Date From : <asp:TextBox runat="server" ID="txtDateFrom"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDateFrom" runat="server" />
            </td>
        
            <td>Date To : <asp:TextBox runat="server" ID="txtDateTo"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" TargetControlID="txtDateTo" runat="server" />
            </td>
            <td><asp:Button runat="server" ID="btnViewReport" Text="View Report" OnClick="btnViewReport_Click" /></td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Panel runat="server" ID="pnlReport" Visible="false">
        <div id="line_top_x"></div>
    </asp:Panel>
    <br />
    <br />
    <br />
    <br />
    
</asp:Content>

