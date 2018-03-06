<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="customWrap">
        <form method="POST">
            <input name="Age" type="text" placeholder="Age"/>
            <input name="Gender" type="text" placeholder="Gender"/>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Submit" />

        </form>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
