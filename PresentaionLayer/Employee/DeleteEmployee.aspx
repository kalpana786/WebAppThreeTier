<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="PresentaionLayer.Employee.DeleteEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    delete employee
     <table>
        <tr>
            <td>ID</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" /></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

    </table>
</asp:Content>
