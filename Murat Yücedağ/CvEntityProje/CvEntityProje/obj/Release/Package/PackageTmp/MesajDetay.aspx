<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProje.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Mesaj Detayları</h4>
    <br />
    Ad Soyad:<asp:textbox ID="txtAdSoyad" runat="server" cssClass="form-control"/><br />
    Mail:<asp:textbox ID="txtMail" runat="server" cssClass="form-control"/><br />
    Konu:<asp:textbox ID="txtKonu" runat="server" cssClass="form-control"/><br />
    Mesaj:<asp:textbox ID="txtMesaj" runat="server" cssClass="form-control" Height="100px" TextMode="MultiLine"/><br />
    <asp:Button ID="btnSil" runat="server" Text="Sil" cssClass="btn btn-danger" OnClick="btnSil_Click"/>
    <asp:Button ID="btnVazgec" runat="server" Text="Vazgeç" cssClass="btn btn-warning" OnClick="btnVazgec_Click"/>
</asp:Content>
