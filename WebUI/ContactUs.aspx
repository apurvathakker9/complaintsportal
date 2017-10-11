<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
        <td>Your Name:</td>
        <td>
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>

        </td>

        </tr>
         <tr>
        <td>Your Phone:</td>
        <td>
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox>

        </td>
        </tr>

         <tr>
        <td>Email:</td>
        <td>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>

        </td>
        </tr>

         <tr>
        <td>Message:</td>
        <td>
            <asp:TextBox ID="Message" runat="server"  TextMode="MultiLine" ></asp:TextBox>
        </td>
        </tr>

        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Send" />
        </td>
        </tr>

       </table>
    
    </div>
    </form>
</body>
</html>
