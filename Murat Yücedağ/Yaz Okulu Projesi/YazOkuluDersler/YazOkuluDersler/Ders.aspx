<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ders.aspx.cs" Inherits="Ders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <asp:Label Text="Ders Seçin" runat="server" />
            <asp:DropDownList ID="dropList" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label Text="Öğrenci Id" runat="server" />
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"/>
        </div>
        <br />
        <div>
            <asp:Button Text="Ders Talep Oluştur" runat="server" CssClass="btn btn-warning" OnClick="Unnamed3_Click"/></div>

    </form>
</asp:Content>

