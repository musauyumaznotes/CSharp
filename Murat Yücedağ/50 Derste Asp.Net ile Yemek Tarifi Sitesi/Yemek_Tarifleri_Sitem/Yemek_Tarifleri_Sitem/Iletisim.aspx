<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style6 {
        text-align: right;
    }
    .auto-style7 {
        height: 26px;
        font-size: x-large;
        color: #66FF33;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style4">
    <tr>
        <td class="auto-style7" colspan="2"><strong><em>MESAJ PANELİ</em></strong></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Konu :</strong></td>
        <td>
            <asp:TextBox ID="txtKonu" runat="server" CssClass="tb5" Height="50px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Mail Adresiniz :</strong></td>
        <td>
            <asp:TextBox ID="txtMail" runat="server" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Ad Soyad :</strong></td>
        <td>
            <asp:TextBox ID="txtAdSoyad" runat="server" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Mesaj :</strong></td>
        <td>
            <asp:TextBox ID="txtMesaj" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td><strong>
            <asp:Button ID="btnGonder" runat="server" CssClass="fb8" Text="Gönder" Width="231px" Height="50px" OnClick="Button1_Click" />
            </strong></td>
    </tr>
</table>
</asp:Content>

