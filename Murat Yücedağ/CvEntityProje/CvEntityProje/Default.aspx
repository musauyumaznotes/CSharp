<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CvEntityProje.Default" %>

<!--Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="zxx">
<head>
    <title>Cv Sitesi</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <meta name="keywords" content="Conjoint Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola web design" />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href="web/css/bootstrap.css" type="text/css" rel="stylesheet" media="all">
    <link href="web/css/style.css" type="text/css" rel="stylesheet" media="all">
    <!-- font-awesome icons -->
    <link href="web/css/fontawesome-all.min.css" rel="stylesheet">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
    <link href="//fonts.googleapis.com/css?family=Lato:100,300,400,700,900" rel="stylesheet">
    <!-- //online-fonts -->
</head>
<body>
    <div class="sidenav text-center">
        <div class="side_top">
            <img src="web/images/musa.jpg" alt="news image" class="img-fluid navimg">
            <h1 class="top_hd mt-2"><a href="index.html">MUSA UYUMAZ</a></h1>
            <p class="top_hdp mt-2">Elektrik Elektronik Mühendisi | Yazılım Geliştirici</p>
        </div>
        <!-- header -->
        <header>
            <div class="nav-top">
                <nav class="mnu mx-auto">
                    <label for="drop" class="toggle">Menu</label>
                    <input type="checkbox" id="drop">
                    <ul class="menu">
                        <li class="active"><a href="#home" class="scroll">Anasayfa</a></li>
                        <li class="mt-sm-3"><a href="#about" class="scroll">Eğitim Hayatım</a></li>
                        <li class="mt-sm-3"><a href="#services" class="scroll">Yeteneklerim</a></li>
                        <li class="mt-sm-3"><a href="#news" class="scroll">Deneyimlerim</a></li>
                        <li class="mt-sm-3"><a href="#contact" class="scroll">İletişim</a></li>
                    </ul>
                </nav>
            </div>
        </header>
        <!-- //header -->
    </div>
    <div class="main">
        <div class="banner-text-w3ls" id="home">
            <div class="container">
                <div class="mx-auto text-center">
                    <h3>Yazılım Cv Yetenek Sitesi
                    </h3>
                    <p class="banp mx-auto mt-3">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <%#Eval("Ad") %> <%#Eval("Soyad") %>
                            </ItemTemplate>
                        </asp:Repeater>
                    </p>
                    <a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" href="#about" role="button">Daha Fazla...</a>
                </div>
            </div>
        </div>
        <!-- about -->
        <section class="slide-wrapper" id="about">
            <h2 class="w3_head mb-4">Eğitim</h2>

            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <p class="iner mt-md-5">
                        <%#Eval("Egitim") %>
                    </p>
                </ItemTemplate>
            </asp:Repeater>

        </section>
        <!-- //about -->
        <!-- services -->
        <section class="services" id="services">
            <div class="container">
                <h3 class="w3_head mb-4 text-left">Yeteneklerim</h3>
                <ul class="list-unstyled mt-5">
                    <li>
                        <asp:Repeater ID="Repeater4" runat="server">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col-2 ic-lft">
                                        <span class="fa fa-code"></span>
                                    </div>
                                    <div class="col-10">
                                        <h6><%#Eval("Yetenek") %></h6>
                                        <br />
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </li>
                </ul>
            </div>
        </section>
        <!-- //services -->
        <!-- news -->
        <div class="news" id="news">
            <h3 class="w3_head mb-4 text-left">Deneyimlerim</h3>
            <asp:Repeater ID="Repeater3" runat="server">
                <ItemTemplate>
                    <p class="iner mt-md-5 text-left">
                        <%#Eval("IsDeneyimleri") %>
                    </p>
                </ItemTemplate>
            </asp:Repeater>



        </div>
        <!-- //news -->
        <!-- contact -->
        <section class="wedo" id="contact">
            <h3 class="w3_head mb-4 text-left">İletişim</h3>

            <div class="contact_grid_right mt-5 mx-auto text-left">
                <form action="#" method="post" runat="server">
                    <div class="row contact_top">
                        <div class="col-sm-6">
                            <asp:TextBox ID="txtAdSoyad" runat="server" placeHolder="Adınız Soyadınız" required=""></asp:TextBox>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="txtEmail" runat="server" placeHolder="Emailiniz" required=""></asp:TextBox>
                        </div>
                    </div>
                    <asp:TextBox ID="txtKonu" runat="server" placeHolder="Konu" required=""></asp:TextBox>
                    <asp:TextBox ID="txtMesaj" runat="server" placeHolder="Mesajınız" required="" TextMode="MultiLine" Height="50px"/>
                    
                    <asp:Button ID="btnGonder" Text="Gönder" runat="server" CssClass="btn btn-info" OnClick="btnGonder_Click" />
                    <asp:Button ID="btnVazgec" Text="Vazgeç" runat="server" CssClass="btn btn-warning" />
                    <div class="clearfix"></div>
                </form>
            </div>
            <div class="cpy-right text-center">
                <p>
                    © 2021 | Design by UYUMAZ CORPORATION
                </p>
            </div>
        </section>
        <!-- //contact -->
    </div>

</body>
</html>
