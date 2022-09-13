<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="MesajDetay.aspx.cs" Inherits="MesajDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            width: 82px;
        }
        .auto-style9 {
            width: 82px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            font-weight: bold;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Baslik:</td>
            <td>
                <asp:TextBox ID="txtBaslik" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Gonderen:</td>
            <td>
                <asp:TextBox ID="txtGonderen" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Mail:</td>
            <td>
                <asp:TextBox ID="txtMail" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">İçerik:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtIcerik" runat="server" Height="150px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table class="auto-style6">
        <tr>
            <td class="auto-style11"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style12" Height="40px" OnClick="Button1_Click" Text="Sil" Width="200px" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

