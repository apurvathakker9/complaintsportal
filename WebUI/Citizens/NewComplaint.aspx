<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="NewComplaint.aspx.cs" Inherits="Citizens_NewComplaint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="Server">
    Add Complaints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="Server">

    <h2 style="text-align: center">Enter Complaint details</h2>
    <asp:Panel ID="pnlStart" runat="server">
        <div class="contain_padding">
            <table style="border-bottom: 2px solid #666666">
                <tr>
                    <td class="padding5">State: </td>
                    <td class="padding5">
                        <asp:DropDownList ID="ddlState" runat="server" Width="90%" AutoPostBack="true" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.StateBL"></asp:ObjectDataSource>
                    </td>
                </tr>


                <tr>
                    <td class="padding5">City: 
                    </td>

                    <td class="padding5">
                        <asp:DropDownList ID="ddlCity" runat="server" Width="90%" AutoPostBack="true" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByState" TypeName="BusinessLogic.CityBL">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlState" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>

                <tr>
                    <td class="padding5">Village: </td>
                    <td class="padding5">
                        <asp:DropDownList ID="ddlVillage" runat="server" Width="90%" AutoPostBack="true" DataSourceID="ObjectDataSource3" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllForCity" TypeName="BusinessLogic.VillageBL">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>

                <tr>
                    <td class="padding5">Locality: </td>
                    <td class="padding5">
                        <asp:DropDownList ID="ddlLocality" runat="server" Width="90%" DataSourceID="ObjectDataSource4" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetAllForCity" TypeName="BusinessLogic.LocalityBL">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>



                <tr>
                    <td class="padding5">DepartmentType: </td>
                    <td class="padding5">
                        <asp:DropDownList ID="ddlDepartmentType" AutoPostBack="true" runat="server" Width="90%" DataSourceID="ObjectDataSource5" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.DepartmentTypeBL"></asp:ObjectDataSource>
                    </td>
                </tr>


                <tr>
                    <td class="padding5">ComplaintType: </td>
                    <td class="padding5">
                        <asp:DropDownList ID="ddlComplaintType" AutoPostBack="true" runat="server" Width="90%" DataSourceID="ObjectDataSource6" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetAllForDepartment" TypeName="BusinessLogic.ComplaintTypeBL">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlDepartmentType" Name="departmentId" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>


                <tr>
                    <td class="padding5">First Name: </td>
                    <td class="padding5">
                        <asp:TextBox ID="txtFirstName" Width="90%" runat="server"></asp:TextBox></td>
                </tr>


                <tr>
                    <td class="padding5">Last Name: </td>
                    <td class="padding5">
                        <asp:TextBox ID="txtLastName" Width="90%" runat="server"></asp:TextBox></td>
                </tr>



                <tr>
                    <td class="padding5">Aadhar Id: </td>
                    <td class="padding5">
                        <asp:TextBox ID="txtAdharId" Width="90%" runat="server"></asp:TextBox></td>
                </tr>


                <tr>
                    <td class="padding5">Image: </td>
                    <td class="padding5">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>


                <tr>
                    <td class="padding5">Description: </td>

                    <td class="padding5">
                        <asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine"></asp:TextBox>

                    </td>
                </tr>



                <tr>
                    <td class="padding5"></td>
                    <td class="padding5">
                        <asp:Button ID="btnSubmit" CssClass="button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>

            </table>
        </div>
    </asp:Panel>


    <br />
    <br />

    <asp:Panel runat="server" ID="pnlVerifyOTP" Visible="false">
        <div class="contain_padding">
            Please verify the OTP sent on your phone number in order to assign your complaint to the concerned officials.
        <br />


            <table>
                <tr>
                    <td>Complaint Number: </td>
                    <td>
                        <asp:TextBox ID="txtComplaintNumber" Width="90%" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>OTP: </td>
                    <td>
                        <asp:TextBox ID="txtOTP" Width="90%" runat="server"></asp:TextBox></td>
                </tr>




                <tr>
                    <td class="padding5"></td>
                    <td class="padding5">

                        <asp:Button ID="btnVerifyOTP" CssClass="button1" runat="server" Text="Verify OTP" OnClick="btnVerifyOTP_Click" /></td>
                </tr>
            </table>
        </div>
    </asp:Panel>


    <asp:Panel ID="AfterOTPVerification" runat="server" Visible="false">
        <div class="contain_padding">
            <p style="color: green">Your Complaint has been Registered.</p>
        </div>
        
    </asp:Panel>


</asp:Content>

