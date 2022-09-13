<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="YemekDuzenle.aspx.cs" Inherits="YemekDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            height: 29px;
            width: 308px;
        }
        .auto-style9 {
            height: 29px;
            font-size: large;
            width: 160px;
        }
        .auto-style14 {
            height: 28px;
            font-size: large;
            width: 160px;
        }
        .auto-style15 {
            height: 28px;
            width: 308px;
        }
        .auto-style17 {
            font-size: large;
            width: 160px;
        }
        .auto-style18 {
            width: 220px;
        }
        .auto-style19 {
            text-align: right;
        }
        .auto-style20 {
            width: 308px;
        }
        .auto-style21 {
            height: 28px;
            font-size: large;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style17"><strong>Yemek Ad:</strong></td>
            <td class="auto-style20">
                <asp:TextBox ID="txtYemekAd" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"><strong>Malzeme:</strong></td>
            <td class="auto-style8">
                <asp:TextBox ID="txtMalzeme" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Tarif:</strong></td>
            <td class="auto-style20">
                <asp:TextBox ID="txtTarif" runat="server" Height="200px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Kategori</strong></td>
            <td class="auto-style20">
                <asp:DropDownList ID="dListKategori" runat="server" Width="300px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"><strong>Resim</strong></td>
            <td class="auto-style15">
                <asp:FileUpload ID="fUploadResim" runat="server" Width="300px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                <strong>
                    <asp:Button ID="btnGuncelle" runat="server" CssClass="auto-style7"  Text="Güncelle" Width="200px" OnClick="btnGuncelle_Click" />
                    </strong>
            </td>
        </tr>
        </table>
    &nbsp;&nbsp;&nbsp;
    <table class="auto-style6">
        <tr>
            <td class="auto-style18">
                <strong>
                    <asp:Button ID="btnGununYemegi" runat="server" CssClass="auto-style7"  Text="Günün Yemeği Yap" Width="200px" OnClick="btnGununYemegi_Click" />
                    </strong>
            </td>
            <td class="auto-style19">
                <strong>
                    <asp:Button ID="btnOnayla" runat="server" CssClass="auto-style7"  Text="Onayla" Width="200px" OnClick="btnOnayla_Click"  />
                    </strong>
            </td>
        </tr>
    </table>
</asp:Content>

