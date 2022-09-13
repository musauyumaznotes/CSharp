<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="YemekDetay.aspx.cs" Inherits="YemekDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: xx-large;
            color: #0066CC;
            background-color: #CCFFFF;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            font-size: x-large;
            background-color: #99CCFF;
        }
        .auto-style8 {
            font-size: small;
        }
        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            height: 29px;
            width: 123px;
            text-align: right;
        }
        .auto-style13 {
            width: 123px;
        }
        .auto-style14 {
            width: 123px;
            height: 26px;
            text-align: right;
        }
        .auto-style15 {
            height: 26px;
        }
        .auto-style17 {
            text-align: center;
            background-color: #FF9999;
        }
        .auto-style18 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <h1><strong>
                <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text='<%# Eval("Ad") %>'></asp:Label>
                </strong></h1>
        </ItemTemplate>
    </asp:DataList>
    <asp:DataList ID="DataList3" runat="server">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td><strong><em>
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style7" Text='<%# Eval("AdSoyad") %>'></asp:Label>
                        </em></strong></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style3" Text='<%# Eval("Yorum") %>'></asp:Label>
                        &nbsp;-
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style8" Text='<%# Eval("Tarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <div class="auto-style17">YORUM YAPMA PANELİ</div>
    <asp:Panel runat="server">
        <table class="auto-style6">
            <tr>
                <td class="auto-style11"><strong>Ad Soyad :</strong></td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtAdSoyad" runat="server" Height="20px" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Mail :</strong></td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtMail" runat="server" Height="20px" Width="308px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Yorumunuz : </strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtYorum" runat="server" Height="100px" TextMode="MultiLine" Width="309px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10"><strong>
                    <asp:Button ID="btnKaydet" runat="server" CssClass="auto-style18" OnClick="Button1_Click" Text="Yorum Yap" Width="200px" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

