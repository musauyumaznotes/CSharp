<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="KategoriDetay.aspx.cs" Inherits="KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style4 {
            width: 100%;
        }
        .auto-style6 {
            background-color: #000066;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style9 {
            color: #FFFF00;
        }
        .auto-style7 {
            height: 27px;
        }
        .auto-style5 {
            color: #FFFFFF;
        }
        .auto-style8 {
            font-size: large;
            color: #FFFFFF;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server">
    <ItemTemplate>
        <table class="auto-style4">
            <tr>
                <td class="auto-style6">
                    <h3 class="auto-style10"><a href="YemekDetay.aspx?Id=<%# Eval("KategoriId") %>">
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style9" Text='<%# Eval("Ad") %>'></asp:Label>
                        </a></h3>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>Malzemeler :</strong>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Malzeme") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td><strong>Tarif : </strong>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("Tarif") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="auto-style4">
                        <tr>
                            <td><strong>Eklenme Tarihi : </strong>
                                <asp:Label ID="Label7" runat="server" CssClass="auto-style5" Text='<%# Eval("Tarih") %>'></asp:Label>
                            </td>
                            <td>&nbsp;<strong> Puan :</strong> <strong>
                                <asp:Label ID="Label8" runat="server" CssClass="auto-style8" Text='<%# Eval("Puan") %>'></asp:Label>
                                </strong></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

