<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="ComplaintsAssingedToMe.aspx.cs" Inherits="OnDutyOfficial_ComplaintsAssingedToMe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
    Complaints Assinged To Me
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:HiddenField ID="HiddenField1" runat="server" />
        <h1 style="text-align:center">Complaints Assinged To Me:</h1>
    <br />
    <div class="contain_padding1">
        <asp:GridView ID="gridOfficialsComplints" runat="server" AutoGenerateColumns="False" DataSourceID="objAllComplaintsofOfficial" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="hlViewDetails" runat="server" NavigateUrl='<%# string.Format("~/ComplaintsDetails.aspx?ComplaintId={0}", Eval("ComplaintId")) %>'>View Details</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="OfficialId" HeaderText="OfficialId" SortExpression="OfficialId" />
                <asp:BoundField DataField="ComplaintId" HeaderText="ComplaintId" SortExpression="ComplaintId" />
                <asp:BoundField DataField="AssignedOn" HeaderText="AssignedOn" SortExpression="AssignedOn" />
            
            
            </Columns>

            <EditRowStyle BackColor="#999999" />

            <EmptyDataTemplate>
                <p>No Complaints aassigned.</p>
            </EmptyDataTemplate>
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
        <asp:ObjectDataSource ID="objAllComplaintsofOfficial" runat="server" SelectMethod="GetAllByOfficialId" TypeName="BusinessLogic.OfficialXComplaintsAssignedBL">
            <SelectParameters>
                <asp:ControlParameter ControlID="HiddenField1" Name="officialId" PropertyName="Value" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>

