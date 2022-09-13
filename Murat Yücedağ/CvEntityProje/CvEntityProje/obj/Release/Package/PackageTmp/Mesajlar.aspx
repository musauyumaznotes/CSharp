<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Mesajlar.aspx.cs" Inherits="CvEntityProje.Mesajlar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-responsive" style="margin: 20px">
        <tr>
            <th>Id</th>
            <th>Ad Soyad</th>
            <th>Mail</th>
            <th>Konu</th>
            <th>Tarih</th>
            <th>Mesajı Gör</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%></td>
                    <td><%#Eval("AdSoyad")%></td>
                    <td><%#Eval("Mail")%></td>
                    <td><%#Eval("Konu")%></td>
                    <td><%#Eval("Tarih")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"MesajDetay.aspx?Id=" + Eval("Id") %>'>Mesajı Gör</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
