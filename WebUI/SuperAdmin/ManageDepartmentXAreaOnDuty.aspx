<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageDepartmentXAreaOnDuty.aspx.cs" Inherits="SuperAdmin_ManageDepartmentXAreaOnDuty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="Server">

    <h1>Manage On Duty Officials</h1>

    <table>
        <tr>
            <td>Select State: </td>
            <td>
                <asp:DropDownList ID="ddlState" AutoPostBack="true" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.StateBL"></asp:ObjectDataSource>
            </td>
        </tr>

        <tr>
            <td>Select City: </td>
            <td>
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByState" TypeName="BusinessLogic.CityBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlState" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select Village: </td>
            <td>
                <asp:DropDownList ID="ddlVillage" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource3" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllForCity" TypeName="BusinessLogic.VillageBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select Locality: </td>
            <td>
                <asp:DropDownList ID="ddlLocality" runat="server" DataSourceID="ObjectDataSource6" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetDetails" TypeName="BusinessLogic.LocalityBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="CityId" PropertyName="SelectedValue" Type="Int32" />
                        <asp:ControlParameter ControlID="ddlVillage" Name="VillageId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select Department: </td>
            <td>
                <asp:DropDownList ID="ddlSelectDepartment" AutoPostBack="true" runat="server" DataSourceID="ObjectDataSource4" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetAllByCity" TypeName="BusinessLogic.DepartmentBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>

    <asp:GridView ID="GridView1" DataKeyNames="Id" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnDataBinding="GridView1_DataBinding">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            
            <asp:TemplateField HeaderText="OnDutyPersonName" SortExpression="OnDutyPersonId">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("GovermentOfficial.Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("GovermentOfficial.Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="DutyTimeFrom">

                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("DutyTimeFrom","{0:T}") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>


            <asp:TemplateField HeaderText="DutyTimeTo">

                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("DutyTimeTo","{0:T}") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
        </Columns>

        <EditRowStyle BackColor="#999999" />

        <EmptyDataTemplate>
            <p>Select Data from Above</p>
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


    <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="GetAllByLocationAndDepartment" TypeName="BusinessLogic.DepartmentXAreaOnDutyBL" DataObjectTypeName="BusinessObjects.DepartmentXAreaOnDuty" DeleteMethod="Delete">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlLocality" Name="localityId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlSelectDepartment" Name="departmentId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:Button ID="btnAddDetails" runat="server" Text="Add Details" OnClick="btnAddDetails_Click" />
    <br /><br />


    <asp:DetailsView ID="DetailsView1" DataKeyNames="Id" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource7" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemInserted="DetailsView1_ItemInserted" OnItemInserting="DetailsView1_ItemInserting" OnItemUpdated="DetailsView1_ItemUpdated" OnDataBinding="DetailsView1_DataBinding">
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:TemplateField HeaderText="Official Code">

                <EditItemTemplate>
                    <asp:TextBox ID="txtEditCode" runat="server"></asp:TextBox>
                </EditItemTemplate>

                <InsertItemTemplate>
                    <asp:TextBox ID="txtNewCode" runat="server"></asp:TextBox>
                </InsertItemTemplate>

                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("GovermentOfficial.Name") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:BoundField DataField="DutyTimeFrom" HeaderText="DutyTimeFrom" SortExpression="DutyTimeFrom" />
            <asp:BoundField DataField="DutyTimeTo" HeaderText="DutyTimeTo" SortExpression="DutyTimeTo" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>

        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />

        <EmptyDataTemplate>
            <p>
                Select from above.
            </p>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>


    <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" DataObjectTypeName="BusinessObjects.DepartmentXAreaOnDuty" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.DepartmentXAreaOnDutyBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>


</asp:Content>

