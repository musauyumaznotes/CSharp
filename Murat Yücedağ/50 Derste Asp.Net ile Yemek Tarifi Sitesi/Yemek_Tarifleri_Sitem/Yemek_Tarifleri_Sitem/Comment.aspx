<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Comment.aspx.cs" Inherits="Comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 40px;
            height: 44px;
        }

        .auto-style8 {
            font-size: 14pt;
            font-weight: bold;
        }

        .auto-style13 {
            width: 35px;
            height: 44px;
        }

        .auto-style11 {
            width: 209px;
        }

        .auto-style10 {
            text-align: center;
        }

        .auto-style14 {
            height: 44px;
        }

        .auto-style15 {
            margin-right: 0px;
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
                <td class="auto-style14">&nbsp;ONAYLANAN YORUM LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server" CssClass="auto-style15">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("AdSoyad") %>'></asp:Label>
                        </strong></td>
                        <td class="auto-style10">

                            <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Icons/delete_512px.png" Width="40px" />
                        </td>
                        <td class="auto-style10">

                            <a href="CommentDetails.aspx?YorumId=<%#Eval("YorumId")%>">
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
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style8" Text="+" Width="40px" Height="40px" OnClick="Button1_Click" />
                </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style8" Text="-" Width="40px" Height="40px" OnClick="Button2_Click" />
                </strong></td>
                <td class="auto-style14">&nbsp;ONAYLANMAYAN YORUM LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panel4" runat="server" CssClass="auto-style15">
        <asp:DataList ID="DataList2" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("AdSoyad") %>'></asp:Label>
                        </strong></td>
                        <td class="auto-style10">

                            <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Icons/delete_512px.png" Width="40px" />
                        </td>
                        <td class="auto-style10">

                            <a href="CommentDetails.aspx?YorumId=<%#Eval("YorumId")%>">
                                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/Icons/update.png" Width="40px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>

