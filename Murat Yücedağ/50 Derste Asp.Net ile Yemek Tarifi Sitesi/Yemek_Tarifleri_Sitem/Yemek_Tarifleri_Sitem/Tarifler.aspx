<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Tarifler.aspx.cs" Inherits="Tarifler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 40px;
        }

        .auto-style8 {
            font-size: 14pt;
            font-weight: bold;
        }

        .auto-style13 {
            width: 35px;
        }

        .auto-style14 {
            text-align: right;
        }

        .auto-style15 {
            font-size: x-large;
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
            <itemtemplate>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style15" Text='<%# Eval("TarifAd") %>'></asp:Label>
                        </strong></td>
                        <td class="auto-style14">
                            <a href="YemekDuzenle.aspx?TarifId=<%#Eval("TarifId") %>">
                                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/Icons/edit_property_128px.png" Width="40px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </itemtemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>

