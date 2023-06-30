<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MyPersonRecords.aspx.vb" MasterPageFile="~/MainWebForm.master" Inherits="db2.MyPersonRecords" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContentArea">
    
    <asp:Button ID="cmdAdd" runat="server" Text="Add New" Width="82px" /><br />
    <br />

    <asp:Repeater ID="personRepeater" runat="server">
      <HeaderTemplate>
        <table>
        <tr>
          <td><b>ID</b></td>
          <td><b>Person Name</b></td>
          <td><b>Address</b></td>
          <td><b>Phone Number</b></td>
        </tr>      </HeaderTemplate>
      
      <ItemTemplate>
        <tr>
          <td><%#Eval("id")%></td>
          <td><asp:LinkButton PersonID='<%#Eval("id")%>' ID="PersonLink" runat="server"><%# Eval("personname") %></asp:LinkButton></td>
          <td><%# Eval("address") %></td>
          <td><%# Eval("phonenumber") %></td>
        </tr>
      </ItemTemplate>
      <FooterTemplate>
        </table>
      </FooterTemplate>
    </asp:Repeater>
</asp:Content>