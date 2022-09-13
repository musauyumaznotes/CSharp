<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="KategoriAdminDetay.aspx.cs" Inherits="KategoriAdminDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            font-size: medium;
            font-weight: bold;
        }
        .auto-style9 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9"><strong>Kategori Ad:</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"><strong>Resim:</strong></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><strong>
                <asp:Button ID="btnGuncelle" runat="server" CssClass="auto-style8" Text="Güncelle" Width="150px" OnClick="btnGuncelle_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

