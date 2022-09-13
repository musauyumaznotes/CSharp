<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="HakkimizdaAdmin.aspx.cs" Inherits="HakkimizdaAdmin" %>

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
            margin-left: 40px;
        }
        .auto-style15 {
            text-align: center;
            margin-left: 40px;
        }
        .auto-style16 {
            font-size: medium;
        }
        .auto-style17 {
            font-size: large;
            font-weight: bold;
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
                <td>&nbsp; HAKKIMIZDA</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server">
        <table class="auto-style6">
            <tr>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" Height="300px" TextMode="MultiLine" Width="435px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style17" OnClick="Button2_Click" Text="GÜNCELLE" Width="200px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

