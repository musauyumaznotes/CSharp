<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenekler.aspx.cs" Inherits="CvEntityProje.Yetenekler1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-responsive" style="margin: 20px">
        <tr>
            <th>Id</th>
            <th>Yetenek</th>
            <th>Derece</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%></td>
                    <td><%#Eval("Yetenek")%></td>
                    <td><%#Eval("Derece")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"YetenekSil.aspx?Id=" + Eval("Id") %>'>Sil</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%#"YetenekGuncelle.aspx?Id=" + Eval("Id") %>'>Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YetenekEkle.aspx" class="btn btn-primary">Yeni Yetenek Ekle</a>
</asp:Content>
