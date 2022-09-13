<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="CommentDetails.aspx.cs" Inherits="CommentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style8 {
        font-size: large;
        text-align: right;
    }
    .auto-style9 {
        text-align: center;
    }
    .auto-style10 {
        font-size: large;
        font-weight: bold;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
    <tr>
        <td class="auto-style8"><strong>Ad Soyad:</strong></td>
        <td>
            <asp:TextBox ID="txtAdSoyad" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8"><strong>Mail:</strong></td>
        <td>
            <asp:TextBox ID="txtMail" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8"><strong>İçerik:</strong></td>
        <td>
            <asp:TextBox ID="txtIcerik" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8"><strong>Yemek:</strong></td>
        <td>
            <asp:TextBox ID="txtYemek" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style9"><strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style10" Height="50px" OnClick="Button1_Click" Text="Onayla" Width="200px" />
            </strong></td>
    </tr>
</table>
</asp:Content>

