<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="panel1" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style9"><strong>
                    <asp:Button ID="btnListele" runat="server" CssClass="auto-style8" OnClick="btnListele_Click" Text="+" Width="40px" Height="40px" />
                </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="btnListeKapat" runat="server" CssClass="auto-style8" Text="-" Width="40px" OnClick="btnListeKapat_Click" Height="40px" />
                </strong></td>
                <td>&nbsp; KATEGORİ LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server">
        &nbsp<asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                        </strong></td>
                        <td class="auto-style10">
                            <a href="Categories.aspx?KategoriId=<%#Eval("KategoriId") %>&islem=sil">
                                <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Icons/delete_512px.png" Width="40px" /></a>
                        </td>
                        <td class="auto-style10">
                            <a href="KategoriAdminDetay.aspx?KategoriId=<%#Eval("KategoriId") %>">
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
                    <asp:Button ID="btnEklemeOpen" runat="server" CssClass="auto-style8" Height="40px" OnClick="btnEklemeOpen_Click" Text="+" Width="40px" />
                </strong></td>
                <td class="auto-style12"><strong>
                    <asp:Button ID="btnEklemeOff" runat="server" CssClass="auto-style8" Height="40px" OnClick="btnEklemeOff_Click" Text="-" Width="40px" />
                </strong></td>
                <td>&nbsp; KATEGORİ EKLEME</td>
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
                <td>Kategori Adı:</td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kategori Resim:</td>
                <td>
                    <asp:FileUpload ID="fUResim" runat="server" />
                </td>
            </tr>
            <tr>

                <td><strong>
                    <asp:Button ID="btnEkle" runat="server" CssClass="auto-style8" OnClick="btnEkle_Click" Text="Ekle" Width="100px" />
                </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

