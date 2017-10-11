<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ComplaintsDetails.aspx.cs" Inherits="OnDutyOfficial_ComplaintsDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Complaint Details</title>
    <link rel="stylesheet" href="App_Themes/Default/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Enter ComplaintId:
            <asp:TextBox ID="txtSearchComplaint" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchComplaint" runat="server"  Text="Search Complaint" OnClick="btnSearchComplaint_Click"/>
            <br />
            <asp:DetailsView ID="ddComplaintDetails" runat="server" Height="50px" Width="125px" DataSourceID="objComplaintDetails" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <EmptyDataTemplate>
                    Complaint Does not Exist.
                </EmptyDataTemplate>
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:TemplateField HeaderText="State" SortExpression="StateId">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("State.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City" SortExpression="CityId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("City.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Village" SortExpression="VillageId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Village.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Locality" SortExpression="LocalityId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Locality.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DepartmentType" SortExpression="DepartmentTypeId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("DepartmentType.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ComplaintType" SortExpression="ComplaintTypeId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("ComplaintType.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ReportingPersonFirstName" HeaderText="ReportingPersonFirstName" SortExpression="ReportingPersonFirstName" />
                    <asp:BoundField DataField="ReportingPersonLastName" HeaderText="ReportingPersonLastName" SortExpression="ReportingPersonLastName" />
                    <asp:BoundField DataField="ReportingPersonAdhaarId" HeaderText="ReportingPersonAdhaarId" SortExpression="ReportingPersonAdhaarId" />
                    <asp:BoundField DataField="ReportingPersonContactNumber" HeaderText="ReportingPersonContactNumber" SortExpression="ReportingPersonContactNumber" />
                    <asp:BoundField DataField="ReportingTime" HeaderText="ReportingTime" SortExpression="ReportingTime" />
                    <asp:TemplateField HeaderText="CurrentStatus" SortExpression="CurrentStatusId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("ComplaintStatus.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CurrentEscalationNumber" HeaderText="CurrentEscalationNumber" SortExpression="CurrentEscalationNumber" />
                    <asp:TemplateField HeaderText="IsEscalated" SortExpression="IsEscalated">
                        
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("IsEscalated") %>' Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:TemplateField HeaderText="Department" SortExpression="DepartmentId">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("Department.Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ClosingTime" HeaderText="ClosingTime" SortExpression="ClosingTime" />
                    <asp:TemplateField HeaderText="Escalation History">
                        <ItemTemplate>

                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                <Columns>
                                    <asp:BoundField DataField="EscalationLevelNumber" HeaderText="EscalationLevelNumber" SortExpression="EscalationLevelNumber" />
                                    <asp:BoundField DataField="EscalationTime" HeaderText="EscalationTime" SortExpression="EscalationTime" />
                                    <asp:BoundField DataField="EscalationReason" HeaderText="EscalationReason" SortExpression="EscalationReason" />
                                </Columns>
                            </asp:GridView>
                            <br />
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllByComplaintId" TypeName="BusinessLogic.ComplaintXEscalationLevelBL">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="Id" QueryStringField="ComplaintId" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Complaint Status History">
                        <ItemTemplate>

                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
                                <Columns>
                                    <asp:TemplateField HeaderText="Status" SortExpression="StatusId">
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ComplaintStatus.Name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="StatusAssignTime" HeaderText="StatusAssignTime" SortExpression="StatusAssignTime" />
                                </Columns>
                            </asp:GridView>
                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByComplaint" TypeName="BusinessLogic.ComplaintXStatusBL">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="complaintId" QueryStringField="ComplaintId" Type="Int32" DefaultValue="0" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <br />

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Image">

                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="100px" Width="150px" ImageUrl='<%# Eval("Image") %>' />
                        </ItemTemplate>

                    </asp:TemplateField>
                </Fields>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
            <asp:ObjectDataSource ID="objComplaintDetails" runat="server" SelectMethod="GetDetails" TypeName="BusinessLogic.ComplaintBL">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="0" Name="id" QueryStringField="ComplaintId" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        <table>
            <tr>
                <asp:Panel ID="pnlEscalationbtn" runat="server" Visible="false">
                <td>
                    <asp:Button ID="btnEscalate" CssClass="button" runat="server" Text="Escalate" OnClick="btnEscalate_Click" width="100%"/>
                </td>
                </asp:Panel>
                 <asp:Panel ID="pnlClosed" runat="server" Visible="false">
                <td>
                    <asp:Button ID="btnClose" CssClass="button" runat="server" Text="Close" OnClick="btnClose_Click" Width="100%" />
                </td>
                </asp:Panel>
            </tr>
            <tr>
                <asp:Panel ID="pnlFixed" runat="server" Visible="false">
                <td>
                    <asp:Button ID="btnFixed" CssClass="button" runat="server" Text="Fixed" OnClick="btnFixed_Click" Width="100%" />
                </td>
                </asp:Panel>
               
            </tr>
        </table>
        <br />

        <asp:Panel ID="pnlEscalation" runat="server" Visible="false">
            Escalation Reason: 
            <asp:TextBox ID="txtEscalationReason" runat="server"></asp:TextBox>
            <asp:Button ID="btnEscalateReason"  runat="server" Text="Escalate" OnClick="btnEscalateReason_Click" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>