<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DeneyimGuncelle.aspx.cs" Inherits="CvEntityProje.DeneyimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtDeneyim" runat="server" TextMode="MultiLine" CssClass="form-control" Height="300px"></asp:TextBox>
    <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="btnGuncelle_Click"/>
</asp:Content>
