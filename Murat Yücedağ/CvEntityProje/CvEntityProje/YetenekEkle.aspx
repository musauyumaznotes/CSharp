<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekEkle.aspx.cs" Inherits="CvEntityProje.YetenekEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>Yeni Yetenek Ekleme Sayfası</h4>
    <br />
    <asp:TextBox ID="txtYetenek" runat="server" placeHolder="Yetenek Giriniz" CssClass="form form-control " />
    <br />
    <asp:TextBox ID="txtDerece" runat="server" placeHolder="Derece Giriniz" CssClass="form form-control " />
    <br />
    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" CssClass="btn btn-info"/>
</asp:Content>
