<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MainWebForm.master" CodeBehind="MyPersonDetail.aspx.vb" Inherits="db2.MyPersonDetail" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContentArea">
<table>
    <tr><td>ID:</td><td><asp:Label ID="IDDisplay" runat="server" Width="104px"></asp:Label></td></tr>
    <tr><td>Name:</td><td><asp:TextBox ID="NameEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>Phone:</td><td><asp:TextBox ID="PhoneEntry" runat="server" Width="233px"></asp:TextBox></td></tr>
    <tr><td>Address:</td><td><asp:TextBox ID="AddressEntry" runat="server"></asp:TextBox></td></tr>
    <tr><td>Address Type:</td><td><asp:DropDownList ID="AddressTypesList" runat="server"></asp:DropDownList></td></tr>
    <tr><td colspan="2"><asp:Label ID="DisplayMessage" runat="server" Width="527px"></asp:Label></td></tr>
    <tr><td align="center" colspan="2">
        <table>
            <tr><td><asp:Button ID="cmdSave" runat="server" Text="Save" Width="82px" /></td>
                <td><asp:Button ID="cmdCancel" runat="server" Text="Cancel" Width="82px" /></td>
                <td><asp:Button ID="cmdDelete" runat="server" Text="Delete" Width="82px" /></td> 
            </tr>
        </table>
    </td></tr>
</table>
</asp:Content>   
