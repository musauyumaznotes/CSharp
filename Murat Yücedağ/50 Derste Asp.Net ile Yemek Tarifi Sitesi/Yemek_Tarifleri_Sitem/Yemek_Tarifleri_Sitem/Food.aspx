<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Food.aspx.cs" Inherits="Food" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style8 {
            font-size: 14pt;
            font-weight: bold;
        }

        .auto-style9 {
            width: 40px;
        }

        .auto-style11 {
            width: 209px;
        }

        .auto-style10 {
            text-align: center;
        }

        .auto-style12 {
            width: 37px;
        }

        .auto-style13 {
            width: 35px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style16 {
            font-size: 20pt;
            font-weight: bold;
        }
        .auto-style17 {
            height: 29px;
            text-align: center;
        }
        .auto-style18 {
            height: 29px;
            font-size: large;
        }
        .auto-style19 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="panel1" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style9"><strong>
                    <asp:Button ID="btnListele" runat="server" CssClass="auto-style8" Text="+" Width="40px" Height="40px" OnClick="btnListele_Click" />
                </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="btnListeKapat" runat="server" CssClass="auto-style8" Text="-" Width="40px" Height="40px" OnClick="btnListeKapat_Click" />
                </strong></td>
                <td>&nbsp; YEMEK LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server">
        &nbsp<asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </strong></td>
                        <td class="auto-style10">
                            <a href="Food.aspx?YemekId=<%#Eval("YemekId") %>&islem=sil">
                                <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Icons/delete_512px.png" Width="40px" /></a>
                        </td>
                        <td class="auto-style10">
                            <a href="YemekDuzenle.aspx?TarifId=<%#Eval("TarifId") %>">
                                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/Icons/update.png" Width="40px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="panel3" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style9"><strong>
                    <asp:Button ID="btnEklemeOpen" runat="server" CssClass="auto-style8" Height="40px" Text="+" Width="40px" OnClick="btnEklemeOpen_Click" />
                </strong></td>
                <td class="auto-style12"><strong>
                    <asp:Button ID="btnEklemeOff" runat="server" CssClass="auto-style8" Height="40px" Text="-" Width="40px" OnClick="btnEklemeOff_Click" />
                </strong></td>
                <td>&nbsp; YEMEK EKLEME</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel4" runat="server">
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>Yemek Adı:</strong></td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Malzemeler:</strong></td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtMalzeme" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Yemek Tarifi:</strong></td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtTarif" runat="server" Height="200px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Kategori:</strong></td>
                <td class="auto-style14">
                    <asp:DropDownList ID="dListKategori" runat="server" CssClass="auto-style19" Height="25px" Width="300px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Resim:</strong></td>
                <td class="auto-style14">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="296px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style17"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style16" Height="40px" Text="Ekle" Width="200px" OnClick="Button1_Click" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style17"></td>
            </tr>
        </table>
    </asp:Panel>
    </asp:Content>



