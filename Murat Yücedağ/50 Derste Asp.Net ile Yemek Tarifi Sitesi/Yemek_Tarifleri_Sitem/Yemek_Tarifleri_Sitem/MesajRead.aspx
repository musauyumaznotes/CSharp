<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="MesajRead.aspx.cs" Inherits="MesajRead" %>

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
            font-size: x-large;
        }
        .auto-style15 {
            text-align: right;
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
                <td>&nbsp; MESAJ LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style14" Text='<%# Eval("Gonderen") %>'></asp:Label>
                            </strong></td>
                        <td class="auto-style15">
                            <a href="MesajDetay.aspx?MesajId=<%#Eval("MesajId")%>"><asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Icons/read_online_80px.png" Width="40px" /></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>

