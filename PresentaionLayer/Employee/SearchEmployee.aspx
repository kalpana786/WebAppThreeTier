<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SearchEmployee.aspx.cs" Inherits="PresentaionLayer.Employee.SearchEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Search Employee
     <table>
        <tr>
            <td>ID</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                <br />
            </td>
        </tr>
    </table>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px"></asp:DetailsView>
</asp:Content>
