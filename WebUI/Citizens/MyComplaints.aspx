<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="MyComplaints.aspx.cs" Inherits="Citizens_MyComplaints" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
    My Complaints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2 style="text-align:center">
        My Complaints
    </h2>
    <div class="contain_padding1">
        Enter Your Adhaar Number: <asp:TextBox ID="txtAdhaarNumber" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearchAdhaar" runat="server" Text="Search" />
        <br /><br />
        <asp:GridView ID="gridAllComplaintsByAdhaar" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="objAllComplaintsByAdhaar" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                    
                        <asp:HyperLink ID="hlViewDetails" runat="server" NavigateUrl='<%# string.Format("~/ComplaintsDetails.aspx?ComplaintId={0}", Eval("Id")) %>'>View Complaint</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="objAllComplaintsByAdhaar" runat="server" SelectMethod="GetAllByAdhar" TypeName="BusinessLogic.ComplaintBL">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtAdhaarNumber" Name="Adhar" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>

