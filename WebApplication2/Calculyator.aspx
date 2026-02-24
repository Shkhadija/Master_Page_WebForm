<%@ Page Title="Calculator" Language="vb" MasterPageFile="~/Site1.Master" AutoEventWireup="false" CodeBehind="Calculator.aspx.vb" Inherits="WebApplication2.Calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Sadə Calculator</h2>

    <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
    <br /><br />

    <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Button ID="btnAdd" runat="server" Text="Topla" OnClick="btnAdd_Click" />
    <asp:Button ID="btnSub" runat="server" Text="Çıx" OnClick="btnSub_Click" />
    <asp:Button ID="btnMul" runat="server" Text="Vur" OnClick="btnMul_Click" />
    <asp:Button ID="btnDiv" runat="server" Text="Böl" OnClick="btnDiv_Click" />

    <br /><br />

    <asp:Label ID="lblResult" runat="server" Font-Bold="true"></asp:Label>

</asp:Content>