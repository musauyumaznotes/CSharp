<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">

         <div>
            <strong>
            <asp:Label ID="label6" for="txtId" Text="Öğrenci Id:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" />
        </div>
        <div>
            <strong>
            <asp:Label ID="label1" for="txtAd" Text="Öğrenci Adı:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtAd" runat="server" CssClass="form-control" />
        </div>
        <div>
            <strong>
            <asp:Label ID="label2" for="txtSoyad" Text="Öğrenci Soyadı:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control" />
        </div>
        <div>
            <strong>
            <asp:Label ID="label3" for="txtNumara" Text="Numara:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control" />
        </div>
        <div>
            <strong>
            <asp:Label ID="label4" for="txtSifre" Text="Şifre:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" />
        </div>
        <div>
            <strong>
            <asp:Label ID="label5" for="txtFoto" Text="Fotoğraf:" runat="server" style="font-size: large" />
            </strong>
            <asp:TextBox ID="txtFoto" runat="server" CssClass="form-control" />
        </div>
        

        <asp:Button ID="Button1" Text="Güncelle" runat="server"  CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>

