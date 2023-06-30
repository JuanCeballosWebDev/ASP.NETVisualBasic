<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MyPersonRecords.aspx.vb" MasterPageFile="~/MainWebForm.master" Inherits="db2.MyPersonRecords" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContentArea">
    
    <asp:Button ID="cmdAdd" runat="server" Text="Add New" Width="82px" /><br />
    <br />

    <asp:Repeater ID="personRepeater" runat="server">
      <HeaderTemplate>
      <table>
            <tr>
              <td><b>ID</b></td>
              <td><b>First Name</b></td>
              <td><b>Last Name</b></td>
              <td><b>City/Town</b></td>
              <td><b>State</b></td>
              <td><b>Zip Code</b></td>
              <td><b>Phone Number</b></td>
              <td><b>Age</b></td>
            </tr>   
      </HeaderTemplate>
      
      <ItemTemplate>
            <tr>
              <td><%#Eval("id")%></td>
              <td><asp:LinkButton PersonID='<%#Eval("id")%>' ID="PersonLink" runat="server"><%# Eval("firstname") %></asp:LinkButton></td>
              <td><%# Eval("lastname") %></td>
              <td><%# Eval("citytown") %></td>
              <td><%# Eval("state") %></td>
              <td><%# Eval("zipcode") %></td>
              <td><%# Eval("phonenumber") %></td>
              <td><%# Eval("age") %></td>
            </tr>
       </ItemTemplate>
       <FooterTemplate>
       </table>
       </FooterTemplate>
    </asp:Repeater>
</asp:Content>