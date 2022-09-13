<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListele.aspx.cs" Inherits="OgrenciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Id</th>
            <th>Adı</th>
            <th>Soyadı</th>
            <th>Numara</th>
            <th>Şifre</th>
            <th>Bakiye</th>
            <th>Fotoğraf</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="repeater1" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%#Eval("Id")%></td>
                        <td><%#Eval("Ad")%></td>
                        <td><%#Eval("Soyad")%></td>
                        <td><%#Eval("Numara")%></td>
                        <td><%#Eval("Sifre")%></td>
                        <td><%#Eval("Bakiye")%></td>
                        <td><%#Eval("Fotograf")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciSil.aspx?Id="+Eval("Id") %> ID="hyperlink1" runat="server" cssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciGuncelle.aspx?Id="+Eval("Id") %> ID="hyperlink2" runat="server" cssClass="btn btn-success">Güncelle</asp:HyperLink>
                            
                        </td>
                    </tr>
                </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

