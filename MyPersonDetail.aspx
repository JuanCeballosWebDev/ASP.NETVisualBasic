<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MainWebForm.master" CodeBehind="MyPersonDetail.aspx.vb" Inherits="db2.MyPersonDetail" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContentArea">
<table>
    <tr><td>ID:</td><td><asp:Label ID="IDDisplay" runat="server" Width="104px"></asp:Label></td></tr>
    <tr><td>First Name:</td><td><asp:TextBox ID="FirstNameEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>Last Name:</td><td><asp:TextBox ID="LastNameEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>City/Town:</td><td><asp:TextBox ID="CityTownEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>State:</td><td><asp:TextBox ID="StateEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>Zip Code:</td><td><asp:TextBox ID="ZipCodeEntry" runat="server" Width="113px"></asp:TextBox></td></tr>
    <tr><td>Phone:</td><td><asp:TextBox ID="PhoneEntry" runat="server" Width="233px"></asp:TextBox></td></tr>
    <tr><td>Age:</td><td><asp:TextBox ID="AgeEntry" runat="server" Width="65px"></asp:TextBox></td></tr>
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
