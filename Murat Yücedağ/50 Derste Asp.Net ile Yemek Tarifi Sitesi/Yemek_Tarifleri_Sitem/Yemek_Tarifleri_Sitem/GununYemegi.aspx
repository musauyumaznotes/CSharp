<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="GununYemegi.aspx.cs" Inherits="GununYemegi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }

        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style4">
        <tr>
            <td>
                <table class="auto-style4">
                    <tr>
                        <td>
                            <asp:DataList ID="DataList2" runat="server" Width="436px">
                                <ItemTemplate>
                                    <div class="auto-style2">
                                        <div class="auto-style2">
                                            <h1><strong>
                                                <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text='<%# Eval("Ad") %>'></asp:Label>
                                                </strong></h1>
                                        </div>
                                        <h2 class="auto-style7"><strong>Malzemeler :</strong></h2>
                                        <div class="auto-style7">
                                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Malzeme") %>'></asp:Label>
                                        </div>
                                        <h2 class="auto-style7">TARİF :</h2>
                                        <div class="auto-style7">
                                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("Tarif") %>'></asp:Label>
                                            <br />
                                            <br />
                                            <asp:Image ID="Image1" runat="server" Height="202px" ImageUrl='<%# Eval("Resim") %>' Width="415px" />
                                            <br />
                                        </div>
                                        <h4>Puan :
                                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("Puan") %>'></asp:Label>
                                        </h4>
                                        <h4>Eklenme Tarihi :<em>
                                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("Tarih") %>'></asp:Label>
                                            </em>
                                            <br />
                                        </h4>
                                        <p>
                                            &nbsp;</p>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

