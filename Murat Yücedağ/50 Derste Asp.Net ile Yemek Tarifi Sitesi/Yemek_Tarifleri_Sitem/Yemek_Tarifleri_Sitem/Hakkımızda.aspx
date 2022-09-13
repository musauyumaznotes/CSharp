<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkımızda.aspx.cs" Inherits="Hakkımızda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>HAKKIMIZDA</h1>
<asp:DataList ID="DataList2" runat="server">
    <ItemTemplate>
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
    </ItemTemplate>
</asp:DataList>
<asp:Image ImageUrl="~/Resimler/yemekler.jpg" runat="server" Height="185px" Width="448px" ID="Image1" /><br />
    <br />

</asp:Content>

