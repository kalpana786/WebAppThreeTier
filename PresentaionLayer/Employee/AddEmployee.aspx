<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="PresentaionLayer.Employee.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
    .auto-style1 {
        height: 24px;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p> add employee</p>
    <table>
        <tr>
            <td>ID</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Salary</td>
            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Department</td>
            <td><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>

