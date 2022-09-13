<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="TarifOner.aspx.cs" Inherits="TarifOner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            text-align: justify;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            font-weight: bold;
            font-style: italic;
        }
        .auto-style8 {
            text-align: right;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">
                <div class="auto-style2">
                    <table class="auto-style4">
                        <tr>
                            <td class="auto-style8"><strong>Yemek Adı:</strong></td>
                            <td>
                            <asp:TextBox ID="txtYemekAd" runat="server" TextMode="Email" Width="250px" CssClass="tb5"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style6"><strong>Malzemeler:</strong></td>
                        <td>
                            <asp:TextBox ID="txtMalzeme" runat="server" Height="80px" TextMode="MultiLine" Width="250px" CssClass="tb5"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Tarif:</strong></td>
                        <td>
                            <asp:TextBox ID="txtTarif" runat="server" Height="150px" TextMode="MultiLine" Width="250px" CssClass="tb5"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Kategori:</strong></td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="252px" CssClass="tb5">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Resim:</strong></td>
                        <td>
                            <asp:FileUpload ID="fileUploadResim" runat="server" Width="250px" CssClass="tb5" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Email:</strong></td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="250px" CssClass="tb5"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Ad Soyad:</strong></td>
                        <td>
                            <asp:TextBox ID="txtAdSoyad" runat="server" Width="250px" CssClass="tb5"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <div class="auto-style2">
                    <strong><em>
                    <asp:Button ID="btnTarifOner" runat="server" BackColor="#66CCFF" CssClass="fb8" Height="40px" Text="Tarif Öner" Width="150px" OnClick="btnTarifOner_Click" />
                    </em></strong>
                </div>
                    <br />
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

