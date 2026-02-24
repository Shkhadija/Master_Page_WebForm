<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Login.aspx.vb" Inherits="WebApplication2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login-box">
        <h2>Login</h2>

        <asp:TextBox ID="txtUser" runat="server" CssClass="input" placeholder="Username"></asp:TextBox>

        <asp:TextBox ID="txtPass" runat="server" CssClass="input" TextMode="Password" placeholder="Password"></asp:TextBox>

        <asp:Button ID="btnLogin" runat="server" Text="Daxil ol" CssClass="btn" OnClick="btnLogin_Click" />

        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </div>

</asp:Content>
